#pragma checksum "C:\Users\Fernando\Documents\Visual Studio 2017\Projects\Icatu.EmployeeManagerAPI\Icatu.EmployeeManagerAPI\Views\Shared\Livro.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9a537b1d80fe9ad13eece8e178b62ee307156074"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Livro), @"mvc.1.0.view", @"/Views/Shared/Livro.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/Livro.cshtml", typeof(AspNetCore.Views_Shared_Livro))]
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
#line 1 "C:\Users\Fernando\Documents\Visual Studio 2017\Projects\Icatu.EmployeeManagerAPI\Icatu.EmployeeManagerAPI\Views\_ViewImports.cshtml"
using Icatu.ListaLeitura.Modelos;

#line default
#line hidden
#line 2 "C:\Users\Fernando\Documents\Visual Studio 2017\Projects\Icatu.EmployeeManagerAPI\Icatu.EmployeeManagerAPI\Views\_ViewImports.cshtml"
using Icatu.ListaLeitura.Seguranca;

#line default
#line hidden
#line 3 "C:\Users\Fernando\Documents\Visual Studio 2017\Projects\Icatu.EmployeeManagerAPI\Icatu.EmployeeManagerAPI\Views\_ViewImports.cshtml"
using Icatu.ListaLeitura.WebApp.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9a537b1d80fe9ad13eece8e178b62ee307156074", @"/Views/Shared/Livro.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"60cfa11e461263ae242bff80590697ee74f84a14", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Livro : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<FuncApi>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Detalhes", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Funcionario", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(16, 55, true);
            WriteLiteral("\r\n<li class=\"list-group-item my-3 mx-5 border-0\">\r\n    ");
            EndContext();
            BeginContext(71, 207, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4f6be8ceb3ae49af8f147329eefb5770", async() => {
                BeginContext(150, 38, true);
                WriteLiteral("\r\n        <img class=\"livro img-fluid\"");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 188, "\"", 228, 2);
                WriteAttributeValue("", 194, "/Funcionario/ImagensCapa/", 194, 25, true);
#line 5 "C:\Users\Fernando\Documents\Visual Studio 2017\Projects\Icatu.EmployeeManagerAPI\Icatu.EmployeeManagerAPI\Views\Shared\Livro.cshtml"
WriteAttributeValue("", 219, Model.Id, 219, 9, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginWriteAttribute("alt", " alt=\"", 229, "\"", 246, 1);
#line 5 "C:\Users\Fernando\Documents\Visual Studio 2017\Projects\Icatu.EmployeeManagerAPI\Icatu.EmployeeManagerAPI\Views\Shared\Livro.cshtml"
WriteAttributeValue("", 235, Model.Nome, 235, 11, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(247, 10, true);
                WriteLiteral(" data-id=\"");
                EndContext();
                BeginContext(258, 8, false);
#line 5 "C:\Users\Fernando\Documents\Visual Studio 2017\Projects\Icatu.EmployeeManagerAPI\Icatu.EmployeeManagerAPI\Views\Shared\Livro.cshtml"
                                                                                                    Write(Model.Id);

#line default
#line hidden
                EndContext();
                BeginContext(266, 8, true);
                WriteLiteral("\">\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 4 "C:\Users\Fernando\Documents\Visual Studio 2017\Projects\Icatu.EmployeeManagerAPI\Icatu.EmployeeManagerAPI\Views\Shared\Livro.cshtml"
                                                            WriteLiteral(Model.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(278, 7, true);
            WriteLiteral("\r\n</li>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FuncApi> Html { get; private set; }
    }
}
#pragma warning restore 1591
