#pragma checksum "D:\OlsenDev\Projetos\BasqueteVirtual\BasqueteVirtual\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e4911da77d790d87ea1bc4f8ecdcb04fb183c40f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "D:\OlsenDev\Projetos\BasqueteVirtual\BasqueteVirtual\Views\_ViewImports.cshtml"
using BasqueteVirtual;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\OlsenDev\Projetos\BasqueteVirtual\BasqueteVirtual\Views\_ViewImports.cshtml"
using BasqueteVirtual.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e4911da77d790d87ea1bc4f8ecdcb04fb183c40f", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"264addb3156464fdebf9c82796d557dff665e475", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\OlsenDev\Projetos\BasqueteVirtual\BasqueteVirtual\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""main-panel"">
    <!-- Navbar -->
    <nav class=""navbar navbar-expand-lg navbar-absolute navbar-transparent"">
        <div class=""container-fluid"">
            <div class=""navbar-wrapper"">
                <div class=""navbar-toggle d-inline"">
                    <button type=""button"" class=""navbar-toggler"">
                        <span class=""navbar-toggler-bar bar1""></span>
                        <span class=""navbar-toggler-bar bar2""></span>
                        <span class=""navbar-toggler-bar bar3""></span>
                    </button>
                </div>
                <a class=""navbar-brand"" href=""javascript:void(0)"">Dashboard</a>
            </div>
            <button class=""navbar-toggler"" type=""button"" data-toggle=""collapse"" data-target=""#navigation"" aria-expanded=""false"" aria-label=""Toggle navigation"">
                <span class=""navbar-toggler-bar navbar-kebab""></span>
                <span class=""navbar-toggler-bar navbar-kebab""></span>
                <span c");
            WriteLiteral(@"lass=""navbar-toggler-bar navbar-kebab""></span>
            </button>
            <div class=""collapse navbar-collapse"" id=""navigation"">
                <ul class=""navbar-nav ml-auto"">
                    <li class=""search-bar input-group"">
                        <button class=""btn btn-link"" id=""search-button"" data-toggle=""modal"" data-target=""#searchModal"">
                            <i class=""tim-icons icon-zoom-split""></i>
                            <span class=""d-lg-none d-md-block"">Search</span>
                        </button>
                    </li>
                    <li class=""dropdown nav-item"">
                        <a href=""javascript:void(0)"" class=""dropdown-toggle nav-link"" data-toggle=""dropdown"">
                            <div class=""notification d-none d-lg-block d-xl-block""></div>
                            <i class=""tim-icons icon-sound-wave""></i>
                            <p class=""d-lg-none"">
                                Notifications
                        ");
            WriteLiteral(@"    </p>
                        </a>
                        <ul class=""dropdown-menu dropdown-menu-right dropdown-navbar"">
                            <li class=""nav-link""><a href=""#"" class=""nav-item dropdown-item"">Mike John responded to your email</a></li>
                            <li class=""nav-link""><a href=""javascript:void(0)"" class=""nav-item dropdown-item"">You have 5 more tasks</a></li>
                            <li class=""nav-link""><a href=""javascript:void(0)"" class=""nav-item dropdown-item"">Your friend Michael is in town</a></li>
                            <li class=""nav-link""><a href=""javascript:void(0)"" class=""nav-item dropdown-item"">Another notification</a></li>
                            <li class=""nav-link""><a href=""javascript:void(0)"" class=""nav-item dropdown-item"">Another one</a></li>
                        </ul>
                    </li>
                    <li class=""dropdown nav-item"">
                        <a href=""#"" class=""dropdown-toggle nav-link"" data-toggle=""dropdo");
            WriteLiteral(@"wn"">
                            <div class=""photo"">
                                <img src=""../assets/img/anime3.png"" alt=""Profile Photo"">
                            </div>
                            <b class=""caret d-none d-lg-block d-xl-block""></b>
                            <p class=""d-lg-none"">
                                Log out
                            </p>
                        </a>
                        <ul class=""dropdown-menu dropdown-navbar"">
                            <li class=""nav-link""><a href=""javascript:void(0)"" class=""nav-item dropdown-item"">Profile</a></li>
                            <li class=""nav-link""><a href=""javascript:void(0)"" class=""nav-item dropdown-item"">Settings</a></li>
                            <li class=""dropdown-divider""></li>
                            <li class=""nav-link""><a href=""javascript:void(0)"" class=""nav-item dropdown-item"">Log out</a></li>
                        </ul>
                    </li>
                    <li class=""sepa");
            WriteLiteral(@"rator d-lg-none""></li>
                </ul>
            </div>
        </div>
    </nav>
    <div class=""modal modal-search fade"" id=""searchModal"" tabindex=""-1"" role=""dialog"" aria-labelledby=""searchModal"" aria-hidden=""true"">
        <div class=""modal-dialog"" role=""document"">
            <div class=""modal-content"">
                <div class=""modal-header"">
                    <input type=""text"" class=""form-control"" id=""inlineFormInputGroup"" placeholder=""SEARCH"">
                    <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                        <i class=""tim-icons icon-simple-remove""></i>
                    </button>
                </div>
            </div>
        </div>
    </div>
    <!-- End Navbar -->
    <div class=""content"">
        <div class=""row"">
            <div class=""col-12"">
                <div class=""card card-chart"">
                    <div class=""card-header "">
                        <div class=""row"">
                        ");
            WriteLiteral(@"    <div class=""col-sm-6 text-left"">
                                <h5 class=""card-category"">Total Shipments</h5>
                                <h2 class=""card-title"">Performance</h2>
                            </div>
                            <div class=""col-sm-6"">
                                <div class=""btn-group btn-group-toggle float-right"" data-toggle=""buttons"">
                                    <label class=""btn btn-sm btn-primary btn-simple active"" id=""0"">
                                        <input type=""radio"" name=""options"" checked>
                                        <span class=""d-none d-sm-block d-md-block d-lg-block d-xl-block"">Accounts</span>
                                        <span class=""d-block d-sm-none"">
                                            <i class=""tim-icons icon-single-02""></i>
                                        </span>
                                    </label>
                                    <label class=""btn btn-sm btn-primary b");
            WriteLiteral(@"tn-simple"" id=""1"">
                                        <input type=""radio"" class=""d-none d-sm-none"" name=""options"">
                                        <span class=""d-none d-sm-block d-md-block d-lg-block d-xl-block"">Purchases</span>
                                        <span class=""d-block d-sm-none"">
                                            <i class=""tim-icons icon-gift-2""></i>
                                        </span>
                                    </label>
                                    <label class=""btn btn-sm btn-primary btn-simple"" id=""2"">
                                        <input type=""radio"" class=""d-none"" name=""options"">
                                        <span class=""d-none d-sm-block d-md-block d-lg-block d-xl-block"">Sessions</span>
                                        <span class=""d-block d-sm-none"">
                                            <i class=""tim-icons icon-tap-02""></i>
                                        </span>
             ");
            WriteLiteral(@"                       </label>
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class=""card-body"">
                        <div class=""chart-area"">
                            <canvas id=""chartBig1""></canvas>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <div class=""row"">
            <div class=""col-lg-4"">
                <div class=""card card-chart"">
                    <div class=""card-header"">
                        <h5 class=""card-category"">Total Shipments</h5>
                        <h3 class=""card-title""><i class=""tim-icons icon-bell-55 text-primary""></i> 763,215</h3>
                    </div>
                    <div class=""card-body"">
                        <div class=""chart-area"">
                            <canvas id=""chartLinePurple""></canvas>
                        </div>
             ");
            WriteLiteral(@"       </div>
                </div>
            </div>
            <div class=""col-lg-4"">
                <div class=""card card-chart"">
                    <div class=""card-header"">
                        <h5 class=""card-category"">Daily Sales</h5>
                        <h3 class=""card-title""><i class=""tim-icons icon-delivery-fast text-info""></i> 3,500???</h3>
                    </div>
                    <div class=""card-body"">
                        <div class=""chart-area"">
                            <canvas id=""CountryChart""></canvas>
                        </div>
                    </div>
                </div>
            </div>
            <div class=""col-lg-4"">
                <div class=""card card-chart"">
                    <div class=""card-header"">
                        <h5 class=""card-category"">Completed Tasks</h5>
                        <h3 class=""card-title""><i class=""tim-icons icon-send text-success""></i> 12,100K</h3>
                    </div>
                    ");
            WriteLiteral(@"<div class=""card-body"">
                        <div class=""chart-area"">
                            <canvas id=""chartLineGreen""></canvas>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <div class=""row"">
            <div class=""col-lg-6 col-md-12"">
                <div class=""card card-tasks"">
                    <div class=""card-header "">
                        <h6 class=""title d-inline"">Tasks(5)</h6>
                        <p class=""card-category d-inline"">today</p>
                        <div class=""dropdown"">
                            <button type=""button"" class=""btn btn-link dropdown-toggle btn-icon"" data-toggle=""dropdown"">
                                <i class=""tim-icons icon-settings-gear-63""></i>
                            </button>
                            <div class=""dropdown-menu dropdown-menu-right"" aria-labelledby=""dropdownMenuLink"">
                                <a class=""dropdown-item"" h");
            WriteLiteral(@"ref=""#pablo"">Action</a>
                                <a class=""dropdown-item"" href=""#pablo"">Another action</a>
                                <a class=""dropdown-item"" href=""#pablo"">Something else</a>
                            </div>
                        </div>
                    </div>
                    <div class=""card-body "">
                        <div class=""table-full-width table-responsive"">
                            <table class=""table"">
                                <tbody>
                                    <tr>
                                        <td>
                                            <div class=""form-check"">
                                                <label class=""form-check-label"">
                                                    <input class=""form-check-input"" type=""checkbox""");
            BeginWriteAttribute("value", " value=\"", 11138, "\"", 11146, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                                    <span class=""form-check-sign"">
                                                        <span class=""check""></span>
                                                    </span>
                                                </label>
                                            </div>
                                        </td>
                                        <td>
                                            <p class=""title"">Update the Documentation</p>
                                            <p class=""text-muted"">Dwuamish Head, Seattle, WA 8:47 AM</p>
                                        </td>
                                        <td class=""td-actions text-right"">
                                            <button type=""button"" rel=""tooltip""");
            BeginWriteAttribute("title", " title=\"", 11982, "\"", 11990, 0);
            EndWriteAttribute();
            WriteLiteral(@" class=""btn btn-link"" data-original-title=""Edit Task"">
                                                <i class=""tim-icons icon-pencil""></i>
                                            </button>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <div class=""form-check"">
                                                <label class=""form-check-label"">
                                                    <input class=""form-check-input"" type=""checkbox""");
            BeginWriteAttribute("value", " value=\"", 12618, "\"", 12626, 0);
            EndWriteAttribute();
            BeginWriteAttribute("checked", " checked=\"", 12627, "\"", 12637, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                                    <span class=""form-check-sign"">
                                                        <span class=""check""></span>
                                                    </span>
                                                </label>
                                            </div>
                                        </td>
                                        <td>
                                            <p class=""title"">GDPR Compliance</p>
                                            <p class=""text-muted"">The GDPR is a regulation that requires businesses to protect the personal data and privacy of Europe citizens for transactions that occur within EU member states.</p>
                                        </td>
                                        <td class=""td-actions text-right"">
                                            <button type=""button"" rel=""tooltip""");
            BeginWriteAttribute("title", " title=\"", 13592, "\"", 13600, 0);
            EndWriteAttribute();
            WriteLiteral(@" class=""btn btn-link"" data-original-title=""Edit Task"">
                                                <i class=""tim-icons icon-pencil""></i>
                                            </button>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <div class=""form-check"">
                                                <label class=""form-check-label"">
                                                    <input class=""form-check-input"" type=""checkbox""");
            BeginWriteAttribute("value", " value=\"", 14228, "\"", 14236, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                                    <span class=""form-check-sign"">
                                                        <span class=""check""></span>
                                                    </span>
                                                </label>
                                            </div>
                                        </td>
                                        <td>
                                            <p class=""title"">Solve the issues</p>
                                            <p class=""text-muted"">Fifty percent of all respondents said they would be more likely to shop at a company </p>
                                        </td>
                                        <td class=""td-actions text-right"">
                                            <button type=""button"" rel=""tooltip""");
            BeginWriteAttribute("title", " title=\"", 15115, "\"", 15123, 0);
            EndWriteAttribute();
            WriteLiteral(@" class=""btn btn-link"" data-original-title=""Edit Task"">
                                                <i class=""tim-icons icon-pencil""></i>
                                            </button>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <div class=""form-check"">
                                                <label class=""form-check-label"">
                                                    <input class=""form-check-input"" type=""checkbox""");
            BeginWriteAttribute("value", " value=\"", 15751, "\"", 15759, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                                    <span class=""form-check-sign"">
                                                        <span class=""check""></span>
                                                    </span>
                                                </label>
                                            </div>
                                        </td>
                                        <td>
                                            <p class=""title"">Release v2.0.0</p>
                                            <p class=""text-muted"">Ra Ave SW, Seattle, WA 98116, SUA 11:19 AM</p>
                                        </td>
                                        <td class=""td-actions text-right"">
                                            <button type=""button"" rel=""tooltip""");
            BeginWriteAttribute("title", " title=\"", 16593, "\"", 16601, 0);
            EndWriteAttribute();
            WriteLiteral(@" class=""btn btn-link"" data-original-title=""Edit Task"">
                                                <i class=""tim-icons icon-pencil""></i>
                                            </button>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <div class=""form-check"">
                                                <label class=""form-check-label"">
                                                    <input class=""form-check-input"" type=""checkbox""");
            BeginWriteAttribute("value", " value=\"", 17229, "\"", 17237, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                                    <span class=""form-check-sign"">
                                                        <span class=""check""></span>
                                                    </span>
                                                </label>
                                            </div>
                                        </td>
                                        <td>
                                            <p class=""title"">Export the processed files</p>
                                            <p class=""text-muted"">The report also shows that consumers will not easily forgive a company once a breach exposing their personal data occurs. </p>
                                        </td>
                                        <td class=""td-actions text-right"">
                                            <button type=""button"" rel=""tooltip""");
            BeginWriteAttribute("title", " title=\"", 18163, "\"", 18171, 0);
            EndWriteAttribute();
            WriteLiteral(@" class=""btn btn-link"" data-original-title=""Edit Task"">
                                                <i class=""tim-icons icon-pencil""></i>
                                            </button>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <div class=""form-check"">
                                                <label class=""form-check-label"">
                                                    <input class=""form-check-input"" type=""checkbox""");
            BeginWriteAttribute("value", " value=\"", 18799, "\"", 18807, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                                    <span class=""form-check-sign"">
                                                        <span class=""check""></span>
                                                    </span>
                                                </label>
                                            </div>
                                        </td>
                                        <td>
                                            <p class=""title"">Arival at export process</p>
                                            <p class=""text-muted"">Capitol Hill, Seattle, WA 12:34 AM</p>
                                        </td>
                                        <td class=""td-actions text-right"">
                                            <button type=""button"" rel=""tooltip""");
            BeginWriteAttribute("title", " title=\"", 19643, "\"", 19651, 0);
            EndWriteAttribute();
            WriteLiteral(@" class=""btn btn-link"" data-original-title=""Edit Task"">
                                                <i class=""tim-icons icon-pencil""></i>
                                            </button>
                                        </td>
                                    </tr>
                                </tbody>
                            </table>
                        </div>
                    </div>
                </div>
            </div>
            <div class=""col-lg-6 col-md-12"">
                <div class=""card "">
                    <div class=""card-header"">
                        <h4 class=""card-title""> Simple Table</h4>
                    </div>
                    <div class=""card-body"">
                        <div class=""table-responsive"">
                            <table class=""table tablesorter """);
            BeginWriteAttribute("id", " id=\"", 20511, "\"", 20516, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                <thead class="" text-primary"">
                                    <tr>
                                        <th>
                                            Name
                                        </th>
                                        <th>
                                            Country
                                        </th>
                                        <th>
                                            City
                                        </th>
                                        <th class=""text-center"">
                                            Salary
                                        </th>
                                    </tr>
                                </thead>
                                <tbody>
                                    <tr>
                                        <td>
                                            Dakota Rice
                                        </td>
 ");
            WriteLiteral(@"                                       <td>
                                            Niger
                                        </td>
                                        <td>
                                            Oud-Turnhout
                                        </td>
                                        <td class=""text-center"">
                                            $36,738
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            Minerva Hooper
                                        </td>
                                        <td>
                                            Cura??ao
                                        </td>
                                        <td>
                                            Sinaai-Waas
                                        </td>
                              ");
            WriteLiteral(@"          <td class=""text-center"">
                                            $23,789
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            Sage Rodriguez
                                        </td>
                                        <td>
                                            Netherlands
                                        </td>
                                        <td>
                                            Baileux
                                        </td>
                                        <td class=""text-center"">
                                            $56,142
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            Philip Chaney");
            WriteLiteral(@"
                                        </td>
                                        <td>
                                            Korea, South
                                        </td>
                                        <td>
                                            Overland Park
                                        </td>
                                        <td class=""text-center"">
                                            $38,735
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            Doris Greene
                                        </td>
                                        <td>
                                            Malawi
                                        </td>
                                        <td>
                                            Feldkirchen in K??rnten
           ");
            WriteLiteral(@"                             </td>
                                        <td class=""text-center"">
                                            $63,542
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            Mason Porter
                                        </td>
                                        <td>
                                            Chile
                                        </td>
                                        <td>
                                            Gloucester
                                        </td>
                                        <td class=""text-center"">
                                            $78,615
                                        </td>
                                    </tr>
                                    <tr>
                                        <t");
            WriteLiteral(@"d>
                                            Jon Porter
                                        </td>
                                        <td>
                                            Portugal
                                        </td>
                                        <td>
                                            Gloucester
                                        </td>
                                        <td class=""text-center"">
                                            $98,615
                                        </td>
                                    </tr>
                                </tbody>
                            </table>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>
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
