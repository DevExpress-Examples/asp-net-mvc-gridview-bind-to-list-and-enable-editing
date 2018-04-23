@ModelType List(Of VB.Person)
@Using (Html.BeginForm())
    @Html.Partial("GridViewEditingPartial", Model)
End Using