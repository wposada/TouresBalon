#pragma checksum "C:\Users\hecto\source\repos\SimplCommerce\src\Modules\SimplCommerce.Module.Core\Areas\Core\Views\Dashboard\HomeTemplate.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6638722c43d7c8019107f55093b936c1085e2343"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Core_Views_Dashboard_HomeTemplate), @"mvc.1.0.view", @"/Areas/Core/Views/Dashboard/HomeTemplate.cshtml")]
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
#line 1 "C:\Users\hecto\source\repos\SimplCommerce\src\Modules\SimplCommerce.Module.Core\Areas\Core\Views\_ViewImports.cshtml"
using SimplCommerce.Module.Core;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\hecto\source\repos\SimplCommerce\src\Modules\SimplCommerce.Module.Core\Areas\Core\Views\_ViewImports.cshtml"
using SimplCommerce.Module.Core.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\hecto\source\repos\SimplCommerce\src\Modules\SimplCommerce.Module.Core\Areas\Core\Views\_ViewImports.cshtml"
using SimplCommerce.Module.Core.Areas.Core.ViewModels.Account;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\hecto\source\repos\SimplCommerce\src\Modules\SimplCommerce.Module.Core\Areas\Core\Views\_ViewImports.cshtml"
using SimplCommerce.Module.Core.Areas.Core.ViewModels.Manage;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\hecto\source\repos\SimplCommerce\src\Modules\SimplCommerce.Module.Core\Areas\Core\Views\_ViewImports.cshtml"
using SimplCommerce.Module.Core.Extensions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\hecto\source\repos\SimplCommerce\src\Modules\SimplCommerce.Module.Core\Areas\Core\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\hecto\source\repos\SimplCommerce\src\Modules\SimplCommerce.Module.Core\Areas\Core\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6638722c43d7c8019107f55093b936c1085e2343", @"/Areas/Core/Views/Dashboard/HomeTemplate.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"39ae4a4c81275951e35f765ffa4071b0e7b3dc51", @"/Areas/Core/Views/_ViewImports.cshtml")]
    public class Areas_Core_Views_Dashboard_HomeTemplate : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\hecto\source\repos\SimplCommerce\src\Modules\SimplCommerce.Module.Core\Areas\Core\Views\Dashboard\HomeTemplate.cshtml"
  
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>");
#nullable restore
#line 5 "C:\Users\hecto\source\repos\SimplCommerce\src\Modules\SimplCommerce.Module.Core\Areas\Core\Views\Dashboard\HomeTemplate.cshtml"
Write(Localizer["Dashboard"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n\r\n<div class=\"row\">\r\n    <div class=\"col-md-6\">\r\n        <div class=\"panel panel-default\">\r\n            <div class=\"panel-heading\">\r\n                <h3 class=\"panel-title\">");
#nullable restore
#line 11 "C:\Users\hecto\source\repos\SimplCommerce\src\Modules\SimplCommerce.Module.Core\Areas\Core\Views\Dashboard\HomeTemplate.cshtml"
                                   Write(Localizer["Latest orders"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n            </div>\r\n            <div class=\"panel-body\">\r\n                <order-widget status=\"0\" num-records=\"5\"></order-widget>\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 18 "C:\Users\hecto\source\repos\SimplCommerce\src\Modules\SimplCommerce.Module.Core\Areas\Core\Views\Dashboard\HomeTemplate.cshtml"
     if (User.IsInRole("admin"))
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"col-md-6\">\r\n        <div class=\"panel panel-default\">\r\n            <div class=\"panel-heading\">\r\n                <h3 class=\"panel-title\">");
#nullable restore
#line 23 "C:\Users\hecto\source\repos\SimplCommerce\src\Modules\SimplCommerce.Module.Core\Areas\Core\Views\Dashboard\HomeTemplate.cshtml"
                                   Write(Localizer["Pending reviews"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n            </div>\r\n            <div class=\"panel-body\">\r\n                <review-widget status=\"1\" num-records=\"5\"></review-widget>\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 30 "C:\Users\hecto\source\repos\SimplCommerce\src\Modules\SimplCommerce.Module.Core\Areas\Core\Views\Dashboard\HomeTemplate.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
#nullable restore
#line 32 "C:\Users\hecto\source\repos\SimplCommerce\src\Modules\SimplCommerce.Module.Core\Areas\Core\Views\Dashboard\HomeTemplate.cshtml"
 if (User.IsInRole("admin"))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"row\">\r\n    <div class=\"col-md-6\">\r\n        <div class=\"panel panel-default\">\r\n            <div class=\"panel-heading\">\r\n                <h3 class=\"panel-title\">");
#nullable restore
#line 38 "C:\Users\hecto\source\repos\SimplCommerce\src\Modules\SimplCommerce.Module.Core\Areas\Core\Views\Dashboard\HomeTemplate.cshtml"
                                   Write(Localizer["Pending review replies"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n            </div>\r\n            <div class=\"panel-body\">\r\n                <review-reply-widget status=\"1\" num-records=\"5\"></review-reply-widget>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
#nullable restore
#line 46 "C:\Users\hecto\source\repos\SimplCommerce\src\Modules\SimplCommerce.Module.Core\Areas\Core\Views\Dashboard\HomeTemplate.cshtml"
}

#line default
#line hidden
#nullable disable
#nullable restore
#line 47 "C:\Users\hecto\source\repos\SimplCommerce\src\Modules\SimplCommerce.Module.Core\Areas\Core\Views\Dashboard\HomeTemplate.cshtml"
 if (User.IsInRole("admin"))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"row\">\r\n    <div class=\"col-md-6\">\r\n        <div class=\"panel panel-default\">\r\n            <div class=\"panel-heading\">\r\n                <h3 class=\"panel-title\">");
#nullable restore
#line 53 "C:\Users\hecto\source\repos\SimplCommerce\src\Modules\SimplCommerce.Module.Core\Areas\Core\Views\Dashboard\HomeTemplate.cshtml"
                                   Write(Localizer["Most searched keywords"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h3>
            </div>
            <div class=""panel-body"">
                <most-search-keyword></most-search-keyword>
            </div>
        </div>
    </div>
    <div class=""col-md-6"">
        <div class=""panel panel-default"">
            <div class=""panel-heading"">
                <h3 class=""panel-title"">");
#nullable restore
#line 63 "C:\Users\hecto\source\repos\SimplCommerce\src\Modules\SimplCommerce.Module.Core\Areas\Core\Views\Dashboard\HomeTemplate.cshtml"
                                   Write(Localizer["Most viewed products"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n            </div>\r\n            <div class=\"panel-body\">\r\n                <most-viewed-products></most-viewed-products>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
#nullable restore
#line 71 "C:\Users\hecto\source\repos\SimplCommerce\src\Modules\SimplCommerce.Module.Core\Areas\Core\Views\Dashboard\HomeTemplate.cshtml"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IViewLocalizer Localizer { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
