#pragma checksum "D:\Projects\C#\TaskAspNetApp\TaskAspNetApp\Pages\Import.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "94fc1d0cc16964974c935d16e6df3658ad9f6303"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Pages_Import), @"mvc.1.0.razor-page", @"/Pages/Import.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemMetadataAttribute("RouteTemplate", "/Contracts/Import")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"94fc1d0cc16964974c935d16e6df3658ad9f6303", @"/Pages/Import.cshtml")]
    public class Pages_Import : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "D:\Projects\C#\TaskAspNetApp\TaskAspNetApp\Pages\Import.cshtml"
  
	ViewData["Title"] = "Import";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Import</h1>\r\n\r\n");
#nullable restore
#line 9 "D:\Projects\C#\TaskAspNetApp\TaskAspNetApp\Pages\Import.cshtml"
 using (Html.BeginForm("Import", "UploadFile", FormMethod.Post, new { enctype = "multipart/form-data" }))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("<input type=\"file\" name=\"file\" />\r\n\t\t\t\t<input type=\"submit\" value=\"OK\" />");
#nullable restore
#line 12 "D:\Projects\C#\TaskAspNetApp\TaskAspNetApp\Pages\Import.cshtml"
                                                  }

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TaskAspNetApp.Pages.ImportModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<TaskAspNetApp.Pages.ImportModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<TaskAspNetApp.Pages.ImportModel>)PageContext?.ViewData;
        public TaskAspNetApp.Pages.ImportModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591