#pragma checksum "C:\Github\avans-prg6\Architecture\Architecture.Starter\Architecture.ASP\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "90a118b651af836c30b22ff62c91c56a11a278f2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Github\avans-prg6\Architecture\Architecture.Starter\Architecture.ASP\Views\_ViewImports.cshtml"
using Architecture.ASP;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Github\avans-prg6\Architecture\Architecture.Starter\Architecture.ASP\Views\_ViewImports.cshtml"
using Architecture.ASP.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"90a118b651af836c30b22ff62c91c56a11a278f2", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e8cdd859b5979d5ed3042d16ad9ed09026ac6007", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Architecture.ASP.Models.FormViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<h2>Beschikbaarheid formulier</h2>\r\n\r\n<p>Hier kun je beschikbaarheid en vakantiedagen aangeven.</p>\r\n\r\n");
#nullable restore
#line 7 "C:\Github\avans-prg6\Architecture\Architecture.Starter\Architecture.ASP\Views\Home\Index.cshtml"
Write(Html.ValidationSummary());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 9 "C:\Github\avans-prg6\Architecture\Architecture.Starter\Architecture.ASP\Views\Home\Index.cshtml"
 using (Html.BeginForm("PostForm", "Home", FormMethod.Post))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"form-group\">\r\n\r\n        ");
#nullable restore
#line 13 "C:\Github\avans-prg6\Architecture\Architecture.Starter\Architecture.ASP\Views\Home\Index.cshtml"
   Write(Html.LabelFor(m => m.Omschrijving));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 14 "C:\Github\avans-prg6\Architecture\Architecture.Starter\Architecture.ASP\Views\Home\Index.cshtml"
   Write(Html.EditorFor(m => m.Omschrijving));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n    </div>\r\n    <div class=\"form-group\">\r\n\r\n        ");
#nullable restore
#line 19 "C:\Github\avans-prg6\Architecture\Architecture.Starter\Architecture.ASP\Views\Home\Index.cshtml"
   Write(Html.LabelFor(m => m.IsHoliday));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 20 "C:\Github\avans-prg6\Architecture\Architecture.Starter\Architecture.ASP\Views\Home\Index.cshtml"
   Write(Html.EditorFor(m => m.IsHoliday));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n    <div class=\"form-group\">\r\n        ");
#nullable restore
#line 23 "C:\Github\avans-prg6\Architecture\Architecture.Starter\Architecture.ASP\Views\Home\Index.cshtml"
   Write(Html.LabelFor(m => m.Start));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 24 "C:\Github\avans-prg6\Architecture\Architecture.Starter\Architecture.ASP\Views\Home\Index.cshtml"
   Write(Html.EditorFor(m => m.Start));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n    </div>\r\n    <div class=\"form-group\">\r\n        ");
#nullable restore
#line 28 "C:\Github\avans-prg6\Architecture\Architecture.Starter\Architecture.ASP\Views\Home\Index.cshtml"
   Write(Html.LabelFor(m => m.Einde));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 29 "C:\Github\avans-prg6\Architecture\Architecture.Starter\Architecture.ASP\Views\Home\Index.cshtml"
   Write(Html.EditorFor(m => m.Einde));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n    <div class=\"form-group\">\r\n        ");
#nullable restore
#line 32 "C:\Github\avans-prg6\Architecture\Architecture.Starter\Architecture.ASP\Views\Home\Index.cshtml"
   Write(Html.LabelFor(m => m.IsRepeat));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 33 "C:\Github\avans-prg6\Architecture\Architecture.Starter\Architecture.ASP\Views\Home\Index.cshtml"
   Write(Html.EditorFor(m => m.IsRepeat));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n");
            WriteLiteral("    <div class=\"form-group\">\r\n        ");
#nullable restore
#line 37 "C:\Github\avans-prg6\Architecture\Architecture.Starter\Architecture.ASP\Views\Home\Index.cshtml"
   Write(Html.LabelFor(m => m.AantalKeer));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 38 "C:\Github\avans-prg6\Architecture\Architecture.Starter\Architecture.ASP\Views\Home\Index.cshtml"
   Write(Html.EditorFor(m => m.AantalKeer));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n");
            WriteLiteral("    <input type=\"submit\" value=\"Submit\" class=\"btn btn-primary\" />\r\n");
#nullable restore
#line 42 "C:\Github\avans-prg6\Architecture\Architecture.Starter\Architecture.ASP\Views\Home\Index.cshtml"

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Architecture.ASP.Models.FormViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
