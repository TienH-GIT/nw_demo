Imports DemoWebApp1.DAL
Imports DemoWebApp1.Models

Namespace ViewModels
    Public Class ViewModelEmp
        Private _db As EmployeeContext

        Public Overridable Property Employee As Employee

        Public Property ListBranch

        Public Property ListJobTitle

        Public Sub New(ByRef db As EmployeeContext)
            Me._db = db

            ' Load default data
            LoadDefault()
        End Sub

        Public Sub ViewModelEmp(ByRef db As EmployeeContext, ByVal empId As Integer)
            Me._db = db

            ' Load default data
            LoadDefault()

            ' Load employee info
            Employee = _db.Employees.Find(empId)
        End Sub

        Private Sub LoadDefault()
            ' Load list all Branches
            If Employee IsNot Nothing Then
                ListBranch = New SelectList(LoadBranches(), "BranchID", "Name", Employee.BranchID)
            End If
            ListBranch = _db.Branches.[Select](Function(m) New SelectListItem() With {
                            .Text = m.Name,
                            .Value = m.BranchID})

            ' Load list all JobInfoes
            If Employee IsNot Nothing Then
                ListJobTitle = New SelectList(LoadJobTitles(), "JobTitleID", "Name", Employee.JobTitleID)
            End If
            ListJobTitle = _db.JobTitles.[Select](Function(m) New SelectListItem() With {
                            .Text = m.Name,
                            .Value = m.JobTitleID})
        End Sub

        Private Function LoadBranches() As ICollection(Of Branch)
            Return _db.Branches.ToList()
        End Function

        Private Function LoadJobTitles() As ICollection(Of JobTitle)
            Return _db.JobTitles.ToList()
        End Function

        Public Function LoadEmployee(empId As Integer) As Employee
            Return _db.Employees.Find(empId)
        End Function
    End Class
End Namespace
