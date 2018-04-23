<%@ Control Language="C#" Inherits="System.Web.Mvc.ViewUserControl<dynamic>" %>

<%
    Html.DevExpress().GridView(settings => {
        settings.Name = "dxgridView";
        settings.CallbackRouteValues = new { controller = "GridView", Action = "UnboundColumnsPartial" };
        
        settings.Columns.Add("CompanyName");
        settings.Columns.Add("UnitPrice").PropertiesEdit.DisplayFormatString = "c";
        settings.Columns.Add("Quantity");
        var column = settings.Columns.Add("Total");
        column.PropertiesEdit.DisplayFormatString = "c";
        column.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;

        settings.CustomUnboundColumnData = (sender, e) => {
            if(e.Column.FieldName == "Total") {
                decimal price = (decimal)e.GetListSourceFieldValue("UnitPrice");
                int quantity = Convert.ToInt32(e.GetListSourceFieldValue("Quantity"));
                e.Value = price * quantity;
            }
        };
    })
    .Bind(Model)
    .Render();
%>

