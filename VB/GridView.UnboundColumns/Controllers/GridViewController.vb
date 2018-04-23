Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web
Imports System.Web.Mvc
Imports GridView.UnboundColumns.Models

Namespace GridView.UnboundColumns.Controllers
	<HandleError> _
	Public Class GridViewController
		Inherits Controller
		Public Function Index() As ActionResult
			Return UnboundColumns()
		End Function
		Public Function UnboundColumns() As ActionResult
			Return View("UnboundColumns", NorthwindDataProvider.GetInvoices())
		End Function
		Public Function UnboundColumnsPartial() As ActionResult
			Return PartialView("UnboundColumnsPartial", NorthwindDataProvider.GetInvoices())
		End Function
	End Class
End Namespace
