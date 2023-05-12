Imports System.Collections.Generic
Imports System.DateTime
Public Class DataClass

    ' Using List for Avoid replacement of variable and adding even 2 or more item you buy.........
    Public Shared Price As List(Of Double) = New List(Of Double)()
    Public Shared GroceryName As List(Of String) = New List(Of String)()
    Public Shared Quantity As List(Of Integer) = New List(Of Integer)()
    Public Shared Amount As List(Of Double) = New List(Of Double)()
    Public Shared TotalCost As Double

    'Temp list for reciept 
    Public Shared ReceiptPrice As List(Of Double) = New List(Of Double)()
    Public Shared ReceiptGroceryName As List(Of String) = New List(Of String)()
    Public Shared ReceiptQuantity As List(Of Integer) = New List(Of Integer)()
    Public Shared ReceiptAmount As List(Of Double) = New List(Of Double)()

    'Data of the User
    Public Shared FirstName As String
    Public Shared LastName As String
    Public Shared Address As String
    Public Shared PhoneNumber As String
    Public Shared Email As String
    Public Shared TypePayments As String
    Public Shared TypeDelivery As String
    Public Shared thisDate As Date = Today
    Public Shared RecieptNoCI As String

    'Card
    Public Shared CCV As String
    Public Shared CardName As String
    Public Shared CardNo As String
    Public Shared Expiration As String


    'Delivery Company Shipping Fees
    Public Shared DeliveryShipFess As Double

    Public Shared Function Calculation(x, y) As Double
        Return x * y
    End Function

End Class
