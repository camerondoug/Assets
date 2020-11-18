#pragma checksum "C:\Users\381240\SAIT\6_214_Net_Web_Ap\Assignments\Lab2\Final\CPRG214.Assets\CPRG214.Assets.Tracking\Views\Assets\Search.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cc4c0a18fc7b374a4e00fcfba145f1b750ec0288"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Assets_Search), @"mvc.1.0.view", @"/Views/Assets/Search.cshtml")]
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
#line 1 "C:\Users\381240\SAIT\6_214_Net_Web_Ap\Assignments\Lab2\Final\CPRG214.Assets\CPRG214.Assets.Tracking\Views\_ViewImports.cshtml"
using CPRG214.Assets.Tracking;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\381240\SAIT\6_214_Net_Web_Ap\Assignments\Lab2\Final\CPRG214.Assets\CPRG214.Assets.Tracking\Views\_ViewImports.cshtml"
using CPRG214.Assets.Tracking.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cc4c0a18fc7b374a4e00fcfba145f1b750ec0288", @"/Views/Assets/Search.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2f6c6407e2f26583defe12edfa18d44a1600ef82", @"/Views/_ViewImports.cshtml")]
    public class Views_Assets_Search : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("uxAssetTypes"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 9 "C:\Users\381240\SAIT\6_214_Net_Web_Ap\Assignments\Lab2\Final\CPRG214.Assets\CPRG214.Assets.Tracking\Views\Assets\Search.cshtml"
  
    ViewData["Title"] = "Search";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h4>Search by Asset Type</h4>\r\n<h5>Select Asset Type from Dropdown</h5>\r\n<br />\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cc4c0a18fc7b374a4e00fcfba145f1b750ec02883961", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
#nullable restore
#line 16 "C:\Users\381240\SAIT\6_214_Net_Web_Ap\Assignments\Lab2\Final\CPRG214.Assets\CPRG214.Assets.Tracking\Views\Assets\Search.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items = ViewBag.AssetTypes;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-items", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" ");
            WriteLiteral("\r\n<br />\r\n<div id=\"uxDisplay\">\r\n    ");
#nullable restore
#line 19 "C:\Users\381240\SAIT\6_214_Net_Web_Ap\Assignments\Lab2\Final\CPRG214.Assets\CPRG214.Assets.Tracking\Views\Assets\Search.cshtml"
Write(await Component.InvokeAsync("AssetsByType", 0));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    <script>\r\n        $(document).ready(function () {\r\n            $(\"#uxAssetTypes\").change(function () { ");
                WriteLiteral("\r\n                var assetTypeID = $(\"#uxAssetTypes\").val();\r\n\r\n                $.ajax({\r\n                    method: \'GET\',\r\n                    url: \'/Assets/GetAssetsByType\',  ");
                WriteLiteral("\r\n                    data: { id: assetTypeID }  ");
                WriteLiteral("\r\n\r\n                }).done(function (result, statusText, xhdr) {\r\n                    $(\"#uxDisplay\").html(result);\r\n                });\r\n            });\r\n\r\n        });\r\n\r\n    </script>\r\n");
            }
            );
            WriteLiteral("\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591