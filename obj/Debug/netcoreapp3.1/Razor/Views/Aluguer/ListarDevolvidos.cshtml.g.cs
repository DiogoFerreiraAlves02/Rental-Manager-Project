#pragma checksum "C:\Users\Administrador\Desktop\ISTEC\2ANO_2SEMESTRE\TI III\ProjetoTI\ProjetoGestor\ProjetoGestor\Views\Aluguer\ListarDevolvidos.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5996a4ccd8c294b9df1813072cb12986abd339af"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Aluguer_ListarDevolvidos), @"mvc.1.0.view", @"/Views/Aluguer/ListarDevolvidos.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5996a4ccd8c294b9df1813072cb12986abd339af", @"/Views/Aluguer/ListarDevolvidos.cshtml")]
    public class Views_Aluguer_ListarDevolvidos : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\Administrador\Desktop\ISTEC\2ANO_2SEMESTRE\TI III\ProjetoTI\ProjetoGestor\ProjetoGestor\Views\Aluguer\ListarDevolvidos.cshtml"
  
    ViewData["Title"] = "ListarDevolvidos";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<main id=""main"">

    <!-- ======= Services Section ======= -->
    <section id=""services"" class=""services"">
        <div class=""container"">

            <div class=""section-title"">
                <span>Alugueres Finalizados</span>
                <h2>Alugueres Finalizados</h2><br />
