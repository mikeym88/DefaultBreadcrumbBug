This is a Visual Studio .NET Core 2.1 MVC project that demonstrates a bug in the [SmartBreadcrumbs NuGet Package](https://github.com/zHaytam/SmartBreadcrumbs).

* **Bug**: `[DefaultBreadcrumb("ViewData.Title")]` just displays "ViewData.Title" and not the title itself (e.g. "Home Page")
* [Link to Issue](https://github.com/zHaytam/SmartBreadcrumbs/issues/19)