#pragma checksum "C:\Users\Markovski\Desktop\ToDoApp.Reworked\ToDoApp.WebApp\Views\Task\Done.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f3b999f59549b2b44b462f1ebdb7fcdbbb0f87ce"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Task_Done), @"mvc.1.0.view", @"/Views/Task/Done.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Task/Done.cshtml", typeof(AspNetCore.Views_Task_Done))]
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
using ToDoApp.WebApp.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f3b999f59549b2b44b462f1ebdb7fcdbbb0f87ce", @"/Views/Task/Done.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0d2406df676a4c015ea7914ba561ce106837c61b", @"/Views/_ViewImports.cshtml")]
    public class Views_Task_Done : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DoneTasksViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\Markovski\Desktop\ToDoApp.Reworked\ToDoApp.WebApp\Views\Task\Done.cshtml"
  
    ViewBag.Title = "Tasks done";

#line default
#line hidden
            BeginContext(69, 300, true);
            WriteLiteral(@"
<h1>Tasks DONE are:</h1> <br />

<table border=""1"" width=""300"" height=""150"">
    <thead>
        <tr>
            <th>Title</th>
            <th>Description</th>
            <th>Priority</th>
            <th>Status</th>
            <th>Type</th>
        </tr>
    </thead>
    <tbody>
");
            EndContext();
#line 19 "C:\Users\Markovski\Desktop\ToDoApp.Reworked\ToDoApp.WebApp\Views\Task\Done.cshtml"
         foreach (var tasks in Model.Done)
        {

#line default
#line hidden
            BeginContext(424, 38, true);
            WriteLiteral("            <tr>\r\n                <td>");
            EndContext();
            BeginContext(463, 11, false);
#line 22 "C:\Users\Markovski\Desktop\ToDoApp.Reworked\ToDoApp.WebApp\Views\Task\Done.cshtml"
               Write(tasks.Title);

#line default
#line hidden
            EndContext();
            BeginContext(474, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(502, 17, false);
#line 23 "C:\Users\Markovski\Desktop\ToDoApp.Reworked\ToDoApp.WebApp\Views\Task\Done.cshtml"
               Write(tasks.Description);

#line default
#line hidden
            EndContext();
            BeginContext(519, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(547, 14, false);
#line 24 "C:\Users\Markovski\Desktop\ToDoApp.Reworked\ToDoApp.WebApp\Views\Task\Done.cshtml"
               Write(tasks.Priority);

#line default
#line hidden
            EndContext();
            BeginContext(561, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(589, 12, false);
#line 25 "C:\Users\Markovski\Desktop\ToDoApp.Reworked\ToDoApp.WebApp\Views\Task\Done.cshtml"
               Write(tasks.Status);

#line default
#line hidden
            EndContext();
            BeginContext(601, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(629, 10, false);
#line 26 "C:\Users\Markovski\Desktop\ToDoApp.Reworked\ToDoApp.WebApp\Views\Task\Done.cshtml"
               Write(tasks.Type);

#line default
#line hidden
            EndContext();
            BeginContext(639, 26, true);
            WriteLiteral("</td>\r\n            </tr>\r\n");
            EndContext();
#line 28 "C:\Users\Markovski\Desktop\ToDoApp.Reworked\ToDoApp.WebApp\Views\Task\Done.cshtml"
        }

#line default
#line hidden
            BeginContext(676, 41, true);
            WriteLiteral("    </tbody>\r\n</table> <br />\r\n\r\n<button>");
            EndContext();
            BeginContext(718, 46, false);
#line 32 "C:\Users\Markovski\Desktop\ToDoApp.Reworked\ToDoApp.WebApp\Views\Task\Done.cshtml"
   Write(Html.ActionLink("Add Task", "AddTask", "Task"));

#line default
#line hidden
            EndContext();
            BeginContext(764, 11, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DoneTasksViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591