");
#nullable restore
#line 16 "C:\Users\Administrador\Desktop\ISTEC\2ANO_2SEMESTRE\TI III\ProjetoTI\ProjetoGestor\ProjetoGestor\Views\Aluguer\ListarDevolvidos.cshtml"
                   var listaAlugueres = @Model; 

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\Administrador\Desktop\ISTEC\2ANO_2SEMESTRE\TI III\ProjetoTI\ProjetoGestor\ProjetoGestor\Views\Aluguer\ListarDevolvidos.cshtml"
                   decimal total = 0; 

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\Administrador\Desktop\ISTEC\2ANO_2SEMESTRE\TI III\ProjetoTI\ProjetoGestor\ProjetoGestor\Views\Aluguer\ListarDevolvidos.cshtml"
                     foreach (var aluguer in listaAlugueres) {
                        total = total + aluguer.PrecoTotal; 
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                <h4>Total dos Alugueres Finalizados ");
#nullable restore
#line 22 "C:\Users\Administrador\Desktop\ISTEC\2ANO_2SEMESTRE\TI III\ProjetoTI\ProjetoGestor\ProjetoGestor\Views\Aluguer\ListarDevolvidos.cshtml"
                                               Write(total.ToString("0.00"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" €</h4>\r\n");
#nullable restore
#line 23 "C:\Users\Administrador\Desktop\ISTEC\2ANO_2SEMESTRE\TI III\ProjetoTI\ProjetoGestor\ProjetoGestor\Views\Aluguer\ListarDevolvidos.cshtml"
                   var media = total/listaAlugueres.Count;

#line default
#line hidden
#nullable disable
            WriteLiteral("                <h4>Média de Valor por Aluguer ");
#nullable restore
#line 24 "C:\Users\Administrador\Desktop\ISTEC\2ANO_2SEMESTRE\TI III\ProjetoTI\ProjetoGestor\ProjetoGestor\Views\Aluguer\ListarDevolvidos.cshtml"
                                          Write(media.ToString("0.00"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" €</h4>\r\n            </div>\r\n");
#nullable restore
#line 26 "C:\Users\Administrador\Desktop\ISTEC\2ANO_2SEMESTRE\TI III\ProjetoTI\ProjetoGestor\ProjetoGestor\Views\Aluguer\ListarDevolvidos.cshtml"
               var listaProdutos = ViewBag.listaProdutos; var listaClientes = ViewBag.listaClientes; var listaFuncionarios = ViewBag.listaFuncionarios;

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"row\">\r\n");
#nullable restore
#line 28 "C:\Users\Administrador\Desktop\ISTEC\2ANO_2SEMESTRE\TI III\ProjetoTI\ProjetoGestor\ProjetoGestor\Views\Aluguer\ListarDevolvidos.cshtml"
                   foreach (var aluguer in listaAlugueres) {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        <div class=""col-lg-4 col-md-6 align-items-stretch"" data-aos=""fade-up"">
                            <div class=""icon-box"">
                                <div class=""icon""><i class='bx bx-purchase-tag-alt'></i></div>
                                <h4>
                                    <a");
            BeginWriteAttribute("href", " href=\"", 1453, "\"", 1490, 2);
            WriteAttributeValue("", 1460, "/Aluguer/Consultar/", 1460, 19, true);
#nullable restore
#line 33 "C:\Users\Administrador\Desktop\ISTEC\2ANO_2SEMESTRE\TI III\ProjetoTI\ProjetoGestor\ProjetoGestor\Views\Aluguer\ListarDevolvidos.cshtml"
WriteAttributeValue("", 1479, aluguer.Id, 1479, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                        Cliente: ");
#nullable restore
#line 34 "C:\Users\Administrador\Desktop\ISTEC\2ANO_2SEMESTRE\TI III\ProjetoTI\ProjetoGestor\ProjetoGestor\Views\Aluguer\ListarDevolvidos.cshtml"
                                            Write(aluguer.Cliente.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                                    </a>\r\n                                </h4>\r\n                                <p>\r\n                                    Funcionário: ");
#nullable restore
#line 39 "C:\Users\Administrador\Desktop\ISTEC\2ANO_2SEMESTRE\TI III\ProjetoTI\ProjetoGestor\ProjetoGestor\Views\Aluguer\ListarDevolvidos.cshtml"
                                            Write(aluguer.Funcionario.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </p>\r\n                                <p>\r\n                                    Produto: ");
#nullable restore
#line 42 "C:\Users\Administrador\Desktop\ISTEC\2ANO_2SEMESTRE\TI III\ProjetoTI\ProjetoGestor\ProjetoGestor\Views\Aluguer\ListarDevolvidos.cshtml"
                                        Write(aluguer.Produto.Designacao);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </p>\r\n                                <p>Preço Total: ");
#nullable restore
#line 44 "C:\Users\Administrador\Desktop\ISTEC\2ANO_2SEMESTRE\TI III\ProjetoTI\ProjetoGestor\ProjetoGestor\Views\Aluguer\ListarDevolvidos.cshtml"
                                           Write(aluguer.PrecoTotal);

#line default
#line hidden
#nullable disable
            WriteLiteral(" €</p>\r\n                                <p>Data Aluguer: ");
#nullable restore
#line 45 "C:\Users\Administrador\Desktop\ISTEC\2ANO_2SEMESTRE\TI III\ProjetoTI\ProjetoGestor\ProjetoGestor\Views\Aluguer\ListarDevolvidos.cshtml"
                                            Write(aluguer.DataAluguer.ToString("yyyy-MM-dd"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </p>\r\n\r\n                                <p>Data Limite: ");
#nullable restore
#line 47 "C:\Users\Administrador\Desktop\ISTEC\2ANO_2SEMESTRE\TI III\ProjetoTI\ProjetoGestor\ProjetoGestor\Views\Aluguer\ListarDevolvidos.cshtml"
                                           Write(aluguer.DataLimite.ToString("yyyy-MM-dd"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                            </div>\r\n                        </div>\r\n");
#nullable restore
#line 50 "C:\Users\Administrador\Desktop\ISTEC\2ANO_2SEMESTRE\TI III\ProjetoTI\ProjetoGestor\ProjetoGestor\Views\Aluguer\ListarDevolvidos.cshtml"
                    }
                

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n        </div>\r\n\r\n    </section><!-- End Services Section -->\r\n\r\n</main><!-- End #main -->\r\n");
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