#pragma checksum "C:\Users\Markovski\Desktop\ToDoApp\ToDoApp\Views\Task\InProgress.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8015d788922a3a210c94504dfc6986eb9bd43bdb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Task_InProgress), @"mvc.1.0.view", @"/Views/Task/InProgress.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Task/InProgress.cshtml", typeof(AspNetCore.Views_Task_InProgress))]
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
#line 2 "C:\Users\Markovski\Desktop\ToDoApp\ToDoApp\Views\_ViewImports.cshtml"
using ToDoApp.Models.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8015d788922a3a210c94504dfc6986eb9bd43bdb", @"/Views/Task/InProgress.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a3782f3622f759dc44fb7a6ca5f5abc5c26ce12a", @"/Views/_ViewImports.cshtml")]
    public class Views_Task_InProgress : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<InProgressTasksViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\Markovski\Desktop\ToDoApp\ToDoApp\Views\Task\InProgress.cshtml"
  
    ViewBag.Title = "InProgress Tasks";

#line default
#line hidden
            BeginContext(81, 22, true);
            WriteLiteral("\r\n<ul>\r\n    <li>Task: ");
            EndContext();
            BeginContext(104, 16, false);
#line 7 "C:\Users\Markovski\Desktop\ToDoApp\ToDoApp\Views\Task\InProgress.cshtml"
         Write(Model.InProgress);

#line default
#line hidden
            EndContext();
            BeginContext(120, 24, true);
            WriteLiteral("</li>\r\n</ul>\r\n\r\n<button>");
            EndContext();
            BeginContext(145, 46, false);
#line 10 "C:\Users\Markovski\Desktop\ToDoApp\ToDoApp\Views\Task\InProgress.cshtml"
   Write(Html.ActionLink("Add Task", "AddTask", "Task"));

#line default
#line hidden
            EndContext();
            BeginContext(191, 11, true);
            WriteLiteral("</button>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<InProgressTasksViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591