#pragma checksum "C:\Users\381240\SAIT\6_214_Net_Web_Ap\Assignments\Lab2\Final\CPRG214.Assets\CPRG214.Assets.Tracking\Views\Shared\Components\AssetsByType\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2b5eef43baff4d5690dcd4eb26e9bf41d75ca138"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_AssetsByType_Default), @"mvc.1.0.view", @"/Views/Shared/Components/AssetsByType/Default.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2b5eef43baff4d5690dcd4eb26e9bf41d75ca138", @"/Views/Shared/Components/AssetsByType/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2f6c6407e2f26583defe12edfa18d44a1600ef82", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_AssetsByType_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<CPRG214.Assets.Tracking.Models.AssetViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 10 "C:\Users\381240\SAIT\6_214_Net_Web_Ap\Assignments\Lab2\Final\CPRG214.Assets\CPRG214.Assets.Tracking\Views\Shared\Components\AssetsByType\Default.cshtml"
  
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral("<h4> Assets</h4>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 18 "C:\Users\381240\SAIT\6_214_Net_Web_Ap\Assignments\Lab2\Final\CPRG214.Assets\CPRG214.Assets.Tracking\Views\Shared\Components\AssetsByType\Default.cshtml"
           Write(Html.DisplayNameFor(model => model.TagNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 21 "C:\Users\381240\SAIT\6_214_Net_Web_Ap\Assignments\Lab2\Final\CPRG214.Assets\CPRG214.Assets.Tracking\Views\Shared\Components\AssetsByType\Default.cshtml"
           Write(Html.DisplayNameFor(model => model.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 24 "C:\Users\381240\SAIT\6_214_Net_Web_Ap\Assignments\Lab2\Final\CPRG214.Assets\CPRG214.Assets.Tracking\Views\Shared\Components\AssetsByType\Default.cshtml"
           Write(Html.DisplayNameFor(model => model.SerialNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 27 "C:\Users\381240\SAIT\6_214_Net_Web_Ap\Assignments\Lab2\Final\CPRG214.Assets\CPRG214.Assets.Tracking\Views\Shared\Components\AssetsByType\Default.cshtml"
           Write(Html.DisplayNameFor(model => model.AssetType));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 33 "C:\Users\381240\SAIT\6_214_Net_Web_Ap\Assignments\Lab2\Final\CPRG214.Assets\CPRG214.Assets.Tracking\Views\Shared\Components\AssetsByType\Default.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
#nullable restore
#line 37 "C:\Users\381240\SAIT\6_214_Net_Web_Ap\Assignments\Lab2\Final\CPRG214.Assets\CPRG214.Assets.Tracking\Views\Shared\Components\AssetsByType\Default.cshtml"
               Write(Html.DisplayFor(modelItem => item.TagNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 40 "C:\Users\381240\SAIT\6_214_Net_Web_Ap\Assignments\Lab2\Final\CPRG214.Assets\CPRG214.Assets.Tracking\Views\Shared\Components\AssetsByType\Default.cshtml"
               Write(Html.DisplayFor(modelItem => item.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 43 "C:\Users\381240\SAIT\6_214_Net_Web_Ap\Assignments\Lab2\Final\CPRG214.Assets\CPRG214.Assets.Tracking\Views\Shared\Components\AssetsByType\Default.cshtml"
               Write(Html.DisplayFor(modelItem => item.SerialNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 46 "C:\Users\381240\SAIT\6_214_Net_Web_Ap\Assignments\Lab2\Final\CPRG214.Assets\CPRG214.Assets.Tracking\Views\Shared\Components\AssetsByType\Default.cshtml"
               Write(Html.DisplayFor(modelItem => item.AssetType));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 49 "C:\Users\381240\SAIT\6_214_Net_Web_Ap\Assignments\Lab2\Final\CPRG214.Assets\CPRG214.Assets.Tracking\Views\Shared\Components\AssetsByType\Default.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<CPRG214.Assets.Tracking.Models.AssetViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
