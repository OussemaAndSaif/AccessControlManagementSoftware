#pragma checksum "C:\Users\saifb\source\repos\AccesSoftwareManagement\CoreApplicationFromScratchGLSI-A\Areas\Admin\Views\User\UserManagement.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c0ffaa44e3b026c3c4911a95639d458e662a8058"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_User_UserManagement), @"mvc.1.0.view", @"/Areas/Admin/Views/User/UserManagement.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\saifb\source\repos\AccesSoftwareManagement\CoreApplicationFromScratchGLSI-A\Areas\Admin\Views\_ViewImports.cshtml"
using AccessControlManagementSoftware;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\saifb\source\repos\AccesSoftwareManagement\CoreApplicationFromScratchGLSI-A\Areas\Admin\Views\_ViewImports.cshtml"
using AccessControlManagementSoftware.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c0ffaa44e3b026c3c4911a95639d458e662a8058", @"/Areas/Admin/Views/User/UserManagement.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"931905a1820e38ce0f1bad3fde997ac7761d15e0", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_User_UserManagement : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<AccessControlManagementSoftware.Models.ApplicationUser>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\saifb\source\repos\AccesSoftwareManagement\CoreApplicationFromScratchGLSI-A\Areas\Admin\Views\User\UserManagement.cshtml"
  
    ViewData["Title"] = "UserManagement";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<h1>UserManagement</h1>\n");
#nullable restore
#line 8 "C:\Users\saifb\source\repos\AccesSoftwareManagement\CoreApplicationFromScratchGLSI-A\Areas\Admin\Views\User\UserManagement.cshtml"
 foreach(var item in Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h4>");
#nullable restore
#line 10 "C:\Users\saifb\source\repos\AccesSoftwareManagement\CoreApplicationFromScratchGLSI-A\Areas\Admin\Views\User\UserManagement.cshtml"
   Write(item.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\n");
#nullable restore
#line 11 "C:\Users\saifb\source\repos\AccesSoftwareManagement\CoreApplicationFromScratchGLSI-A\Areas\Admin\Views\User\UserManagement.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<AccessControlManagementSoftware.Models.ApplicationUser>> Html { get; private set; }
    }
}
#pragma warning restore 1591
