Imports DevExpress.Mvvm.DataAnnotations
Imports DXTabControlExample.Common
Imports System

Namespace DXTabControlExample.ViewModel
    <POCOViewModel> _
    Public Class ContactViewModel
        Public Overridable Property Id() As Integer
        Public Overridable Property Gender() As Gender
        Public Overridable Property FirstName() As String
        Public Overridable Property LastName() As String
        Public Overridable Property CreditCardNumber() As String
        Public Overridable Property Email() As String
        Public Overridable Property Phone() As String
        Public Overridable Property Address() As String
        Public Overridable Property City() As String
        Public Overridable Property State() As String
        Public Overridable Property Zip() As String
        Public Overridable Property Photo() As Byte()
        Public Overridable Property LastUpdate() As Date

        Public Sub New()
        End Sub

        Public Sub Update()
            LastUpdate = Date.Now
        End Sub
    End Class
End Namespace
