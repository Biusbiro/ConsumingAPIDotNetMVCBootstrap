#pragma checksum "C:\PROJETOS\ConsumingAPIDotNetMVCBootstrap\Views\Home\MegaSena.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "efe63aef1b3e87422c2b3b945c0b81d9ae5b0e32"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_MegaSena), @"mvc.1.0.view", @"/Views/Home/MegaSena.cshtml")]
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
#line 1 "C:\PROJETOS\ConsumingAPIDotNetMVCBootstrap\Views\Home\MegaSena.cshtml"
using ConsumingAPIDotNetMVCBootstrap.Services;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"efe63aef1b3e87422c2b3b945c0b81d9ae5b0e32", @"/Views/Home/MegaSena.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b43095563d010619dfbca1f2c48e6cfe384b7f7f", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_MegaSena : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\PROJETOS\ConsumingAPIDotNetMVCBootstrap\Views\Home\MegaSena.cshtml"
  
    DataResponse serviceData = new ServiceDataResponse().GetDataResponse("jogos/megasena/lasted");
    var data = serviceData.Data.FirstOrDefault();
    var number1 = data.ListaDezenas[0];
    var number2 = data.ListaDezenas[1];
    var number3 = data.ListaDezenas[2];
    var number4 = data.ListaDezenas[3];
    var number5 = data.ListaDezenas[4];
    var number6 = data.ListaDezenas[5];

    ViewData["Title"] = data.TipoJogo.Replace("_", " ");

#line default
#line hidden
#nullable disable
            WriteLiteral("<h1>");
#nullable restore
#line 14 "C:\PROJETOS\ConsumingAPIDotNetMVCBootstrap\Views\Home\MegaSena.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h1>

<br/>
<div class=""row row-cols-1 row-cols-md-3 mb-3 text-center"">

    <div class=""col-lg-2 col-sm-4"">
        <div class=""card mb-4 rounded-3 shadow-sm"">
        <div class=""card-body"">
            <h1 class=""card-title pricing-card-title"">");
#nullable restore
#line 22 "C:\PROJETOS\ConsumingAPIDotNetMVCBootstrap\Views\Home\MegaSena.cshtml"
                                                 Write(number1);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n        </div>\r\n        </div>\r\n    </div>\r\n\r\n    <div class=\"col-lg-2 col-sm-4\">\r\n        <div class=\"card mb-4 rounded-3 shadow-sm\">\r\n        <div class=\"card-body\">\r\n            <h1 class=\"card-title pricing-card-title\">");
#nullable restore
#line 30 "C:\PROJETOS\ConsumingAPIDotNetMVCBootstrap\Views\Home\MegaSena.cshtml"
                                                 Write(number2);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n        </div>\r\n        </div>\r\n    </div>\r\n\r\n    <div class=\"col-lg-2 col-sm-4\">\r\n        <div class=\"card mb-4 rounded-3 shadow-sm\">\r\n        <div class=\"card-body\">\r\n            <h1 class=\"card-title pricing-card-title\">");
#nullable restore
#line 38 "C:\PROJETOS\ConsumingAPIDotNetMVCBootstrap\Views\Home\MegaSena.cshtml"
                                                 Write(number3);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n        </div>\r\n        </div>\r\n    </div>\r\n\r\n    <div class=\"col-lg-2 col-sm-4\">\r\n        <div class=\"card mb-4 rounded-3 shadow-sm\">\r\n        <div class=\"card-body\">\r\n            <h1 class=\"card-title pricing-card-title\">");
#nullable restore
#line 46 "C:\PROJETOS\ConsumingAPIDotNetMVCBootstrap\Views\Home\MegaSena.cshtml"
                                                 Write(number4);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n        </div>\r\n        </div>\r\n    </div>\r\n\r\n    <div class=\"col-lg-2 col-sm-4\">\r\n        <div class=\"card mb-4 rounded-3 shadow-sm\">\r\n        <div class=\"card-body\">\r\n            <h1 class=\"card-title pricing-card-title\">");
#nullable restore
#line 54 "C:\PROJETOS\ConsumingAPIDotNetMVCBootstrap\Views\Home\MegaSena.cshtml"
                                                 Write(number5);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n        </div>\r\n        </div>\r\n    </div>\r\n\r\n    <div class=\"col-lg-2 col-sm-4\">\r\n        <div class=\"card mb-4 rounded-3 shadow-sm\">\r\n        <div class=\"card-body\">\r\n            <h1 class=\"card-title pricing-card-title\">");
#nullable restore
#line 62 "C:\PROJETOS\ConsumingAPIDotNetMVCBootstrap\Views\Home\MegaSena.cshtml"
                                                 Write(number6);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n        </div>\r\n        </div>\r\n    </div>\r\n\r\n</div>");
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
