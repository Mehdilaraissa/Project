#pragma checksum "C:\Users\Ultrapc\Desktop\Workspace2\Projet\Ecommerce_MVC_Core\Views\Users\AccessDenied.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ad213032ceaefcc24588b3461f6a2056ba7b2b37"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Users_AccessDenied), @"mvc.1.0.view", @"/Views/Users/AccessDenied.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Users/AccessDenied.cshtml", typeof(AspNetCore.Views_Users_AccessDenied))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ad213032ceaefcc24588b3461f6a2056ba7b2b37", @"/Views/Users/AccessDenied.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"71cfa9c3ae2f1e0493d4ca25e3a3394ef37b5862", @"/Views/_ViewImports.cshtml")]
    public class Views_Users_AccessDenied : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 592, true);
            WriteLiteral(@"<div class=""row"">
    <div class=""col-md-3""></div>
    <div class=""col-md-6"">
        <div class=""top-buffer""></div>
        <div class=""panel panel-danger"">
            <div class=""panel-heading"">Access Denied</div>
            <div class=""panel-body"">
                <section>
                    <h1 class=""text-danger"">403 ! Access Denied</h1>
                    <br />
                    <a href=""javascript:void(0)"" onClick=""backAway()"" class=""btn btn-success"">Back</a>
                </section>
            </div>
        </div>
    </div>
    <div class=""col-md-3""></div>
</div>

");
            EndContext();
            DefineSection("scripts", async() => {
                BeginContext(614, 235, true);
                WriteLiteral("\n    <script>\n        function backAway() {\n            if (history.length === 1) {\n                window.location = \"http://localhost:50841/\"\n            } else {\n                history.back();\n            }\n        }\n    </script>\n");
                EndContext();
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591