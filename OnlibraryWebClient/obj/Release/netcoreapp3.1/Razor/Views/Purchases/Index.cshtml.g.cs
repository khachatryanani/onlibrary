#pragma checksum "C:\Users\DELL\source\repos\Onlibrary\OnlibraryWebClient\Views\Purchases\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "28263629886ee1bd963e5dc8dc84804c9977969c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Purchases_Index), @"mvc.1.0.view", @"/Views/Purchases/Index.cshtml")]
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
#line 1 "C:\Users\DELL\source\repos\Onlibrary\OnlibraryWebClient\Views\_ViewImports.cshtml"
using OnlibraryWebClient;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\DELL\source\repos\Onlibrary\OnlibraryWebClient\Views\_ViewImports.cshtml"
using OnlibraryDataAccess.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\DELL\source\repos\Onlibrary\OnlibraryWebClient\Views\_ViewImports.cshtml"
using OnlibraryDataAccess.BaseClasses;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\DELL\source\repos\Onlibrary\OnlibraryWebClient\Views\_ViewImports.cshtml"
using OnlibraryWebClient.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"28263629886ee1bd963e5dc8dc84804c9977969c", @"/Views/Purchases/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b9f9e460191abb3cb459e5d25b1b0b23aedaf103", @"/Views/_ViewImports.cshtml")]
    public class Views_Purchases_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<string>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n<div class=\"card card-outline-primary m-1 p-1\">\n    <div class=\"bg-faded p-1 font-weight-bolder\">\n        <h3>\n           Order passed successfully!\n        </h3>\n        <h4>OrderId: ");
#nullable restore
#line 8 "C:\Users\DELL\source\repos\Onlibrary\OnlibraryWebClient\Views\Purchases\Index.cshtml"
                Write(Model);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\n    </div>\n    <hr />\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<string> Html { get; private set; }
    }
}
#pragma warning restore 1591