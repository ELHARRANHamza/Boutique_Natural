#pragma checksum "D:\TPM9\Boutique_Natural\Boutique_Natural\Views\Commande_Client\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "71e4b305aaf4f68972b4b58fc7397f4734f1905c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Commande_Client_Index), @"mvc.1.0.view", @"/Views/Commande_Client/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Commande_Client/Index.cshtml", typeof(AspNetCore.Views_Commande_Client_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"71e4b305aaf4f68972b4b58fc7397f4734f1905c", @"/Views/Commande_Client/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9af4978b9c2bfca24ef48e96efe5f8573634464", @"/Views/_ViewImports.cshtml")]
    public class Views_Commande_Client_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Boutique_Natural.Models.Ligne_Commande>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-thumbnail img-fluid"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width:60px;height:60px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(60, 2230, true);
            WriteLiteral(@"
<h1 class=""h3 mb-2 text-gray-800"">Liste Du Commande Envoyer</h1>
<p class=""mb-4"">DataTables is a third party plugin that is used to generate the demo table below. For more information about DataTables, please visit the <a target=""_blank"" href=""https://datatables.net"">official DataTables documentation</a>.</p>

<!-- DataTales Example -->
<div class=""card shadow mb-4"">
    <div class=""card-header py-3"">
        <h6 class=""m-0 font-weight-bold text-primary""><i class=""fa fa-table""></i> la liste Du Commande Envoyer</h6>
    </div>
    <div class=""card-body"">
        <div class=""table-responsive"">
            <table class=""table table-bordered"" id=""dataTable"" width=""100%"" cellspacing=""0"">
                <thead>
                    <tr>
                        <td>
                            nom Compléxe
                        </td>
                        <td>
                            Date Commande
                        </td>
                        <td>
                            lib");
            WriteLiteral(@"elle
                        </td>
                        <td>
                            Quantité
                        </td>
                        <td>
                            Prix Du Paiement
                        </td>

                        <td>
                            image Produit
                        </td>
                        <th>Valider Un Achat</th>
</thead>
                <tfoot>
                    <tr>
                        <td>
                            nom Compléxe
                        </td>
                        <td>
                            Date Commande
                        </td>
                        <td>
                            libelle
                        </td>
                        <td>
                            Quntité
                        </td>
                        <td>
                            Prix Du Paiement
                        </td>

                        <td>
                     ");
            WriteLiteral("       image Produit\r\n                        </td>\r\n                        <th>Valider Un Achat</th>\r\n                    </tr>\r\n                </tfoot>\r\n                <tbody>\r\n");
            EndContext();
#line 62 "D:\TPM9\Boutique_Natural\Boutique_Natural\Views\Commande_Client\Index.cshtml"
                     foreach (var item in Model)
                    {

#line default
#line hidden
            BeginContext(2363, 84, true);
            WriteLiteral("                    <tr>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(2448, 54, false);
#line 66 "D:\TPM9\Boutique_Natural\Boutique_Natural\Views\Commande_Client\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.commande.client.nom));

#line default
#line hidden
            EndContext();
            BeginContext(2502, 31, true);
            WriteLiteral("\r\n                             ");
            EndContext();
            BeginContext(2534, 57, false);
#line 67 "D:\TPM9\Boutique_Natural\Boutique_Natural\Views\Commande_Client\Index.cshtml"
                        Write(Html.DisplayFor(modelItem => item.commande.client.prenom));

#line default
#line hidden
            EndContext();
            BeginContext(2591, 91, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(2683, 52, false);
#line 70 "D:\TPM9\Boutique_Natural\Boutique_Natural\Views\Commande_Client\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.commande.date_Cmd));

#line default
#line hidden
            EndContext();
            BeginContext(2735, 91, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(2827, 52, false);
#line 73 "D:\TPM9\Boutique_Natural\Boutique_Natural\Views\Commande_Client\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.article.Titre_Art));

#line default
#line hidden
            EndContext();
            BeginContext(2879, 91, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(2971, 38, false);
#line 76 "D:\TPM9\Boutique_Natural\Boutique_Natural\Views\Commande_Client\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.qte));

#line default
#line hidden
            EndContext();
            BeginContext(3009, 88, true);
            WriteLiteral("\r\n                        </td>\r\n                       \r\n                        <td>\r\n");
            EndContext();
#line 80 "D:\TPM9\Boutique_Natural\Boutique_Natural\Views\Commande_Client\Index.cshtml"
                              
                                float prix = float.Parse(item.article.prix_unitaire.ToString());
                                int qte = item.qte;
                                float total = prix * qte;
                            

#line default
#line hidden
            BeginContext(3370, 28, true);
            WriteLiteral("                            ");
            EndContext();
            BeginContext(3399, 5, false);
#line 85 "D:\TPM9\Boutique_Natural\Boutique_Natural\Views\Commande_Client\Index.cshtml"
                       Write(total);

#line default
#line hidden
            EndContext();
            BeginContext(3404, 94, true);
            WriteLiteral(" DH\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(3498, 109, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "aa93bac4201a4cce95c6e793a941bd05", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 3508, "~/Image_Article/", 3508, 16, true);
#line 88 "D:\TPM9\Boutique_Natural\Boutique_Natural\Views\Commande_Client\Index.cshtml"
AddHtmlAttributeValue("", 3524, item.article.img1, 3524, 18, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3607, 124, true);
            WriteLiteral("\r\n                        </td>\r\n\r\n                        <td style=\"text-align:center;\">\r\n\r\n                            <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 3731, "\"", 3768, 2);
            WriteAttributeValue("", 3738, "/Commande_Client/Edit/", 3738, 22, true);
#line 93 "D:\TPM9\Boutique_Natural\Boutique_Natural\Views\Commande_Client\Index.cshtml"
WriteAttributeValue("", 3760, item.id, 3760, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3769, 98, true);
            WriteLiteral(" class=\"btn btn-sm btn-success\"><i class=\"fas fa-check\"></i></a> |\r\n                            <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 3867, "\"", 3906, 2);
            WriteAttributeValue("", 3874, "/Commande_Client/Delete/", 3874, 24, true);
#line 94 "D:\TPM9\Boutique_Natural\Boutique_Natural\Views\Commande_Client\Index.cshtml"
WriteAttributeValue("", 3898, item.id, 3898, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3907, 125, true);
            WriteLiteral(" class=\"btn btn-sm btn-danger\"><i class=\"fas fa-trash\"></i></a>\r\n\r\n                        </td>\r\n                    </tr>\r\n");
            EndContext();
#line 98 "D:\TPM9\Boutique_Natural\Boutique_Natural\Views\Commande_Client\Index.cshtml"
                    }

#line default
#line hidden
            BeginContext(4055, 84, true);
            WriteLiteral("                </tbody>\r\n            </table>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
            EndContext();
            DefineSection("Admin", async() => {
                BeginContext(4154, 1, true);
                WriteLiteral(" ");
                EndContext();
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Boutique_Natural.Models.Ligne_Commande>> Html { get; private set; }
    }
}
#pragma warning restore 1591