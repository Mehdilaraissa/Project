#pragma checksum "C:\Users\Ultrapc\Desktop\Workspace2\Projet\Ecommerce_MVC_Core\Views\ProductComments\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "382d15f1f2e21dd73500ce7678e15635c022bccd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ProductComments_Index), @"mvc.1.0.view", @"/Views/ProductComments/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/ProductComments/Index.cshtml", typeof(AspNetCore.Views_ProductComments_Index))]
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
#line 1 "C:\Users\Ultrapc\Desktop\Workspace2\Projet\Ecommerce_MVC_Core\Views\_ViewImports.cshtml"
using Ecommerce_MVC_Core;

#line default
#line hidden
#line 2 "C:\Users\Ultrapc\Desktop\Workspace2\Projet\Ecommerce_MVC_Core\Views\_ViewImports.cshtml"
using Ecommerce_MVC_Core.Models;

#line default
#line hidden
#line 4 "C:\Users\Ultrapc\Desktop\Workspace2\Projet\Ecommerce_MVC_Core\Views\_ViewImports.cshtml"
using System.Collections;

#line default
#line hidden
#line 5 "C:\Users\Ultrapc\Desktop\Workspace2\Projet\Ecommerce_MVC_Core\Views\_ViewImports.cshtml"
using Ecommerce_MVC_Core.BootstrapModal;

