#pragma checksum "C:\Users\ricky\Desktop\LamborghiniAuto\LamborghiniAuto\Views\Home\PersMag.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fa3b2dd9e3ad77b5d7af27c116977c18480d80a9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_PersMag), @"mvc.1.0.view", @"/Views/Home/PersMag.cshtml")]
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
#nullable restore
#line 1 "C:\Users\ricky\Desktop\LamborghiniAuto\LamborghiniAuto\Views\_ViewImports.cshtml"
using LamborghiniAuto;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ricky\Desktop\LamborghiniAuto\LamborghiniAuto\Views\_ViewImports.cshtml"
using LamborghiniAuto.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fa3b2dd9e3ad77b5d7af27c116977c18480d80a9", @"/Views/Home/PersMag.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d1bb190a5af3f140a86183200bbed1b0a1a03701", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_PersMag : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Tuple<List<LamborghiniAuto.Models.Cliente>, List<LamborghiniAuto.Models.Auto>, List<LamborghiniAuto.Models.Dipendente>>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Auto", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Ordina", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
            WriteLiteral("\n");
#nullable restore
#line 3 "C:\Users\ricky\Desktop\LamborghiniAuto\LamborghiniAuto\Views\Home\PersMag.cshtml"
   ViewData["Title"] = "Personale e Magazzino"; 

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<h1>Clienti</h1>\n\n<table class=\"table text-white\">\n    <tbody>\n");
#nullable restore
#line 9 "C:\Users\ricky\Desktop\LamborghiniAuto\LamborghiniAuto\Views\Home\PersMag.cshtml"
         foreach (var item in Model.Item1) // Clienti
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("<tr>\n    <td>\n        ");
#nullable restore
#line 13 "C:\Users\ricky\Desktop\LamborghiniAuto\LamborghiniAuto\Views\Home\PersMag.cshtml"
   Write(Html.DisplayFor(modelItem => item.nome));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </td>\n    <td>\n        ");
#nullable restore
#line 16 "C:\Users\ricky\Desktop\LamborghiniAuto\LamborghiniAuto\Views\Home\PersMag.cshtml"
   Write(Html.DisplayFor(modelItem => item.cognome));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </td>\n    <td>\n        ");
#nullable restore
#line 19 "C:\Users\ricky\Desktop\LamborghiniAuto\LamborghiniAuto\Views\Home\PersMag.cshtml"
   Write(Html.DisplayFor(modelItem => item.codFisc));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </td>\n    <td>\n");
#nullable restore
#line 22 "C:\Users\ricky\Desktop\LamborghiniAuto\LamborghiniAuto\Views\Home\PersMag.cshtml"
           string data = item.dataNascita.ToShortDateString(); 

#line default
#line hidden
#nullable disable
            WriteLiteral("        ");
#nullable restore
#line 23 "C:\Users\ricky\Desktop\LamborghiniAuto\LamborghiniAuto\Views\Home\PersMag.cshtml"
   Write(Html.DisplayFor(modelItem => data));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </td>\n</tr>\n");
#nullable restore
#line 26 "C:\Users\ricky\Desktop\LamborghiniAuto\LamborghiniAuto\Views\Home\PersMag.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\n</table>\n\n\n\n\n<h1>Dipendenti</h1>\n\n<table class=\"table text-white\">\n    <tbody>\n");
#nullable restore
#line 37 "C:\Users\ricky\Desktop\LamborghiniAuto\LamborghiniAuto\Views\Home\PersMag.cshtml"
        foreach (var item in Model.Item3) // DIpendenti
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <tr>\n        <td>\n            ");
#nullable restore
#line 41 "C:\Users\ricky\Desktop\LamborghiniAuto\LamborghiniAuto\Views\Home\PersMag.cshtml"
       Write(Html.DisplayFor(modelItem => item.nome));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </td>\n        <td>\n            ");
#nullable restore
#line 44 "C:\Users\ricky\Desktop\LamborghiniAuto\LamborghiniAuto\Views\Home\PersMag.cshtml"
       Write(Html.DisplayFor(modelItem => item.cognome));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </td>\n        <td>\n            ");
#nullable restore
#line 47 "C:\Users\ricky\Desktop\LamborghiniAuto\LamborghiniAuto\Views\Home\PersMag.cshtml"
       Write(Html.DisplayFor(modelItem => item.codFisc));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </td>\n        <td>\n            ");
#nullable restore
#line 50 "C:\Users\ricky\Desktop\LamborghiniAuto\LamborghiniAuto\Views\Home\PersMag.cshtml"
       Write(Html.DisplayFor(modelItem => item.stipendio));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </td>\n    </tr>\n");
#nullable restore
#line 53 "C:\Users\ricky\Desktop\LamborghiniAuto\LamborghiniAuto\Views\Home\PersMag.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\n</table>\n\n<h1>Auto</h1>\n\n<table class=\"table text-white\">\n    <tbody>\n");
#nullable restore
#line 61 "C:\Users\ricky\Desktop\LamborghiniAuto\LamborghiniAuto\Views\Home\PersMag.cshtml"
    foreach (var item in Model.Item2) // Auto
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <tr>\n        <td>\n            ");
#nullable restore
#line 65 "C:\Users\ricky\Desktop\LamborghiniAuto\LamborghiniAuto\Views\Home\PersMag.cshtml"
       Write(Html.DisplayFor(modelItem => item.modello));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </td>\n        <td>\n            ");
#nullable restore
#line 68 "C:\Users\ricky\Desktop\LamborghiniAuto\LamborghiniAuto\Views\Home\PersMag.cshtml"
       Write(Html.DisplayFor(modelItem => item.pezziDisponibili));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </td>\n        <td>\n            ");
#nullable restore
#line 71 "C:\Users\ricky\Desktop\LamborghiniAuto\LamborghiniAuto\Views\Home\PersMag.cshtml"
       Write(Html.DisplayFor(modelItem => item.PezziVenduti));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </td>\n        <td>\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fa3b2dd9e3ad77b5d7af27c116977c18480d80a98972", async() => {
                WriteLiteral("Ordina");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 74 "C:\Users\ricky\Desktop\LamborghiniAuto\LamborghiniAuto\Views\Home\PersMag.cshtml"
                                                           WriteLiteral(item.id);

#line default
#line hidden
#nullable disable
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
            WriteLiteral("\n        </td>\n    </tr>\n");
#nullable restore
#line 77 "C:\Users\ricky\Desktop\LamborghiniAuto\LamborghiniAuto\Views\Home\PersMag.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Tuple<List<LamborghiniAuto.Models.Cliente>, List<LamborghiniAuto.Models.Auto>, List<LamborghiniAuto.Models.Dipendente>>> Html { get; private set; }
    }
}
#pragma warning restore 1591
