Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web
Imports System.Collections

Namespace GridView.UnboundColumns.Models
	Public NotInheritable Class NorthwindDataProvider
		Private Shared db_Renamed As NorthwindDataContext
		Private Sub New()
		End Sub
		Public Shared ReadOnly Property DB() As NorthwindDataContext
			Get
				If db_Renamed Is Nothing Then
					db_Renamed = New NorthwindDataContext()
				End If
				Return db_Renamed
			End Get
		End Property
		Public Shared Function GetInvoices() As IEnumerable
			Return _
				From invoice In DB.Invoices _
				Join customer In DB.Customers On invoice.CustomerID Equals customer.CustomerID _
				Select New With {Key customer.CompanyName, Key invoice.UnitPrice, Key invoice.Quantity}
		End Function
	End Class
End Namespace