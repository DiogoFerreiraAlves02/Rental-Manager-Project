#pragma checksum "C:\Users\Administrador\Desktop\ISTEC\2ANO_2SEMESTRE\TI III\ProjetoTI\ProjetoGestor\ProjetoGestor\Views\Aluguer\Consultar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "49d4161b118ba6bac4f948d2b0335e3cc724d176"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Aluguer_Consultar), @"mvc.1.0.view", @"/Views/Aluguer/Consultar.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"49d4161b118ba6bac4f948d2b0335e3cc724d176", @"/Views/Aluguer/Consultar.cshtml")]
    public class Views_Aluguer_Consultar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\Administrador\Desktop\ISTEC\2ANO_2SEMESTRE\TI III\ProjetoTI\ProjetoGestor\ProjetoGestor\Views\Aluguer\Consultar.cshtml"
  
    ViewData["Title"] = "Consulta de Aluguer";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Administrador\Desktop\ISTEC\2ANO_2SEMESTRE\TI III\ProjetoTI\ProjetoGestor\ProjetoGestor\Views\Aluguer\Consultar.cshtml"
   var listaProdutos = ViewBag.listaProdutos; var listaClientes = ViewBag.listaClientes; var listaFuncionarios = ViewBag.listaFuncionarios;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<!-- ======= Portfolio Details Section ======= -->
<section id=""portfolio-details"" class=""portfolio-details"">
    <div class=""container"">

        <div class=""row gy-12"">

            <div class=""col-lg-12"">
                <div class=""portfolio-info"">
                    <h3>Informação do Aluguer&nbsp;&nbsp;&nbsp;&nbsp;<i class='bx bx-purchase-tag-alt'></i></h3>
                    <ul>

                        <li>
                            <strong>Cliente</strong>: ");
#nullable restore
#line 19 "C:\Users\Administrador\Desktop\ISTEC\2ANO_2SEMESTRE\TI III\ProjetoTI\ProjetoGestor\ProjetoGestor\Views\Aluguer\Consultar.cshtml"
                                                 Write(Model.Cliente.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </li>\r\n                        <li>\r\n                            <strong>Funcionario</strong>: ");
#nullable restore
#line 22 "C:\Users\Administrador\Desktop\ISTEC\2ANO_2SEMESTRE\TI III\ProjetoTI\ProjetoGestor\ProjetoGestor\Views\Aluguer\Consultar.cshtml"
                                                     Write(Model.Funcionario.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </li>\r\n                        <li>\r\n                            <strong>Produto</strong>: ");
#nullable restore
#line 25 "C:\Users\Administrador\Desktop\ISTEC\2ANO_2SEMESTRE\TI III\ProjetoTI\ProjetoGestor\ProjetoGestor\Views\Aluguer\Consultar.cshtml"
                                                 Write(Model.Produto.Designacao);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </li>\r\n                        <li><strong>Preço Diário</strong>: ");
#nullable restore
#line 27 "C:\Users\Administrador\Desktop\ISTEC\2ANO_2SEMESTRE\TI III\ProjetoTI\ProjetoGestor\ProjetoGestor\Views\Aluguer\Consultar.cshtml"
                                                      Write(Model.PrecoDiario);

#line default
#line hidden
#nullable disable
            WriteLiteral(" €</li>\r\n                        <li><strong>Dias de Aluguer</strong>: ");
#nullable restore
#line 28 "C:\Users\Administrador\Desktop\ISTEC\2ANO_2SEMESTRE\TI III\ProjetoTI\ProjetoGestor\ProjetoGestor\Views\Aluguer\Consultar.cshtml"
                                                         Write(Model.Dias);

#line default
#line hidden
#nullable disable
            WriteLiteral(" Dias</li>\r\n                        <li><strong>Preço Total</strong>: ");
#nullable restore
#line 29 "C:\Users\Administrador\Desktop\ISTEC\2ANO_2SEMESTRE\TI III\ProjetoTI\ProjetoGestor\ProjetoGestor\Views\Aluguer\Consultar.cshtml"
                                                     Write(Model.PrecoTotal);

#line default
#line hidden
#nullable disable
            WriteLiteral(" €</li>\r\n                        <li><strong>Caução</strong>: ");
#nullable restore
#line 30 "C:\Users\Administrador\Desktop\ISTEC\2ANO_2SEMESTRE\TI III\ProjetoTI\ProjetoGestor\ProjetoGestor\Views\Aluguer\Consultar.cshtml"
                                                Write(Model.Caucao);

#line default
#line hidden
#nullable disable
            WriteLiteral(" €</li>\r\n                        <li><strong>Data do Aluguer</strong>: ");
#nullable restore
#line 31 "C:\Users\Administrador\Desktop\ISTEC\2ANO_2SEMESTRE\TI III\ProjetoTI\ProjetoGestor\ProjetoGestor\Views\Aluguer\Consultar.cshtml"
                                                         Write(Model.DataAluguer.ToString("yyyy-MM-dd"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                        <li><strong>Data Limite</strong>: ");
#nullable restore
#line 32 "C:\Users\Administrador\Desktop\ISTEC\2ANO_2SEMESTRE\TI III\ProjetoTI\ProjetoGestor\ProjetoGestor\Views\Aluguer\Consultar.cshtml"
                                                     Write(Model.DataLimite.ToString("yyyy-MM-dd"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                        <li><strong>Estado</strong>: ");
#nullable restore
#line 33 "C:\Users\Administrador\Desktop\ISTEC\2ANO_2SEMESTRE\TI III\ProjetoTI\ProjetoGestor\ProjetoGestor\Views\Aluguer\Consultar.cshtml"
                                                Write(Model.Estado);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                    </ul>\r\n                </div>\r\n                <br><br>\r\n                <div class=\"text-center\">\r\n                    <form");
            BeginWriteAttribute("action", " action=\"", 1834, "\"", 1868, 2);
            WriteAttributeValue("", 1843, "/Aluguer/Editar/", 1843, 16, true);
#nullable restore
#line 38 "C:\Users\Administrador\Desktop\ISTEC\2ANO_2SEMESTRE\TI III\ProjetoTI\ProjetoGestor\ProjetoGestor\Views\Aluguer\Consultar.cshtml"
WriteAttributeValue("", 1859, Model.Id, 1859, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                        <input type=\"submit\" name=\"editarCliente\" value=\"Editar Aluguer\" style=\"background: #576880; border: 0; padding: 10px 24px; color: #fff; transition: 0.7s;\" />\r\n                    </form><br>\r\n                    <form");
            BeginWriteAttribute("action", " action=\"", 2114, "\"", 2150, 2);
            WriteAttributeValue("", 2123, "/Aluguer/Eliminar/", 2123, 18, true);
#nullable restore
#line 41 "C:\Users\Administrador\Desktop\ISTEC\2ANO_2SEMESTRE\TI III\ProjetoTI\ProjetoGestor\ProjetoGestor\Views\Aluguer\Consultar.cshtml"
WriteAttributeValue("", 2141, Model.Id, 2141, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
                        <input type=""submit"" name=""eliminarCliente"" value=""Eliminar Aluguer"" style=""background: #576880; border: 0; padding: 10px 24px; color: #fff; transition: 0.7s;"" />
                    </form>
                </div>
            </div>

        </div>

    </div>
</section><!-- End Portfolio Details Section -->
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