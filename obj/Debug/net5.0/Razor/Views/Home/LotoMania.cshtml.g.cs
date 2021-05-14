#pragma checksum "C:\PROJETOS\ConsumingAPIDotNetMVCBootstrap\Views\Home\LotoMania.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d1df91a41a39d911e745352eabb2b6a55d482033"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_LotoMania), @"mvc.1.0.view", @"/Views/Home/LotoMania.cshtml")]
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
#line 1 "C:\PROJETOS\ConsumingAPIDotNetMVCBootstrap\Views\_ViewImports.cshtml"
using ConsumingAPIDotNetMVCBootstrap;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\PROJETOS\ConsumingAPIDotNetMVCBootstrap\Views\_ViewImports.cshtml"
using ConsumingAPIDotNetMVCBootstrap.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\PROJETOS\ConsumingAPIDotNetMVCBootstrap\Views\Home\LotoMania.cshtml"
using ConsumingAPIDotNetMVCBootstrap.Services;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d1df91a41a39d911e745352eabb2b6a55d482033", @"/Views/Home/LotoMania.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b43095563d010619dfbca1f2c48e6cfe384b7f7f", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_LotoMania : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\PROJETOS\ConsumingAPIDotNetMVCBootstrap\Views\Home\LotoMania.cshtml"
  
    DataResponse serviceData = new ServiceDataResponse().GetDataResponse("jogos/lotomania/lasted");
    var data = serviceData.Data.FirstOrDefault();
    ViewData["Title"] = data.TipoJogo.Replace("_", " ");
    var accumulatedValue = data.ValorAcumuladoConcursoEspecial;

#line default
#line hidden
#nullable disable
            WriteLiteral("<h1>");
#nullable restore
#line 8 "C:\PROJETOS\ConsumingAPIDotNetMVCBootstrap\Views\Home\LotoMania.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n\r\n<br/>\r\n<div class=\"row row-cols-1 row-cols-md-3 mb-3 text-center\">\r\n");
#nullable restore
#line 12 "C:\PROJETOS\ConsumingAPIDotNetMVCBootstrap\Views\Home\LotoMania.cshtml"
     foreach (var value in data.ListaDezenas)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"col-lg-2 col-sm-4\">\r\n            <div class=\"mb-4 rounded-3 shadow-sm\">\r\n            <div class=\"card-body lotofacil-card\">\r\n                <h1 class=\"lotofacil-text card-title pricing-card-title\">");
#nullable restore
#line 17 "C:\PROJETOS\ConsumingAPIDotNetMVCBootstrap\Views\Home\LotoMania.cshtml"
                                                                    Write(value);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n            </div>\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 21 "C:\PROJETOS\ConsumingAPIDotNetMVCBootstrap\Views\Home\LotoMania.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n\r\n<br />\r\n<div class=\"p-4 p-md-5 mb-4 text-white rounded bg-dark\">\r\n    <div class=\"col-md-6 px-0\"> \r\n        <h1 class=\"display-4 fst-italic\">");
#nullable restore
#line 27 "C:\PROJETOS\ConsumingAPIDotNetMVCBootstrap\Views\Home\LotoMania.cshtml"
                                    Write(accumulatedValue);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h1>
        <p class=""lead my-3"">Valor acumulado</p>
    </div>
</div>

<div class=""row row-cols-1 row-cols-md-3 mb-3 text-center"">
    <table class=""table"">
        <thead class=""thead-light"">
            <tr>
                <th scope=""col"">Numero de ganhadores</th>
                <th scope=""col"">Valor do Premio</th>
                <th scope=""col"">Descricao da Faixa</th>
            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 42 "C:\PROJETOS\ConsumingAPIDotNetMVCBootstrap\Views\Home\LotoMania.cshtml"
             foreach (var premio in data.ListaRateioPremio)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>");
#nullable restore
#line 45 "C:\PROJETOS\ConsumingAPIDotNetMVCBootstrap\Views\Home\LotoMania.cshtml"
                   Write(premio.NumeroDeGanhadores);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 46 "C:\PROJETOS\ConsumingAPIDotNetMVCBootstrap\Views\Home\LotoMania.cshtml"
                   Write(premio.ValorPremio);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 47 "C:\PROJETOS\ConsumingAPIDotNetMVCBootstrap\Views\Home\LotoMania.cshtml"
                   Write(premio.DescricaoFaixa);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                </tr>\r\n");
#nullable restore
#line 49 "C:\PROJETOS\ConsumingAPIDotNetMVCBootstrap\Views\Home\LotoMania.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n</div>");
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
