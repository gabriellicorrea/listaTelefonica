#pragma checksum "C:\Users\Kaue\Source\Repos\gabriellicorrea\listaTelefonica\Views\Contatos\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8ce05234eb114dc15e792ec6e4f55db7704a03fd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Contatos_Index), @"mvc.1.0.view", @"/Views/Contatos/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Contatos/Index.cshtml", typeof(AspNetCore.Views_Contatos_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8ce05234eb114dc15e792ec6e4f55db7704a03fd", @"/Views/Contatos/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f561c3afc328ad2d97e2e413801942494729848b", @"/Views/_ViewImports.cshtml")]
    public class Views_Contatos_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ListaTelefonica.Models.Entidades.Contato>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(62, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Kaue\Source\Repos\gabriellicorrea\listaTelefonica\Views\Contatos\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(105, 133, true);
            WriteLiteral("\r\n<h2>Bem Vindo a nossa Lista Telefonica</h2>\r\n\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(239, 38, false);
#line 13 "C:\Users\Kaue\Source\Repos\gabriellicorrea\listaTelefonica\Views\Contatos\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Id));

#line default
#line hidden
            EndContext();
            BeginContext(277, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(333, 40, false);
#line 16 "C:\Users\Kaue\Source\Repos\gabriellicorrea\listaTelefonica\Views\Contatos\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Nome));

#line default
#line hidden
            EndContext();
            BeginContext(373, 68, true);
            WriteLiteral("\r\n            </th>\r\n           \r\n            <th>\r\n                ");
            EndContext();
            BeginContext(442, 41, false);
#line 20 "C:\Users\Kaue\Source\Repos\gabriellicorrea\listaTelefonica\Views\Contatos\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Email));

#line default
#line hidden
            EndContext();
            BeginContext(483, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(539, 39, false);
#line 23 "C:\Users\Kaue\Source\Repos\gabriellicorrea\listaTelefonica\Views\Contatos\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.CPF));

#line default
#line hidden
            EndContext();
            BeginContext(578, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(634, 49, false);
#line 26 "C:\Users\Kaue\Source\Repos\gabriellicorrea\listaTelefonica\Views\Contatos\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.ListaTelefone));

#line default
#line hidden
            EndContext();
            BeginContext(683, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(739, 49, false);
#line 29 "C:\Users\Kaue\Source\Repos\gabriellicorrea\listaTelefonica\Views\Contatos\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.ListaEndereco));

#line default
#line hidden
            EndContext();
            BeginContext(788, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 35 "C:\Users\Kaue\Source\Repos\gabriellicorrea\listaTelefonica\Views\Contatos\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
            BeginContext(906, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(955, 37, false);
#line 38 "C:\Users\Kaue\Source\Repos\gabriellicorrea\listaTelefonica\Views\Contatos\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Id));

#line default
#line hidden
            EndContext();
            BeginContext(992, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1048, 39, false);
#line 41 "C:\Users\Kaue\Source\Repos\gabriellicorrea\listaTelefonica\Views\Contatos\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Nome));

#line default
#line hidden
            EndContext();
            BeginContext(1087, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1143, 40, false);
#line 44 "C:\Users\Kaue\Source\Repos\gabriellicorrea\listaTelefonica\Views\Contatos\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Email));

#line default
#line hidden
            EndContext();
            BeginContext(1183, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1239, 38, false);
#line 47 "C:\Users\Kaue\Source\Repos\gabriellicorrea\listaTelefonica\Views\Contatos\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.CPF));

#line default
#line hidden
            EndContext();
            BeginContext(1277, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1333, 48, false);
#line 50 "C:\Users\Kaue\Source\Repos\gabriellicorrea\listaTelefonica\Views\Contatos\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.ListaTelefone));

#line default
#line hidden
            EndContext();
            BeginContext(1381, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1437, 48, false);
#line 53 "C:\Users\Kaue\Source\Repos\gabriellicorrea\listaTelefonica\Views\Contatos\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.ListaEndereco));

#line default
#line hidden
            EndContext();
            BeginContext(1485, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1541, 78, false);
#line 56 "C:\Users\Kaue\Source\Repos\gabriellicorrea\listaTelefonica\Views\Contatos\Index.cshtml"
           Write(Html.ActionLink("Edit", "Edit", new { id = item.Id /* id=item.PrimaryKey */ }));

#line default
#line hidden
            EndContext();
            BeginContext(1619, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(1640, 84, false);
#line 57 "C:\Users\Kaue\Source\Repos\gabriellicorrea\listaTelefonica\Views\Contatos\Index.cshtml"
           Write(Html.ActionLink("Details", "Details", new { id = item.Id /* id=item.PrimaryKey */ }));

#line default
#line hidden
            EndContext();
            BeginContext(1724, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(1745, 82, false);
#line 58 "C:\Users\Kaue\Source\Repos\gabriellicorrea\listaTelefonica\Views\Contatos\Index.cshtml"
           Write(Html.ActionLink("Delete", "Delete", new { id = item.Id /* id=item.PrimaryKey */ }));

#line default
#line hidden
            EndContext();
            BeginContext(1827, 36, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 61 "C:\Users\Kaue\Source\Repos\gabriellicorrea\listaTelefonica\Views\Contatos\Index.cshtml"
}

#line default
#line hidden
            BeginContext(1866, 35, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n<p>\r\n    ");
            EndContext();
            BeginContext(1901, 48, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9d062c9c3b6644ae80e03beb1b5c2aa5", async() => {
                BeginContext(1924, 21, true);
                WriteLiteral("Criar um novo contato");
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
            BeginContext(1949, 8, true);
            WriteLiteral("\r\n</p>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ListaTelefonica.Models.Entidades.Contato>> Html { get; private set; }
    }
}
#pragma warning restore 1591
