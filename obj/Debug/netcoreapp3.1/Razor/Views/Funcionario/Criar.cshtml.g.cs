#pragma checksum "C:\Users\Administrador\Desktop\ISTEC\2ANO_2SEMESTRE\TI III\ProjetoTI\ProjetoGestor\ProjetoGestor\Views\Funcionario\Criar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "932feae41d3879d1693ed89ed4bb08b381be9e4c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Funcionario_Criar), @"mvc.1.0.view", @"/Views/Funcionario/Criar.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"932feae41d3879d1693ed89ed4bb08b381be9e4c", @"/Views/Funcionario/Criar.cshtml")]
    public class Views_Funcionario_Criar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\Administrador\Desktop\ISTEC\2ANO_2SEMESTRE\TI III\ProjetoTI\ProjetoGestor\ProjetoGestor\Views\Funcionario\Criar.cshtml"
  
    ViewData["Title"] = "Criação de Funcionário";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<main id=""main"">

    <!-- ======= Contact Section ======= -->
    <section id=""contact"" class=""contact"">
        <div class=""container"">

            <div class=""section-title"">
                <span>Criar Funcionário</span>
                <h2>Criar Funcionário</h2>
            </div>

            <div class=""row"" data-aos=""fade-up"">
                <div class=""col-lg-12"">
                    <div class=""info-box mb-4"">
                        <i class='bx bxs-user-detail'></i>
                        <h3>Funcionário Atual</h3>
                    </div>
                </div>

            </div>

            <div class=""row"" data-aos=""fade-up"">

                <div class=""col-lg-12"">
                    <form method=""post"" action=""/Funcionario/Criar"">
                        <div class=""row"">
                            <div class=""col-md-6 form-group"">
                                <input type=""text"" name=""Nome"" class=""form-control"" placeholder=""Nome""");
            BeginWriteAttribute("value", " value=\"", 1108, "\"", 1116, 0);
            EndWriteAttribute();
            WriteLiteral(" required/>\r\n                            </div>\r\n                            <div class=\"col-md-6 form-group mt-3 mt-md-0\">\r\n                                <input type=\"text\" name=\"Nif\" class=\"form-control\" placeholder=\"Nif\"");
            BeginWriteAttribute("value", " value=\"", 1342, "\"", 1350, 0);
            EndWriteAttribute();
            WriteLiteral(@" required/>
                            </div>
                        </div>

                        <div class=""row mt-3"">
                            <div class=""col-md-6 form-group mt-3 mt-md-0"">
                                <input type=""text"" name=""Contacto"" class=""form-control"" placeholder=""Contacto""");
            BeginWriteAttribute("value", " value=\"", 1668, "\"", 1676, 0);
            EndWriteAttribute();
            WriteLiteral(" required/>\r\n                            </div>\r\n                            <div class=\"col-md-6 form-group mt-3 mt-md-0\">\r\n                                <input type=\"text\" name=\"NrFuncionario\" class=\"form-control\" placeholder=\"NrFuncionario\"");
            BeginWriteAttribute("value", " value=\"", 1922, "\"", 1930, 0);
            EndWriteAttribute();
            WriteLiteral(@" required/>
                            </div>
                        </div>
                        <br />
                        <div class=""text-center"">
                            <input type=""submit"" name=""enviar"" value=""Criar Funcionário"" style=""background: #576880; border: 0; padding: 10px 24px; color: #fff; transition: 0.7s;"" />
                        </div>
                    </form>

                </div>

            </div>

        </div>
    </section><!-- End Contact Section -->

</main><!-- End #main -->
");
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
