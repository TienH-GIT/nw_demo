@ModelType DemoWebApp1.Models.Employee
@Code
    ViewData("Title") = "Details"
End Code

<h2>Details</h2>

<div>
    <h4>Employee Info</h4>
    <hr />
    <dl class="dl-horizontal">
        <dt>
            @Html.DisplayNameFor(Function(model) model.FirstName)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.FirstName)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.LastName)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.LastName)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Gender)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Gender)
        </dd>
        <dt>
            @Html.DisplayNameFor(Function(model) model.Birthday)
        </dt>
        <dd>
            @Html.DisplayFor(Function(model) model.Birthday)
        </dd>
        <dt>
            @Html.DisplayNameFor(Function(model) model.Age)
        </dt>
        <dd>
            @Html.DisplayFor(Function(model) model.Age)
        </dd>
        <dt>
            @Html.DisplayNameFor(Function(model) model.Address)
        </dt>
        <dd>
            @Html.DisplayFor(Function(model) model.Address)
        </dd>
        <dt>
            @Html.DisplayNameFor(Function(model) model.Career)
        </dt>
        <dd>
            @Html.DisplayFor(Function(model) model.Career)
        </dd>
        <dt>
            @Html.DisplayNameFor(Function(model) model.Hobby)
        </dt>
        <dd>
            @Html.DisplayFor(Function(model) model.Hobby)
        </dd>
    </dl>
</div>
<p>
    @Html.ActionLink("Edit", "Edit", New With {.id = Model.Id}) |
    @Html.ActionLink("Back to List", "List")
</p>
