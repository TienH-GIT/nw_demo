Imports System.ComponentModel.DataAnnotations

Namespace Models
    Public Class JobTitle
        Public Property JobTitleID As Integer
        <Required>
        <MaxLength(20)>
        Public Property Code As String
        <Required>
        <MaxLength(200)>
        Public Property Name As String
        <MaxLength(500)>
        Public Property Description As String
    End Class
End Namespace
