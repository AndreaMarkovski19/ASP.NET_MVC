#pragma checksum "C:\Users\Markovski\Desktop\ToDoApp\ToDoApp\Views\Home\NotDone.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "790e97a36aba770c43bdeb0023e50446add4e631"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_NotDone), @"mvc.1.0.view", @"/Views/Home/NotDone.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/NotDone.cshtml", typeof(AspNetCore.Views_Home_NotDone))]
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
#line 1 "C:\Users\Markovski\Desktop\ToDoApp\ToDoApp\Views\_ViewImports.cshtml"
using ToDoApp.Models.DomainModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"790e97a36aba770c43bdeb0023e50446add4e631", @"/Views/Home/NotDone.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0e31cd8c8846e761538465593140de488cc74234", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_NotDone : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<User>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\Markovski\Desktop\ToDoApp\ToDoApp\Views\Home\NotDone.cshtml"
  
    ViewData["Title"] = "Tasks not done";

#line default
#line hidden
            BeginContext(63, 9, true);
            WriteLiteral("\r\n<title>");
            EndContext();
            BeginContext(73, 17, false);
#line 6 "C:\Users\Markovski\Desktop\ToDoApp\ToDoApp\Views\Home\NotDone.cshtml"
  Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(90, 16, true);
            WriteLiteral("</title>\r\n\r\n<h1>");
            EndContext();
            BeginContext(107, 19, false);
#line 8 "C:\Users\Markovski\Desktop\ToDoApp\ToDoApp\Views\Home\NotDone.cshtml"
Write(ViewData["Message"]);

#line default
#line hidden
            EndContext();
            BeginContext(126, 9, true);
            WriteLiteral("</h1>\r\n\r\n");
            EndContext();
            BeginContext(198, 2, true);
            WriteLiteral("\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<User> Html { get; private set; }
    }
}
#pragma warning restore 1591
