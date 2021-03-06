' Note: For instructions on enabling IIS6 or IIS7 classic mode, 
' visit http://go.microsoft.com/?LinkId=9394802
Imports System.Web.Mvc
Imports System.Web.Routing
Public Class MvcApplication
    Inherits System.Web.HttpApplication
    Shared Sub RegisterGlobalFilters(ByVal filters As GlobalFilterCollection)
        filters.Add(New HandleErrorAttribute())
    End Sub
    Shared Sub RegisterRoutes(ByVal routes As RouteCollection)
        routes.IgnoreRoute("{resource}.axd/{*pathInfo}")
        routes.IgnoreRoute("{*allActiveReport}", New With {.allActiveReport = ".*\.ar11(/.*)?"})
        routes.MapRoute( _
            "Default", _
            "{controller}/{action}/{id}", _
            New With {.controller = "Home", .action = "Start", .id = UrlParameter.Optional} _
        )
    End Sub
    Sub Application_Start()
        AreaRegistration.RegisterAllAreas()
        RegisterGlobalFilters(GlobalFilters.Filters)
        RegisterRoutes(RouteTable.Routes)
    End Sub
End Class
