#pragma checksum "C:\Users\Kaue\Source\Repos\gabriellicorrea\listaTelefonica\Views\Contatos\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "192403f60ec1f568a6ec4c7cad197f622987a0ca"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Contatos_Details), @"mvc.1.0.view", @"/Views/Contatos/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Contatos/Details.cshtml", typeof(AspNetCore.Views_Contatos_Details))]
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
#line 1 "C:\Users\Kaue\Source\Repos\gabriellicorrea\listaTelefonica\Views\_ViewImports.cshtml"
using ListaTelefonica;

#line default
#line hidden
#line 2 "C:\Users\Kaue\Source\Repos\gabriellicorrea\listaTelefonica\Views\_ViewImports.cshtml"
using ListaTelefonica.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"192403f60ec1f568a6ec4c7cad197f622987a0ca", @"/Views/Contatos/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f561c3afc328ad2d97e2e413801942494729848b", @"/Views/_ViewImports.cshtml")]
    public class Views_Contatos_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ListaTelefonica.Models.Entidades.Contato>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(49, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Kaue\Source\Repos\gabriellicorrea\listaTelefonica\Views\Contatos\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(94, 100, true);
            WriteLiteral("\r\n<h2>Detalhes</h2>\r\n\r\n<div>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(195, 38, false);
#line 13 "C:\Users\Kaue\Source\Repos\gabriellicorrea\listaTelefonica\Views\Contatos\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Id));

#line default
#line hidden
            EndContext();
            BeginContext(233, 57, true);
            WriteLiteral("\r\n            \r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(291, 34, false);
#line 17 "C:\Users\Kaue\Source\Repos\gabriellicorrea\listaTelefonica\Views\Contatos\Details.cshtml"
       Write(Html.DisplayFor(model => model.Id));

#line default
#line hidden
            EndContext();
            BeginContext(325, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(369, 40, false);
#line 20 "C:\Users\Kaue\Source\Repos\gabriellicorrea\listaTelefonica\Views\Contatos\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Nome));

#line default
#line hidden
            EndContext();
            BeginContext(409, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(453, 36, false);
#line 23 "C:\Users\Kaue\Source\Repos\gabriellicorrea\listaTelefonica\Views\Contatos\Details.cshtml"
       Write(Html.DisplayFor(model => model.Nome));

#line default
#line hidden
            EndContext();
            BeginContext(489, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(533, 41, false);
#line 26 "C:\Users\Kaue\Source\Repos\gabriellicorrea\listaTelefonica\Views\Contatos\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Email));

#line default
#line hidden
            EndContext();
            BeginContext(574, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(618, 37, false);
#line 29 "C:\Users\Kaue\Source\Repos\gabriellicorrea\listaTelefonica\Views\Contatos\Details.cshtml"
       Write(Html.DisplayFor(model => model.Email));

#line default
#line hidden
            EndContext();
            BeginContext(655, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(699, 39, false);
#line 32 "C:\Users\Kaue\Source\Repos\gabriellicorrea\listaTelefonica\Views\Contatos\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.CPF));

#line default
#line hidden
            EndContext();
            BeginContext(738, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(782, 35, false);
#line 35 "C:\Users\Kaue\Source\Repos\gabriellicorrea\listaTelefonica\Views\Contatos\Details.cshtml"
       Write(Html.DisplayFor(model => model.CPF));

#line default
#line hidden
            EndContext();
            BeginContext(817, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(861, 49, false);
#line 38 "C:\Users\Kaue\Source\Repos\gabriellicorrea\listaTelefonica\Views\Contatos\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.ListaTelefone));

#line default
#line hidden
            EndContext();
            BeginContext(910, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(954, 45, false);
#line 41 "C:\Users\Kaue\Source\Repos\gabriellicorrea\listaTelefonica\Views\Contatos\Details.cshtml"
       Write(Html.DisplayFor(model => model.ListaTelefone));

#line default
#line hidden
            EndContext();
            BeginContext(999, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1043, 49, false);
#line 44 "C:\Users\Kaue\Source\Repos\gabriellicorrea\listaTelefonica\Views\Contatos\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.ListaEndereco));

#line default
#line hidden
            EndContext();
            BeginContext(1092, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1136, 45, false);
#line 47 "C:\Users\Kaue\Source\Repos\gabriellicorrea\listaTelefonica\Views\Contatos\Details.cshtml"
       Write(Html.DisplayFor(model => model.ListaEndereco));

#line default
#line hidden
            EndContext();
            BeginContext(1181, 47, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(1229, 68, false);
#line 52 "C:\Users\Kaue\Source\Repos\gabriellicorrea\listaTelefonica\Views\Contatos\Details.cshtml"
Write(Html.ActionLink("Edit", "Edit", new { /* id = Model.PrimaryKey */ }));

#line default
#line hidden
            EndContext();
            BeginContext(1297, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(1305, 45, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c3aed87448cf436b883f7e13819238f8", async() => {
                BeginContext(1327, 19, true);
                WriteLiteral("Voltar para a lista");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1350, 10, true);
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ListaTelefonica.Models.Entidades.Contato> Html { get; private set; }
    }
}
#pragma warning restore 1591
