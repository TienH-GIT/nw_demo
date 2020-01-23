Imports DemoWebApp1.Models
Imports System.Data.Entity
Imports System.Data.Entity.ModelConfiguration.Conventions

Namespace DAL
    Public Class EmployeeContext
        Inherits DbContext

        Public Sub New()
            'MyBase.New("EmployeeContext")
        End Sub

        Public Property Employees As DbSet(Of Employee)
    End Class
End Namespace
