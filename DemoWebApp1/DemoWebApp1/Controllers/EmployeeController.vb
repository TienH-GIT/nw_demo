Imports System.Data.Entity
Imports System.Net
Imports DemoWebApp1.DAL
Imports DemoWebApp1.Models

Namespace Controllers
    Public Class EmployeeController
        Inherits System.Web.Mvc.Controller

        Private db As New EmployeeContext

        ' GET: /Employee/
        Function List() As ActionResult
            ViewData("Message") = "List All members"

            Return View(db.Employees.ToList())
        End Function

        ' GET: /Student/Details/1
        Function Detail(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim emp As Employee = db.Employees.Find(id)
            If IsNothing(emp) Then
                Return HttpNotFound()
            End If
            Return View(emp)
        End Function

        ' GET: /Student/Create
        Function Create() As ActionResult
            Return View()
        End Function

        ' POST: /Student/Create
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Create(<Bind(Include:="FirstName,LastName,Gender,Birthday,Age,Address,Career,Hobby")> ByVal emp As Employee) As ActionResult
            Try
                If ModelState.IsValid Then
                    db.Employees.Add(emp)
                    db.SaveChanges()
                    Return RedirectToAction("List")
                End If
            Catch dex As DataException
                'Log the error (add a line here to write a log)
                ModelState.AddModelError("", "Unable to save changes. Try again, and of the problem persists see your system administrator. ")
            End Try
            Return View(emp)
        End Function

        ' GET: /Student/Edit/1
        Function Edit(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim emp As Employee = db.Employees.Find(id)
            If IsNothing(emp) Then
                Return HttpNotFound()
            End If
            Return View(emp)
        End Function


        <HttpPost(), ActionName("Edit")>
        <ValidateAntiForgeryToken()>
        Function EditPost(ByVal id? As Integer) As ActionResult
            If id Is Nothing Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim empForUpd = db.Employees.Find(id)
            If TryUpdateModel(empForUpd, "", New String() {
                              "FirstName", "LastName", "Gender", "Birthday", "Age",
                              "Address", "Career", "Hobby"}) Then
                Try
                    db.Entry(empForUpd).State = EntityState.Modified
                    db.SaveChanges()
                    Return RedirectToAction("List")
                Catch Dex As DataException
                    'Log the error (uncomment dex variable name and add a line here to write a log.
                    ModelState.AddModelError("", "Unable to save changes. Try again, and if the problem persists see your system administrator.")
                End Try
            End If
            Return View(empForUpd)
        End Function

        ' GET: /Student/Delete/1
        Function Delete(ByVal id As Integer?, Optional ByVal saveChangesError As Boolean? = False) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            If saveChangesError.GetValueOrDefault() Then
                ViewBag.Message = "Delete failed. Try again, and if the problem persists see your system administrator."
            End If
            Dim emp As Employee = db.Employees.Find(id)
            If IsNothing(emp) Then
                Return HttpNotFound()
            End If
            Return View(emp)
        End Function

        ' POST: /Student/Delete/1
        <HttpPost()>
        <ActionName("Delete")>
        <ValidateAntiForgeryToken()>
        Function Delete(ByVal id As Integer) As ActionResult
            Try
                Dim emp As Employee = db.Employees.Find(id)
                db.Employees.Remove(emp)
                db.SaveChanges()
            Catch dex As DataException
                'Log the error (uncomment dex variable name and add a line here to write a log.
                Return RedirectToAction("Delete", New With {.id = id, .saveChangesError = True})
            End Try
            Return RedirectToAction("List")
        End Function

        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            'If (disposing) Then
            '    db.Dispose()
            'End If
            'MyBase.Dispose(disposing)
        End Sub
    End Class
End Namespace