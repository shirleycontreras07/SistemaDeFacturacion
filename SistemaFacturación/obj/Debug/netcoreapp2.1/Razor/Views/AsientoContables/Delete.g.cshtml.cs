#pragma checksum "C:\Users\Shirley Contreras\Desktop\Cuatrimestre Septiembre-Diciembre 2020\Integración con tecnología Open Source\SistemaFacturación\SistemaFacturación\Views\AsientoContables\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8549cc54d4cd56e718f7d942da01565be8db5c18"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_AsientoContables_Delete), @"mvc.1.0.view", @"/Views/AsientoContables/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/AsientoContables/Delete.cshtml", typeof(AspNetCore.Views_AsientoContables_Delete))]
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
#line 1 "C:\Users\Shirley Contreras\Desktop\Cuatrimestre Septiembre-Diciembre 2020\Integración con tecnología Open Source\SistemaFacturación\SistemaFacturación\Views\_ViewImports.cshtml"
using SistemaFacturación;

#line default
#line hidden
#line 2 "C:\Users\Shirley Contreras\Desktop\Cuatrimestre Septiembre-Diciembre 2020\Integración con tecnología Open Source\SistemaFacturación\SistemaFacturación\Views\_ViewImports.cshtml"
using SistemaFacturación.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8549cc54d4cd56e718f7d942da01565be8db5c18", @"/Views/AsientoContables/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9c01e39e84a885c61f1dc0b2993b6360a54da49f", @"/Views/_ViewImports.cshtml")]
    public class Views_AsientoContables_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SistemaFacturación.Models.FacturacionModels.AsientoContable>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(68, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Shirley Contreras\Desktop\Cuatrimestre Septiembre-Diciembre 2020\Integración con tecnología Open Source\SistemaFacturación\SistemaFacturación\Views\AsientoContables\Delete.cshtml"
  
    ViewData["Title"] = "Delete";

#line default
#line hidden
            BeginContext(112, 176, true);
            WriteLiteral("\r\n<h2>Delete</h2>\r\n\r\n<h3>Are you sure you want to delete this?</h3>\r\n<div>\r\n    <h4>AsientoContable</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(289, 47, false);
#line 15 "C:\Users\Shirley Contreras\Desktop\Cuatrimestre Septiembre-Diciembre 2020\Integración con tecnología Open Source\SistemaFacturación\SistemaFacturación\Views\AsientoContables\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Descripción));

#line default
#line hidden
            EndContext();
            BeginContext(336, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(380, 43, false);
#line 18 "C:\Users\Shirley Contreras\Desktop\Cuatrimestre Septiembre-Diciembre 2020\Integración con tecnología Open Source\SistemaFacturación\SistemaFacturación\Views\AsientoContables\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Descripción));

#line default
#line hidden
            EndContext();
            BeginContext(423, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(467, 42, false);
#line 21 "C:\Users\Shirley Contreras\Desktop\Cuatrimestre Septiembre-Diciembre 2020\Integración con tecnología Open Source\SistemaFacturación\SistemaFacturación\Views\AsientoContables\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Cuenta));

#line default
#line hidden
            EndContext();
            BeginContext(509, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(553, 38, false);
#line 24 "C:\Users\Shirley Contreras\Desktop\Cuatrimestre Septiembre-Diciembre 2020\Integración con tecnología Open Source\SistemaFacturación\SistemaFacturación\Views\AsientoContables\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Cuenta));

#line default
#line hidden
            EndContext();
            BeginContext(591, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(635, 41, false);
#line 27 "C:\Users\Shirley Contreras\Desktop\Cuatrimestre Septiembre-Diciembre 2020\Integración con tecnología Open Source\SistemaFacturación\SistemaFacturación\Views\AsientoContables\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Fecha));

#line default
#line hidden
            EndContext();
            BeginContext(676, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(720, 37, false);
#line 30 "C:\Users\Shirley Contreras\Desktop\Cuatrimestre Septiembre-Diciembre 2020\Integración con tecnología Open Source\SistemaFacturación\SistemaFacturación\Views\AsientoContables\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Fecha));

#line default
#line hidden
            EndContext();
            BeginContext(757, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(801, 48, false);
#line 33 "C:\Users\Shirley Contreras\Desktop\Cuatrimestre Septiembre-Diciembre 2020\Integración con tecnología Open Source\SistemaFacturación\SistemaFacturación\Views\AsientoContables\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.MontoAsiento));

#line default
#line hidden
            EndContext();
            BeginContext(849, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(893, 44, false);
#line 36 "C:\Users\Shirley Contreras\Desktop\Cuatrimestre Septiembre-Diciembre 2020\Integración con tecnología Open Source\SistemaFacturación\SistemaFacturación\Views\AsientoContables\Delete.cshtml"
       Write(Html.DisplayFor(model => model.MontoAsiento));

#line default
#line hidden
            EndContext();
            BeginContext(937, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(981, 42, false);
#line 39 "C:\Users\Shirley Contreras\Desktop\Cuatrimestre Septiembre-Diciembre 2020\Integración con tecnología Open Source\SistemaFacturación\SistemaFacturación\Views\AsientoContables\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Estado));

#line default
#line hidden
            EndContext();
            BeginContext(1023, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1067, 38, false);
#line 42 "C:\Users\Shirley Contreras\Desktop\Cuatrimestre Septiembre-Diciembre 2020\Integración con tecnología Open Source\SistemaFacturación\SistemaFacturación\Views\AsientoContables\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Estado));

#line default
#line hidden
            EndContext();
            BeginContext(1105, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1149, 43, false);
#line 45 "C:\Users\Shirley Contreras\Desktop\Cuatrimestre Septiembre-Diciembre 2020\Integración con tecnología Open Source\SistemaFacturación\SistemaFacturación\Views\AsientoContables\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Cliente));

#line default
#line hidden
            EndContext();
            BeginContext(1192, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1236, 54, false);
#line 48 "C:\Users\Shirley Contreras\Desktop\Cuatrimestre Septiembre-Diciembre 2020\Integración con tecnología Open Source\SistemaFacturación\SistemaFacturación\Views\AsientoContables\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Cliente.CuentaContable));

#line default
#line hidden
            EndContext();
            BeginContext(1290, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1334, 50, false);
#line 51 "C:\Users\Shirley Contreras\Desktop\Cuatrimestre Septiembre-Diciembre 2020\Integración con tecnología Open Source\SistemaFacturación\SistemaFacturación\Views\AsientoContables\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.TipoMovimiento));

#line default
#line hidden
            EndContext();
            BeginContext(1384, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1428, 63, false);
#line 54 "C:\Users\Shirley Contreras\Desktop\Cuatrimestre Septiembre-Diciembre 2020\Integración con tecnología Open Source\SistemaFacturación\SistemaFacturación\Views\AsientoContables\Delete.cshtml"
       Write(Html.DisplayFor(model => model.TipoMovimiento.IdTipoMovimiento));

#line default
#line hidden
            EndContext();
            BeginContext(1491, 38, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n    \r\n    ");
            EndContext();
            BeginContext(1529, 214, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "82be9f2894e54894a25c5c22ed04cb40", async() => {
                BeginContext(1555, 10, true);
                WriteLiteral("\r\n        ");
                EndContext();
                BeginContext(1565, 43, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "39df315d586646e8affb40a49eadb3ea", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 59 "C:\Users\Shirley Contreras\Desktop\Cuatrimestre Septiembre-Diciembre 2020\Integración con tecnología Open Source\SistemaFacturación\SistemaFacturación\Views\AsientoContables\Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.IdAsiento);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1608, 84, true);
                WriteLiteral("\r\n        <input type=\"submit\" value=\"Delete\" class=\"btn btn-default\" /> |\r\n        ");
                EndContext();
                BeginContext(1692, 38, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "892ba11344f84c359fa60e4185b79802", async() => {
                    BeginContext(1714, 12, true);
                    WriteLiteral("Back to List");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1730, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1743, 10, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SistemaFacturación.Models.FacturacionModels.AsientoContable> Html { get; private set; }
    }
}
#pragma warning restore 1591
