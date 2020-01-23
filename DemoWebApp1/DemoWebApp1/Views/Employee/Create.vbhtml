@ModelType DemoWebApp1.Models.Employee
@Code
    ViewData("Title") = "Create"
End Code

<h2>Create</h2>

@Using (Html.BeginForm())
    @Html.AntiForgeryToken()

    @<div class="form-horizontal">
        <h4>Employee</h4>
        <hr />
        @Html.ValidationSummary(True)
        <div class="form-group">
            @Html.LabelFor(Function(model) model.FirstName, New With {.class = "control-label col-md-2"})
            <div class="col-md-10">
                @Html.EditorFor(Function(model) model.FirstName)
                @Html.ValidationMessageFor(Function(model) model.FirstName)
            </div>
        </div>

        <div class="form-group">
            @Html.LabelFor(Function(model) model.LastName, New With {.class = "control-label col-md-2"})
            <div class="col-md-10">
                @Html.EditorFor(Function(model) model.LastName)
                @Html.ValidationMessageFor(Function(model) model.LastName)
            </div>
        </div>

        <div class="form-group">
            @Html.LabelFor(Function(model) model.Gender, New With {.class = "control-label col-md-2"})
            <div class="col-md-10">
                @Html.EditorFor(Function(model) model.Gender)
                @Html.ValidationMessageFor(Function(model) model.Gender)
            </div>
        </div>

        <div class="form-group">
            @Html.LabelFor(Function(model) model.Birthday, New With {.class = "control-label col-md-2"})
            <div class="col-md-10">
                @Html.EditorFor(Function(model) model.Birthday)
                @Html.ValidationMessageFor(Function(model) model.Birthday)
            </div>
        </div>

        <div class="form-group">
            @Html.LabelFor(Function(model) model.Age, New With {.class = "control-label col-md-2"})
            <div class="col-md-10">
                @Html.EditorFor(Function(model) model.Age)
                @Html.ValidationMessageFor(Function(model) model.Age)
            </div>
        </div>

        <div class="form-group">
            @Html.LabelFor(Function(model) model.Address, New With {.class = "control-label col-md-2"})
            <div class="col-md-10">
                @Html.EditorFor(Function(model) model.Address)
                @Html.ValidationMessageFor(Function(model) model.Address)
            </div>
        </div>

        <div class="form-group">
            @Html.LabelFor(Function(model) model.Career, New With {.class = "control-label col-md-2"})
            <div class="col-md-10">
                @Html.EditorFor(Function(model) model.Career)
                @Html.ValidationMessageFor(Function(model) model.Career)
            </div>
        </div>

        <div class="form-group">
            @Html.LabelFor(Function(model) model.Hobby, New With {.class = "control-label col-md-2"})
            <div class="col-md-10">
                @Html.EditorFor(Function(model) model.Hobby)
                @Html.ValidationMessageFor(Function(model) model.Hobby)
            </div>
        </div>

        <div class="form-group">
            <div class="col-md-offset-2 col-md-10">
                <input type="submit" value="Create" class="btn btn-default" />
            </div>
        </div>
    </div>
End Using

<div>
    @Html.ActionLink("Back to List", "List")
</div>

@Section Scripts 
    @Scripts.Render("~/bundles/jqueryval")
End Section
