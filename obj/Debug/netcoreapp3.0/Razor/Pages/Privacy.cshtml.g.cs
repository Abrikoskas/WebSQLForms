#pragma checksum "C:\Users\Danil\source\repos\WebSQLForms\Pages\Privacy.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dbd6cf094e0be539457024b2129c80220f43a3b4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(WebSQLForms.Pages.Pages_Privacy), @"mvc.1.0.razor-page", @"/Pages/Privacy.cshtml")]
namespace WebSQLForms.Pages
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
#line 1 "C:\Users\Danil\source\repos\WebSQLForms\Pages\_ViewImports.cshtml"
using WebSQLForms;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dbd6cf094e0be539457024b2129c80220f43a3b4", @"/Pages/Privacy.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e15f91bb51884e584b2319a415e1e4c82ebdd32a", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Privacy : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\Danil\source\repos\WebSQLForms\Pages\Privacy.cshtml"
  
    ViewData["Title"] = "Privacy Policy";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h1>");
#nullable restore
#line 6 "C:\Users\Danil\source\repos\WebSQLForms\Pages\Privacy.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n\r\n<p>This page is under construction as of ");
#nullable restore
#line 8 "C:\Users\Danil\source\repos\WebSQLForms\Pages\Privacy.cshtml"
                                    Write(ViewData["TimeStamp"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PrivacyModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<PrivacyModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<PrivacyModel>)PageContext?.ViewData;
        public PrivacyModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
