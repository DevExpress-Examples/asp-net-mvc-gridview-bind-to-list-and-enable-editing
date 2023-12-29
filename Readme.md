<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128550026/14.1.3%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E3983)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [HomeController.cs](./CS/Sample/Controllers/HomeController.cs)
* [Person.cs](./CS/Sample/Models/Person.cs)
* [PersonsList.cs](./CS/Sample/Models/PersonsList.cs)
* **[GridViewEditingPartial.cshtml](./CS/Sample/Views/Home/GridViewEditingPartial.cshtml)**
* [Index.cshtml](./CS/Sample/Views/Home/Index.cshtml)
<!-- default file list end -->
# GridView - How to edit in memory data source


<p>This example illustrates how to bind the MVC GridView Extension with an in memory datasource (List<T>) with enabled editing capabilities.<br><br><strong>For Validation:</strong><br>Make sure that you have met the following requirements

* The Model's Properties have related Data Annotations attributes.
* The GridView's PartialView is wrapped with a form tag/container.
* The client-side/unobtrusive validation is enabled (for example, at the Web.config level).
* The related scripts are linked manually or loaded automatically by setting the embedRequiredClientLibraries configuration option to true.<br><br></p>
<p><strong>See Also:</strong><br> <a href="https://www.devexpress.com/Support/Center/p/E3530">E3530: How to bind GridView with standard in-memory data sources (DataTable, List<T>)</a><br> <a href="https://www.devexpress.com/Support/Center/p/E3998">E3998: GridView - How to specify a custom EditForm Template</a><br><br><strong>Online Demo:</strong><br><a href="http://demos.devexpress.com/MVCxGridViewDemos/Editing/EditModes">Edit Modes</a></p>

<br/>


