#pragma checksum "C:\Users\Markovski\Desktop\ToDoApp\ToDoApp\Views\User\Statistics.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "75dd83bfb37f43b4322d06b2a1bfba78ebb30ca3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_Statistics), @"mvc.1.0.view", @"/Views/User/Statistics.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/User/Statistics.cshtml", typeof(AspNetCore.Views_User_Statistics))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"75dd83bfb37f43b4322d06b2a1bfba78ebb30ca3", @"/Views/User/Statistics.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0e31cd8c8846e761538465593140de488cc74234", @"/Views/_ViewImports.cshtml")]
    public class Views_User_Statistics : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<User>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\Markovski\Desktop\ToDoApp\ToDoApp\Views\User\Statistics.cshtml"
  
    ViewData["Title"] = "User - Stats";

#line default
#line hidden
            BeginContext(61, 9, true);
            WriteLiteral("\r\n<title>");
            EndContext();
            BeginContext(71, 17, false);
#line 6 "C:\Users\Markovski\Desktop\ToDoApp\ToDoApp\Views\User\Statistics.cshtml"
  Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(88, 16, true);
            WriteLiteral("</title>\r\n\r\n<h1>");
            EndContext();
            BeginContext(105, 19, false);
#line 8 "C:\Users\Markovski\Desktop\ToDoApp\ToDoApp\Views\User\Statistics.cshtml"
Write(ViewData["Message"]);

#line default
#line hidden
            EndContext();
            BeginContext(124, 29, true);
            WriteLiteral("</h1>\r\n\r\n<ul>\r\n    <li>Name: ");
            EndContext();
            BeginContext(154, 15, false);
#line 11 "C:\Users\Markovski\Desktop\ToDoApp\ToDoApp\Views\User\Statistics.cshtml"
         Write(Model.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(169, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(171, 14, false);
#line 11 "C:\Users\Markovski\Desktop\ToDoApp\ToDoApp\Views\User\Statistics.cshtml"
                          Write(Model.LastName);

#line default
#line hidden
            EndContext();
            BeginContext(185, 20, true);
            WriteLiteral("</li>\r\n    <li>Age: ");
            EndContext();
            BeginContext(206, 9, false);
#line 12 "C:\Users\Markovski\Desktop\ToDoApp\ToDoApp\Views\User\Statistics.cshtml"
        Write(Model.Age);

#line default
#line hidden
            EndContext();
            BeginContext(215, 34, true);
            WriteLiteral("</li>\r\n    <li>Average Free Time: ");
            EndContext();
            BeginContext(250, 21, false);
#line 13 "C:\Users\Markovski\Desktop\ToDoApp\ToDoApp\Views\User\Statistics.cshtml"
                      Write(Model.AverageFreeTime);

#line default
#line hidden
            EndContext();
            BeginContext(271, 14, true);
            WriteLiteral("</li>\r\n</ul>\r\n");
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
