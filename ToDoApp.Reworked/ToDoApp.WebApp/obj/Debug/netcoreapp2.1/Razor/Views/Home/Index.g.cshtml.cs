#pragma checksum "C:\Users\Markovski\Desktop\ToDoApp.Reworked\ToDoApp.WebApp\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4ff49859e495cf6a895339c7ecd6d8781f147a22"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
#line 1 "C:\Users\Markovski\Desktop\ToDoApp.Reworked\ToDoApp.WebApp\Views\_ViewImports.cshtml"
using ToDoApp.WebApp;

#line default
#line hidden
#line 2 "C:\Users\Markovski\Desktop\ToDoApp.Reworked\ToDoApp.WebApp\Views\_ViewImports.cshtml"
using ToDoApp.WebApp.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4ff49859e495cf6a895339c7ecd6d8781f147a22", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bda2ee4e533780168272f23c820a26e3e00163e6", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<UserStatisticViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(31, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Markovski\Desktop\ToDoApp.Reworked\ToDoApp.WebApp\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "User Statistic";

#line default
#line hidden
            BeginContext(83, 26, true);
            WriteLiteral("<div>\r\n    <p>First name: ");
            EndContext();
            BeginContext(110, 15, false);
#line 7 "C:\Users\Markovski\Desktop\ToDoApp.Reworked\ToDoApp.WebApp\Views\Home\Index.cshtml"
              Write(Model.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(125, 24, true);
            WriteLiteral("</p>\r\n    <p>Last name: ");
            EndContext();
            BeginContext(150, 14, false);
#line 8 "C:\Users\Markovski\Desktop\ToDoApp.Reworked\ToDoApp.WebApp\Views\Home\Index.cshtml"
             Write(Model.LastName);

#line default
#line hidden
            EndContext();
            BeginContext(164, 18, true);
            WriteLiteral("</p>\r\n    <p>Age: ");
            EndContext();
            BeginContext(183, 9, false);
#line 9 "C:\Users\Markovski\Desktop\ToDoApp.Reworked\ToDoApp.WebApp\Views\Home\Index.cshtml"
       Write(Model.Age);

#line default
#line hidden
            EndContext();
            BeginContext(192, 14, true);
            WriteLiteral("</p>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<UserStatisticViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591