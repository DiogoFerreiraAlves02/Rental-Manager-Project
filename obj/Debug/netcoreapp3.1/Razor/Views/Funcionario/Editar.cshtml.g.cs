#pragma checksum "C:\Users\Administrador\Desktop\ISTEC\2ANO_2SEMESTRE\TI III\ProjetoTI\ProjetoGestor\ProjetoGestor\Views\Funcionario\Editar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b2e13303143366a9ebdca4f59ee64f848dc07fb6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Funcionario_Editar), @"mvc.1.0.view", @"/Views/Funcionario/Editar.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b2e13303143366a9ebdca4f59ee64f848dc07fb6", @"/Views/Funcionario/Editar.cshtml")]
    public class Views_Funcionario_Editar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\Administrador\Desktop\ISTEC\2ANO_2SEMESTRE\TI III\ProjetoTI\ProjetoGestor\ProjetoGestor\Views\Funcionario\Editar.cshtml"
  
    ViewData["Title"] = "Edição de Funcionário";
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
                <span>Editar Funcionário</span>
                <h2>Editar Funcionário</h2>
            </div>

            <div class=""row"" data-aos=""fade-up"">
                <div class=""col-lg-12"">
                    <div class=""info-box mb-4"">
                        <i class='bx bxs-user-detail'></i>
                        <h3>Funcionário Atual</h3>
                        <p><b>Nome:</b>  ");
#nullable restore
#line 23 "C:\Users\Administrador\Desktop\ISTEC\2ANO_2SEMESTRE\TI III\ProjetoTI\ProjetoGestor\ProjetoGestor\Views\Funcionario\Editar.cshtml"
                                    Write(Model.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral(" &emsp;</p>\r\n                        <p><b>Nif:</b>  ");
#nullable restore
#line 24 "C:\Users\Administrador\Desktop\ISTEC\2ANO_2SEMESTRE\TI III\ProjetoTI\ProjetoGestor\ProjetoGestor\Views\Funcionario\Editar.cshtml"
                                   Write(Model.Nif);

#line default
#line hidden
#nullable disable
            WriteLiteral(" &emsp;</p>\r\n                        <p><b>Contacto:</b>  ");
#nullable restore
#line 25 "C:\Users\Administrador\Desktop\ISTEC\2ANO_2SEMESTRE\TI III\ProjetoTI\ProjetoGestor\ProjetoGestor\Views\Funcionario\Editar.cshtml"
                                        Write(Model.Contacto);

#line default
#line hidden
#nullable disable
            WriteLiteral(" &emsp;</p>\r\n                        <p><b>Nr Funcionário:</b>  ");
#nullable restore
#line 26 "C:\Users\Administrador\Desktop\ISTEC\2ANO_2SEMESTRE\TI III\ProjetoTI\ProjetoGestor\ProjetoGestor\Views\Funcionario\Editar.cshtml"
                                              Write(Model.NrFuncionario);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" &emsp;</p>
                    </div>
                </div>

            </div>

            <div class=""row"" data-aos=""fade-up"">

                <div class=""col-lg-12"">
                    <form method=""post"" action=""/Funcionario/Editar"">
                        <input type=""hidden"" name=""Id""");
            BeginWriteAttribute("value", " value=\"", 1241, "\"", 1258, 1);
#nullable restore
#line 36 "C:\Users\Administrador\Desktop\ISTEC\2ANO_2SEMESTRE\TI III\ProjetoTI\ProjetoGestor\ProjetoGestor\Views\Funcionario\Editar.cshtml"
WriteAttributeValue("", 1249, Model.Id, 1249, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                        <div class=\"row\">\r\n                            <div class=\"col-md-6 form-group\">\r\n                                <input type=\"text\" name=\"Nome\" class=\"form-control\" placeholder=\"Nome\"");
            BeginWriteAttribute("value", " value=\"", 1472, "\"", 1491, 1);
#nullable restore
#line 39 "C:\Users\Administrador\Desktop\ISTEC\2ANO_2SEMESTRE\TI III\ProjetoTI\ProjetoGestor\ProjetoGestor\Views\Funcionario\Editar.cshtml"
WriteAttributeValue("", 1480, Model.Nome, 1480, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" required />\r\n                            </div>\r\n                            <div class=\"col-md-6 form-group mt-3 mt-md-0\">\r\n                                <input type=\"text\" name=\"Nif\" class=\"form-control\" placeholder=\"Nif\"");
            BeginWriteAttribute("value", " value=\"", 1718, "\"", 1736, 1);
#nullable restore
#line 42 "C:\Users\Administrador\Desktop\ISTEC\2ANO_2SEMESTRE\TI III\ProjetoTI\ProjetoGestor\ProjetoGestor\Views\Funcionario\Editar.cshtml"
WriteAttributeValue("", 1726, Model.Nif, 1726, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" required/>
                            </div>
                        </div>

                        <div class=""row mt-3"">
                            <div class=""col-md-6 form-group mt-3 mt-md-0"">
                                <input type=""text"" name=""Contacto"" class=""form-control"" placeholder=""Contacto""");
            BeginWriteAttribute("value", " value=\"", 2054, "\"", 2077, 1);
#nullable restore
#line 48 "C:\Users\Administrador\Desktop\ISTEC\2ANO_2SEMESTRE\TI III\ProjetoTI\ProjetoGestor\ProjetoGestor\Views\Funcionario\Editar.cshtml"
WriteAttributeValue("", 2062, Model.Contacto, 2062, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" required/>\r\n                            </div>\r\n                            <div class=\"col-md-6 form-group mt-3 mt-md-0\">\r\n                                <input type=\"text\" name=\"NrFuncionario\" class=\"form-control\" placeholder=\"NrFuncionario\"");
            BeginWriteAttribute("value", " value=\"", 2323, "\"", 2351, 1);
#nullable restore
#line 51 "C:\Users\Administrador\Desktop\ISTEC\2ANO_2SEMESTRE\TI III\ProjetoTI\ProjetoGestor\ProjetoGestor\Views\Funcionario\Editar.cshtml"
WriteAttributeValue("", 2331, Model.NrFuncionario, 2331, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" required/>
                            </div>
                        </div>
                        <br />
                        <div class=""text-center"">
                            <input type=""submit"" name=""enviar"" value=""Registar Edição"" style=""background: #576880; border: 0; padding: 10px 24px; color: #fff; transition: 0.7s;"" />
                        </div>
                    </form>

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
