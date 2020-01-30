Imports DemoWebApp1.EntityConfigs
Imports DemoWebApp1.Models
Imports System.Data.Entity
Imports System.Data.Entity.ModelConfiguration.Conventions

Namespace DAL
    Public Class EmployeeContext
        Inherits DbContext

        Public Sub New()
            MyBase.New("EmployeeContext")
        End Sub

        Public Property Employees As DbSet(Of Employee)
        Public Property PersonalInfoes As DbSet(Of PersonalInfo)
        Public Property Branches As DbSet(Of Branch)
        Public Property JobTitles As DbSet(Of JobTitle)

        Protected Overrides Sub OnModelCreating(modelBuilder As DbModelBuilder)
            ' Distributed EntityConfiguration class
            modelBuilder.Configurations _
                .Add(New EmployeeEntityConfig()) _
                .Add(New PersonalInfoEntityConfig()) _
                .Add(New BranchEntityConfig()) _
                .Add(New JobTitleEntityConfig())

            modelBuilder.Entity(Of Employee) _
                .HasRequired(Function(p) p.Detail) _
                .WithRequiredPrincipal(Function(s) s.Employee)
        End Sub
    End Class
End Namespace
