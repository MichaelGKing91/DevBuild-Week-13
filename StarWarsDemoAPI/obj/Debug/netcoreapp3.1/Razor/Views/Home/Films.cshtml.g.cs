#pragma checksum "C:\Users\mking10\dev\Week 13\StarWarsDemoAPI\Views\Home\Films.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0a8dc155f75239d61ec6ba4ae133bc977df8ef84"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Films), @"mvc.1.0.view", @"/Views/Home/Films.cshtml")]
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
#line 1 "C:\Users\mking10\dev\Week 13\StarWarsDemoAPI\Views\_ViewImports.cshtml"
using StarWarsDemoAPI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\mking10\dev\Week 13\StarWarsDemoAPI\Views\_ViewImports.cshtml"
using StarWarsDemoAPI.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0a8dc155f75239d61ec6ba4ae133bc977df8ef84", @"/Views/Home/Films.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7aa2d8384f73cae70f69b7a821f6cb166cc46035", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Films : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Films>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\mking10\dev\Week 13\StarWarsDemoAPI\Views\Home\Films.cshtml"
  
    ViewData["Title"] = "Films";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>");
#nullable restore
#line 6 "C:\Users\mking10\dev\Week 13\StarWarsDemoAPI\Views\Home\Films.cshtml"
Write(Model.title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\nDirector: ");
#nullable restore
#line 7 "C:\Users\mking10\dev\Week 13\StarWarsDemoAPI\Views\Home\Films.cshtml"
     Write(Model.director);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br/>\r\nCharacters:<br/>\r\n");
#nullable restore
#line 9 "C:\Users\mking10\dev\Week 13\StarWarsDemoAPI\Views\Home\Films.cshtml"
 foreach (string character in Model.characters)
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\mking10\dev\Week 13\StarWarsDemoAPI\Views\Home\Films.cshtml"
Write(character);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br/>\r\n");
#nullable restore
#line 12 "C:\Users\mking10\dev\Week 13\StarWarsDemoAPI\Views\Home\Films.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Films> Html { get; private set; }
    }
}
#pragma warning restore 1591
