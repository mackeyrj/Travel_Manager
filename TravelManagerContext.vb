Imports Microsoft.EntityFrameworkCore

Public Class TravelManagerContext
    Inherits DbContext

    Public Property Traveler As DbSet(Of Traveler)
    Public Property Expense As DbSet(Of Expense)
    Public Property Trip As DbSet(Of Trip)
    Public Property TravelMethod As DbSet(Of TravelMethod)
    Public Property TripDetail As DbSet(Of TripDetail)
    Public Property FrequentFlyer As DbSet(Of FrequentFlyer)

    Protected Overrides Sub OnConfiguring(optionsBuilder As DbContextOptionsBuilder)
        optionsBuilder.UseJet("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Z:\My Documents\Projects\VB\TravelManager\Travel_Manager.accdb;Persist Security Info=False;")
    End Sub
End Class