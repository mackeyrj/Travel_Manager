Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema
Public Class Expense
    ' Properties
    <Key>
    Public Property Traveler As String
    Public Property PurchaseDate As String
    Public Property Currency As String
    Public Property Location As String
    Public Property Type As String
    Public Property Merchant As String
    Public Property Description As String
    Public Property Amount As String
    Public Property TripName As String


    ' Constructor
    Public Sub New(merchant As String)


        Me.Merchant = merchant


    End Sub

    Public Sub New()

    End Sub
End Class