#line default
#line hidden
#line 6 "C:\Users\Ultrapc\Desktop\Workspace2\Projet\Ecommerce_MVC_Core\Views\_ViewImports.cshtml"
using Ecommerce_MVC_Core.Code;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"382d15f1f2e21dd73500ce7678e15635c022bccd", @"/Views/ProductComments/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"71cfa9c3ae2f1e0493d4ca25e3a3394ef37b5862", @"/Views/_ViewImports.cshtml")]
    public class Views_ProductComments_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Ecommerce_MVC_Core.ViewModel.ProductCommentsListViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-inline"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("deleteUserModal"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-toggle", new global::Microsoft.AspNetCore.Html.HtmlString("modal"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DeleteComment", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-target", new global::Microsoft.AspNetCore.Html.HtmlString("#modal-popUP"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\Ultrapc\Desktop\Workspace2\Projet\Ecommerce_MVC_Core\Views\ProductComments\Index.cshtml"
  
    ViewData["Title"] = "Comments";

#line default
#line hidden
            BeginContext(119, 63, true);
            WriteLiteral("\n<div class=\"col-md-2\">\n    \n</div>\n<div class=\"col-md-3\">\n    ");
            EndContext();
            BeginContext(182, 379, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c678e1af511b40f0bad6490945aa7054", async() => {
                BeginContext(241, 124, true);
                WriteLiteral("\n        <div class=\"form-horizontal\">\n            <div class=\"form-group\">\n                <input type=\"text\" name=\"search\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 365, "\"", 399, 1);
#line 13 "C:\Users\Ultrapc\Desktop\Workspace2\Projet\Ecommerce_MVC_Core\Views\ProductComments\Index.cshtml"
WriteAttributeValue("", 373, Html.ViewBag.SearchString, 373, 26, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(400, 154, true);
                WriteLiteral(" class=\"form-control\" />\n                <input type=\"submit\" value=\"Search\" class=\"btn btn-default pull-right\" />\n\n            </div>\n        </div>\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(561, 43, true);
            WriteLiteral("\n</div>\n<div class=\"col-md-7\"></div>\n<hr/>\n");
            EndContext();
#line 22 "C:\Users\Ultrapc\Desktop\Workspace2\Projet\Ecommerce_MVC_Core\Views\ProductComments\Index.cshtml"
  
    if (Model.ToList().Count <= 0)
    {

#line default
#line hidden
            BeginContext(648, 38, true);
            WriteLiteral("        <h1>No one commented yet</h1>\n");
            EndContext();
#line 26 "C:\Users\Ultrapc\Desktop\Workspace2\Projet\Ecommerce_MVC_Core\Views\ProductComments\Index.cshtml"
    }
    else
    {

#line default
#line hidden
            BeginContext(707, 355, true);
            WriteLiteral(@"        <table class=""table table-responsive table-hover"">
            <thead>
            <tr>
                <th>#</th>
                <th>Product Name</th>
                <th>User</th>
                <th>Comment</th>
                <th>Reaction Type</th>
                <th>Action</th>
            </tr>
            </thead>

            <tbody>
");
            EndContext();
#line 42 "C:\Users\Ultrapc\Desktop\Workspace2\Projet\Ecommerce_MVC_Core\Views\ProductComments\Index.cshtml"
              
                int count = 1;
                foreach (var item in Model)
                {

#line default
#line hidden
            BeginContext(1170, 45, true);
            WriteLiteral("                <tr>\n                    <td>");
            EndContext();
            BeginContext(1216, 5, false);
#line 47 "C:\Users\Ultrapc\Desktop\Workspace2\Projet\Ecommerce_MVC_Core\Views\ProductComments\Index.cshtml"
                   Write(count);

#line default
#line hidden
            EndContext();
            BeginContext(1221, 55, true);
            WriteLiteral("</td>\n                    <td>\n                        ");
            EndContext();
            BeginContext(1277, 16, false);
#line 49 "C:\Users\Ultrapc\Desktop\Workspace2\Projet\Ecommerce_MVC_Core\Views\ProductComments\Index.cshtml"
                   Write(item.ProductName);

#line default
#line hidden
            EndContext();
            BeginContext(1293, 51, true);
            WriteLiteral("\n                    </td>\n                    <td>");
            EndContext();
            BeginContext(1345, 13, false);
#line 51 "C:\Users\Ultrapc\Desktop\Workspace2\Projet\Ecommerce_MVC_Core\Views\ProductComments\Index.cshtml"
                   Write(item.UserName);

#line default
#line hidden
            EndContext();
            BeginContext(1358, 30, true);
            WriteLiteral("</td>\n                    <td>");
            EndContext();
            BeginContext(1389, 12, false);
#line 52 "C:\Users\Ultrapc\Desktop\Workspace2\Projet\Ecommerce_MVC_Core\Views\ProductComments\Index.cshtml"
                   Write(item.Comment);

#line default
#line hidden
            EndContext();
            BeginContext(1401, 30, true);
            WriteLiteral("</td>\n                    <td>");
            EndContext();
            BeginContext(1432, 17, false);
#line 53 "C:\Users\Ultrapc\Desktop\Workspace2\Projet\Ecommerce_MVC_Core\Views\ProductComments\Index.cshtml"
                   Write(item.UserReaction);

#line default
#line hidden
            EndContext();
            BeginContext(1449, 56, true);
            WriteLiteral("</td>\n                    <td>\n\n                        ");
            EndContext();
            BeginContext(1505, 252, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7ca4bbae571e415e9378be3a732ea6be", async() => {
                BeginContext(1650, 103, true);
                WriteLiteral("\n                            <i class=\"glyphicon glyphicon-trash\"></i>  Delete\n                        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 56 "C:\Users\Ultrapc\Desktop\Workspace2\Projet\Ecommerce_MVC_Core\Views\ProductComments\Index.cshtml"
                                                                                                 WriteLiteral(item.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1757, 49, true);
            WriteLiteral("\n                    </td>\n                </tr>\n");
            EndContext();
#line 61 "C:\Users\Ultrapc\Desktop\Workspace2\Projet\Ecommerce_MVC_Core\Views\ProductComments\Index.cshtml"
                    count++;
                }
            

#line default
#line hidden
            BeginContext(1867, 38, true);
            WriteLiteral("            </tbody>\n        </table>\n");
            EndContext();
#line 66 "C:\Users\Ultrapc\Desktop\Workspace2\Projet\Ecommerce_MVC_Core\Views\ProductComments\Index.cshtml"
    }

#line default
#line hidden
            BeginContext(1914, 127, false);
#line 68 "C:\Users\Ultrapc\Desktop\Workspace2\Projet\Ecommerce_MVC_Core\Views\ProductComments\Index.cshtml"
Write(Html.Partial("_Modal", new BootstrapModel { ID = "modal-popUP", AreaLabeledId = "modal-popUP-label", Size = ModalSize.Medium }));

#line default
#line hidden
            EndContext();
            BeginContext(2041, 3, true);
            WriteLiteral("\n\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Ecommerce_MVC_Core.ViewModel.ProductCommentsListViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
