#pragma checksum "C:\Users\hecto\source\repos\SimplCommerce\src\Modules\SimplCommerce.Module.WishList\Areas\WishList\Views\WishList\PublicList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b4449ff17f4cd2e6510b92b64dd31edf09f180c6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_WishList_Views_WishList_PublicList), @"mvc.1.0.view", @"/Areas/WishList/Views/WishList/PublicList.cshtml")]
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
#line 1 "C:\Users\hecto\source\repos\SimplCommerce\src\Modules\SimplCommerce.Module.WishList\Areas\WishList\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\hecto\source\repos\SimplCommerce\src\Modules\SimplCommerce.Module.WishList\Areas\WishList\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\hecto\source\repos\SimplCommerce\src\Modules\SimplCommerce.Module.WishList\Areas\WishList\Views\WishList\PublicList.cshtml"
using cloudscribe.Web.Pagination;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b4449ff17f4cd2e6510b92b64dd31edf09f180c6", @"/Areas/WishList/Views/WishList/PublicList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"22201ab66a3d1f02b4f3d4942c97fa2c598a0bf8", @"/Areas/WishList/Views/_ViewImports.cshtml")]
    public class Areas_WishList_Views_WishList_PublicList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SimplCommerce.Module.WishList.Areas.WishList.ViewModels.WishListVm>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/_content/SimplCommerce.Module.WishList/public-list.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("cs-pagenumber-param", "pageNumber", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "WishList", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "PublicList", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("cs-pager-li-current-class", "page-item active", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("cs-pager-li-other-class", "page-item", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("cs-pager-li-non-active-class", "page-item disabled", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("cs-pager-link-current-class", "page-link", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("cs-pager-link-other-class", "page-link", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::SimplCommerce.Module.Core.Extensions.TagHelpers.AppendVersionTagHelper __SimplCommerce_Module_Core_Extensions_TagHelpers_AppendVersionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::cloudscribe.Web.Pagination.PagerTagHelper __cloudscribe_Web_Pagination_PagerTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\hecto\source\repos\SimplCommerce\src\Modules\SimplCommerce.Module.WishList\Areas\WishList\Views\WishList\PublicList.cshtml"
  
    ViewData["Title"] = Localizer["Wish List"];

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            DefineSection("head", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "b4449ff17f4cd2e6510b92b64dd31edf09f180c67894", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __SimplCommerce_Module_Core_Extensions_TagHelpers_AppendVersionTagHelper = CreateTagHelper<global::SimplCommerce.Module.Core.Extensions.TagHelpers.AppendVersionTagHelper>();
                __tagHelperExecutionContext.Add(__SimplCommerce_Module_Core_Extensions_TagHelpers_AppendVersionTagHelper);
#nullable restore
#line 9 "C:\Users\hecto\source\repos\SimplCommerce\src\Modules\SimplCommerce.Module.WishList\Areas\WishList\Views\WishList\PublicList.cshtml"
__SimplCommerce_Module_Core_Extensions_TagHelpers_AppendVersionTagHelper.AppendVersion = true;

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("simpl-append-version", __SimplCommerce_Module_Core_Extensions_TagHelpers_AppendVersionTagHelper.AppendVersion, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
            }
            );
            WriteLiteral("\r\n<div class=\"row\">\r\n    <div class=\"wishlist col-md-12\">\r\n        <h2>");
#nullable restore
#line 14 "C:\Users\hecto\source\repos\SimplCommerce\src\Modules\SimplCommerce.Module.WishList\Areas\WishList\Views\WishList\PublicList.cshtml"
       Write(Localizer["Wish List"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n        <hr />\r\n");
#nullable restore
#line 16 "C:\Users\hecto\source\repos\SimplCommerce\src\Modules\SimplCommerce.Module.WishList\Areas\WishList\Views\WishList\PublicList.cshtml"
         if (Model.Items.TotalItems > 0)
        {
            foreach (var item in Model.Items.Data)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"row item\">\r\n                    <div class=\"col-md-4\">\r\n                        <img");
            BeginWriteAttribute("alt", " alt=\"", 661, "\"", 684, 1);
#nullable restore
#line 22 "C:\Users\hecto\source\repos\SimplCommerce\src\Modules\SimplCommerce.Module.WishList\Areas\WishList\Views\WishList\PublicList.cshtml"
WriteAttributeValue("", 667, item.ProductName, 667, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"img-fluid\"");
            BeginWriteAttribute("src", " src=\"", 703, "\"", 727, 1);
#nullable restore
#line 22 "C:\Users\hecto\source\repos\SimplCommerce\src\Modules\SimplCommerce.Module.WishList\Areas\WishList\Views\WishList\PublicList.cshtml"
WriteAttributeValue("", 709, item.ProductImage, 709, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                    </div>\r\n                    <div class=\"col-md-8\">\r\n                        <h4>");
#nullable restore
#line 25 "C:\Users\hecto\source\repos\SimplCommerce\src\Modules\SimplCommerce.Module.WishList\Areas\WishList\Views\WishList\PublicList.cshtml"
                       Write(item.ProductName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                        <p>");
#nullable restore
#line 26 "C:\Users\hecto\source\repos\SimplCommerce\src\Modules\SimplCommerce.Module.WishList\Areas\WishList\Views\WishList\PublicList.cshtml"
                      Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b4449ff17f4cd2e6510b92b64dd31edf09f180c612501", async() => {
                WriteLiteral("\r\n                            <p>");
#nullable restore
#line 28 "C:\Users\hecto\source\repos\SimplCommerce\src\Modules\SimplCommerce.Module.WishList\Areas\WishList\Views\WishList\PublicList.cshtml"
                          Write(Localizer["Quantity"]);

#line default
#line hidden
#nullable disable
                WriteLiteral(": ");
#nullable restore
#line 28 "C:\Users\hecto\source\repos\SimplCommerce\src\Modules\SimplCommerce.Module.WishList\Areas\WishList\Views\WishList\PublicList.cshtml"
                                                  Write(item.Quantity);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n                            <input type=\"hidden\" name=\"itemId\"");
                BeginWriteAttribute("value", " value=\"", 1074, "\"", 1090, 1);
#nullable restore
#line 29 "C:\Users\hecto\source\repos\SimplCommerce\src\Modules\SimplCommerce.Module.WishList\Areas\WishList\Views\WishList\PublicList.cshtml"
WriteAttributeValue("", 1082, item.Id, 1082, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                            <input type=\"hidden\" name=\"productId\"");
                BeginWriteAttribute("value", " value=\"", 1161, "\"", 1184, 1);
#nullable restore
#line 30 "C:\Users\hecto\source\repos\SimplCommerce\src\Modules\SimplCommerce.Module.WishList\Areas\WishList\Views\WishList\PublicList.cshtml"
WriteAttributeValue("", 1169, item.ProductId, 1169, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                            <input type=\"hidden\" name=\"quantity\" class=\"quantity-field\"");
                BeginWriteAttribute("value", " value=\"", 1277, "\"", 1299, 1);
#nullable restore
#line 31 "C:\Users\hecto\source\repos\SimplCommerce\src\Modules\SimplCommerce.Module.WishList\Areas\WishList\Views\WishList\PublicList.cshtml"
WriteAttributeValue("", 1285, item.Quantity, 1285, 14, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                            <button type=\"button\" class=\"btn btn-lg btn-add-cart\">");
#nullable restore
#line 32 "C:\Users\hecto\source\repos\SimplCommerce\src\Modules\SimplCommerce.Module.WishList\Areas\WishList\Views\WishList\PublicList.cshtml"
                                                                             Write(Localizer["Add to cart"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</button>\r\n                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 36 "C:\Users\hecto\source\repos\SimplCommerce\src\Modules\SimplCommerce.Module.WishList\Areas\WishList\Views\WishList\PublicList.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div>\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("cs-pager", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b4449ff17f4cd2e6510b92b64dd31edf09f180c616770", async() => {
            }
            );
            __cloudscribe_Web_Pagination_PagerTagHelper = CreateTagHelper<global::cloudscribe.Web.Pagination.PagerTagHelper>();
            __tagHelperExecutionContext.Add(__cloudscribe_Web_Pagination_PagerTagHelper);
#nullable restore
#line 38 "C:\Users\hecto\source\repos\SimplCommerce\src\Modules\SimplCommerce.Module.WishList\Areas\WishList\Views\WishList\PublicList.cshtml"
__cloudscribe_Web_Pagination_PagerTagHelper.PageSize = Model.Items.PageSize;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("cs-paging-pagesize", __cloudscribe_Web_Pagination_PagerTagHelper.PageSize, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 39 "C:\Users\hecto\source\repos\SimplCommerce\src\Modules\SimplCommerce.Module.WishList\Areas\WishList\Views\WishList\PublicList.cshtml"
__cloudscribe_Web_Pagination_PagerTagHelper.PageNumber = Model.Items.PageNumber;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("cs-paging-pagenumber", __cloudscribe_Web_Pagination_PagerTagHelper.PageNumber, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 40 "C:\Users\hecto\source\repos\SimplCommerce\src\Modules\SimplCommerce.Module.WishList\Areas\WishList\Views\WishList\PublicList.cshtml"
__cloudscribe_Web_Pagination_PagerTagHelper.TotalItems = Model.Items.TotalItems;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("cs-paging-totalitems", __cloudscribe_Web_Pagination_PagerTagHelper.TotalItems, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __cloudscribe_Web_Pagination_PagerTagHelper.PageNumberParam = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __cloudscribe_Web_Pagination_PagerTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __cloudscribe_Web_Pagination_PagerTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__cloudscribe_Web_Pagination_PagerTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "cloudscribe.Web.Pagination.PagerTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 44 "C:\Users\hecto\source\repos\SimplCommerce\src\Modules\SimplCommerce.Module.WishList\Areas\WishList\Views\WishList\PublicList.cshtml"
                            WriteLiteral(Model.SharingCode);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __cloudscribe_Web_Pagination_PagerTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __cloudscribe_Web_Pagination_PagerTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 45 "C:\Users\hecto\source\repos\SimplCommerce\src\Modules\SimplCommerce.Module.WishList\Areas\WishList\Views\WishList\PublicList.cshtml"
                                  WriteLiteral(Model.Items.PageSize);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __cloudscribe_Web_Pagination_PagerTagHelper.RouteValues["pageSize"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-pageSize", __cloudscribe_Web_Pagination_PagerTagHelper.RouteValues["pageSize"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __cloudscribe_Web_Pagination_PagerTagHelper.LiCurrentCssClass = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __cloudscribe_Web_Pagination_PagerTagHelper.LiOtherCssClass = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __cloudscribe_Web_Pagination_PagerTagHelper.LiNonActiveCssClass = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            __cloudscribe_Web_Pagination_PagerTagHelper.LinkCurrentCssClass = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            __cloudscribe_Web_Pagination_PagerTagHelper.LinkOtherCssClass = (string)__tagHelperAttribute_9.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </div>\r\n");
#nullable restore
#line 52 "C:\Users\hecto\source\repos\SimplCommerce\src\Modules\SimplCommerce.Module.WishList\Areas\WishList\Views\WishList\PublicList.cshtml"
        }
        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <p>");
#nullable restore
#line 55 "C:\Users\hecto\source\repos\SimplCommerce\src\Modules\SimplCommerce.Module.WishList\Areas\WishList\Views\WishList\PublicList.cshtml"
          Write(Localizer["There are currently no items in the wish list."]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 56 "C:\Users\hecto\source\repos\SimplCommerce\src\Modules\SimplCommerce.Module.WishList\Areas\WishList\Views\WishList\PublicList.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SimplCommerce.Module.WishList.Areas.WishList.ViewModels.WishListVm> Html { get; private set; }
    }
}
#pragma warning restore 1591
