#pragma checksum "D:\VS Projeler\MekanKesfi\MekanKesfiWebUI\Views\Mekanlar\Detay.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0befd5c8ca147ccc089592fcc41bfebeebebc4d2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Mekanlar_Detay), @"mvc.1.0.view", @"/Views/Mekanlar/Detay.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Mekanlar/Detay.cshtml", typeof(AspNetCore.Views_Mekanlar_Detay))]
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
#line 1 "D:\VS Projeler\MekanKesfi\MekanKesfiWebUI\Views\_ViewImports.cshtml"
using MekanKesfiWebUI;

#line default
#line hidden
#line 2 "D:\VS Projeler\MekanKesfi\MekanKesfiWebUI\Views\_ViewImports.cshtml"
using MekanKesfiWebUI.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0befd5c8ca147ccc089592fcc41bfebeebebc4d2", @"/Views/Mekanlar/Detay.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6a57334104cba6e9f7ccefa07e751685970da472", @"/Views/_ViewImports.cshtml")]
    public class Views_Mekanlar_Detay : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MekanKesfiWebUI.Models.MekanlarViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(49, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\VS Projeler\MekanKesfi\MekanKesfiWebUI\Views\Mekanlar\Detay.cshtml"
  
    ViewData["Title"] = "Detay";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(139, 306, true);
            WriteLiteral(@"

<div class=""container"">
    <div class=""row"">
        <div class=""col-md-5"">
            <div id=""carouselExampleControls"" class=""carousel slide"" data-ride=""carousel"">
                <div class=""carousel-inner"">
                    <div class=""carousel-item active"">
                        <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 445, "\"", 530, 1);
#line 15 "D:\VS Projeler\MekanKesfi\MekanKesfiWebUI\Views\Mekanlar\Detay.cshtml"
WriteAttributeValue("", 451, Model.MekanDetay.FotoList.FirstOrDefault(x=> x.AnaFotograf ==true).FotografYol, 451, 79, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(531, 90, true);
            WriteLiteral(" class=\"d-block w-100\" width=\"200\" height=\"300\" alt=\"...\">\r\n                    </div>\r\n\r\n");
            EndContext();
#line 18 "D:\VS Projeler\MekanKesfi\MekanKesfiWebUI\Views\Mekanlar\Detay.cshtml"
                     foreach (var item in Model.MekanDetay.FotoList.Where(x => x.AnaFotograf == false))
                    {

#line default
#line hidden
            BeginContext(749, 85, true);
            WriteLiteral("                        <div class=\"carousel-item\">\r\n                            <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 834, "\"", 857, 1);
#line 21 "D:\VS Projeler\MekanKesfi\MekanKesfiWebUI\Views\Mekanlar\Detay.cshtml"
WriteAttributeValue("", 840, item.FotografYol, 840, 17, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(858, 92, true);
            WriteLiteral(" class=\"d-block w-100\" width=\"200\" height=\"300\" alt=\"...\">\r\n                        </div>\r\n");
            EndContext();
#line 23 "D:\VS Projeler\MekanKesfi\MekanKesfiWebUI\Views\Mekanlar\Detay.cshtml"
                    }

#line default
#line hidden
            BeginContext(973, 676, true);
            WriteLiteral(@"                </div>
                <a class=""carousel-control-prev"" href=""#carouselExampleControls"" role=""button"" data-slide=""prev"">
                    <span class=""carousel-control-prev-icon"" aria-hidden=""true""></span>
                    <span class=""sr-only"">Previous</span>
                </a>
                <a class=""carousel-control-next"" href=""#carouselExampleControls"" role=""button"" data-slide=""next"">
                    <span class=""carousel-control-next-icon"" aria-hidden=""true""></span>
                    <span class=""sr-only"">Next</span>
                </a>
            </div>
        </div>

        <div class=""col-md-7"">
            <h4>");
            EndContext();
            BeginContext(1650, 24, false);
#line 37 "D:\VS Projeler\MekanKesfi\MekanKesfiWebUI\Views\Mekanlar\Detay.cshtml"
           Write(Model.MekanDetay.MekanAd);

#line default
#line hidden
            EndContext();
            BeginContext(1674, 151, true);
            WriteLiteral("</h4>\r\n            <ul class=\"list-group\">\r\n                <li class=\"list-group-item\"><label class=\"col-md-5\">Adres :</label><label class=\"col-md-7\">");
            EndContext();
            BeginContext(1826, 27, false);
#line 39 "D:\VS Projeler\MekanKesfi\MekanKesfiWebUI\Views\Mekanlar\Detay.cshtml"
                                                                                                      Write(Model.MekanDetay.MekanAdres);

#line default
#line hidden
            EndContext();
            BeginContext(1853, 123, true);
            WriteLiteral("</label></li>\r\n                <li class=\"list-group-item\"><label class=\"col-md-5\">E-Mail :</label><label class=\"col-md-7\">");
            EndContext();
            BeginContext(1977, 22, false);
#line 40 "D:\VS Projeler\MekanKesfi\MekanKesfiWebUI\Views\Mekanlar\Detay.cshtml"
                                                                                                       Write(Model.MekanDetay.EMail);

#line default
#line hidden
            EndContext();
            BeginContext(1999, 126, true);
            WriteLiteral("</label></li>\r\n                <li class=\"list-group-item\"><label class=\"col-md-5\">İlçe / İl :</label><label class=\"col-md-7\">");
            EndContext();
            BeginContext(2126, 23, false);
#line 41 "D:\VS Projeler\MekanKesfi\MekanKesfiWebUI\Views\Mekanlar\Detay.cshtml"
                                                                                                          Write(Model.MekanDetay.IlceAd);

#line default
#line hidden
            EndContext();
            BeginContext(2149, 3, true);
            WriteLiteral(" / ");
            EndContext();
            BeginContext(2153, 21, false);
#line 41 "D:\VS Projeler\MekanKesfi\MekanKesfiWebUI\Views\Mekanlar\Detay.cshtml"
                                                                                                                                     Write(Model.MekanDetay.IlAd);

#line default
#line hidden
            EndContext();
            BeginContext(2174, 130, true);
            WriteLiteral("</label></li>\r\n                <li class=\"list-group-item\"><label class=\"col-md-5\">Sahibinin Adı :</label><label class=\"col-md-7\">");
            EndContext();
            BeginContext(2305, 30, false);
#line 42 "D:\VS Projeler\MekanKesfi\MekanKesfiWebUI\Views\Mekanlar\Detay.cshtml"
                                                                                                              Write(Model.MekanDetay.MekanSahibiAd);

#line default
#line hidden
            EndContext();
            BeginContext(2335, 339, true);
            WriteLiteral(@"</label></li>
            </ul>
        </div>
    </div>

    <hr />

    <div class=""row"">
        <div class=""col-md-5"">
            <table class=""table table-bordered table-hover table-secondary"">
                <tr>
                    <th>Ürün Adı</th>
                    <th>Ürün Fiyatı</th>
                </tr>

");
            EndContext();
#line 57 "D:\VS Projeler\MekanKesfi\MekanKesfiWebUI\Views\Mekanlar\Detay.cshtml"
                 foreach (var item in Model.UrunListe)
                {

#line default
#line hidden
            BeginContext(2749, 54, true);
            WriteLiteral("                    <tr>\r\n                        <td>");
            EndContext();
            BeginContext(2804, 11, false);
#line 60 "D:\VS Projeler\MekanKesfi\MekanKesfiWebUI\Views\Mekanlar\Detay.cshtml"
                       Write(item.UrunAd);

#line default
#line hidden
            EndContext();
            BeginContext(2815, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(2851, 14, false);
#line 61 "D:\VS Projeler\MekanKesfi\MekanKesfiWebUI\Views\Mekanlar\Detay.cshtml"
                       Write(item.UrunFiyat);

#line default
#line hidden
            EndContext();
            BeginContext(2865, 34, true);
            WriteLiteral("</td>\r\n                    </tr>\r\n");
            EndContext();
#line 63 "D:\VS Projeler\MekanKesfi\MekanKesfiWebUI\Views\Mekanlar\Detay.cshtml"
                }

#line default
#line hidden
            BeginContext(2918, 1093, true);
            WriteLiteral(@"
            </table>

        </div>
        <div class=""col-md-7"">
            <ul class=""nav nav-tabs"" id=""myTab"" role=""tablist"">
                <li class=""nav-item"">
                    <a class=""nav-link active"" id=""reklam-tab"" data-toggle=""tab"" href=""#reklam"" role=""tab"" aria-controls=""reklam"" aria-selected=""true"">Reklamlar</a>
                </li>
                <li class=""nav-item"">
                    <a class=""nav-link"" id=""harita-tab"" data-toggle=""tab"" href=""#harita"" role=""tab"" aria-controls=""harita"" aria-selected=""false"">Harita</a>
                </li>
            </ul>
            <div class=""tab-content"" id=""myTabContent"">
                <div class=""tab-pane fade show active"" id=""reklam"" role=""tabpanel"" aria-labelledby=""reklam-tab"">
                    <h5>Reklamlar</h5>
                    <table class=""table table-hover table-bordered"">
                        <tr>
                            <th>Açıklama</th>
                            <th>Bitiş Zamanı</th>
          ");
            WriteLiteral("                  <th>Fotoğrafı</th>\r\n                        </tr>\r\n");
            EndContext();
#line 86 "D:\VS Projeler\MekanKesfi\MekanKesfiWebUI\Views\Mekanlar\Detay.cshtml"
                         foreach (var item in Model.ReklamListe)
                        {

#line default
#line hidden
            BeginContext(4104, 62, true);
            WriteLiteral("                        <tr>\r\n                            <td>");
            EndContext();
            BeginContext(4167, 16, false);
#line 89 "D:\VS Projeler\MekanKesfi\MekanKesfiWebUI\Views\Mekanlar\Detay.cshtml"
                           Write(item.ReklamDetay);

#line default
#line hidden
            EndContext();
            BeginContext(4183, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(4223, 16, false);
#line 90 "D:\VS Projeler\MekanKesfi\MekanKesfiWebUI\Views\Mekanlar\Detay.cshtml"
                           Write(item.ReklamBitis);

#line default
#line hidden
            EndContext();
            BeginContext(4239, 43, true);
            WriteLiteral("</td>\r\n                            <td><img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 4282, "\"", 4304, 1);
#line 91 "D:\VS Projeler\MekanKesfi\MekanKesfiWebUI\Views\Mekanlar\Detay.cshtml"
WriteAttributeValue("", 4288, item.ReklamFoto, 4288, 16, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(4305, 64, true);
            WriteLiteral(" width=\"75\" height=\"75\" /></td>\r\n                        </tr>\r\n");
            EndContext();
#line 93 "D:\VS Projeler\MekanKesfi\MekanKesfiWebUI\Views\Mekanlar\Detay.cshtml"
                        }

#line default
#line hidden
            BeginContext(4396, 236, true);
            WriteLiteral("                    </table>\r\n                </div>\r\n                <div class=\"tab-pane fade\" id=\"harita\" role=\"tabpanel\" aria-labelledby=\"harita-tab\">Harita</div>\r\n            </div>\r\n        </div>\r\n        \r\n    </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MekanKesfiWebUI.Models.MekanlarViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
