#pragma checksum "D:\TPM9\Boutique_Natural\Boutique_Natural\Views\Commande_Client\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "48743d023eb8091e0c767f044cee56cbd5bf5396"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Commande_Client_Delete), @"mvc.1.0.view", @"/Views/Commande_Client/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Commande_Client/Delete.cshtml", typeof(AspNetCore.Views_Commande_Client_Delete))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"48743d023eb8091e0c767f044cee56cbd5bf5396", @"/Views/Commande_Client/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9af4978b9c2bfca24ef48e96efe5f8573634464", @"/Views/_ViewImports.cshtml")]
    public class Views_Commande_Client_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Boutique_Natural.ViewModel.Ligne_Cmd_ViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-warning btn-icon-split"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-fluid px-3 px-sm-4 mt-3 mb-4"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width: 25rem;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Admin/undraw_posting_photo.svg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(57, 361, true);
            WriteLiteral(@"
<hr />
<div class=""row"">
    <div class=""col-lg-6"">
        <div class=""card shadow mb-4"">
                <a href=""#collapseCardExample"" class=""d-block card-header py-3"" data-toggle=""collapse"" role=""button"" aria-expanded=""true"" aria-controls=""collapseCardExample"">
                    <h6 class=""m-0 font-weight-bold text-primary"">Commande D'Un Article ");
            EndContext();
            BeginContext(419, 23, false);
#line 9 "D:\TPM9\Boutique_Natural\Boutique_Natural\Views\Commande_Client\Delete.cshtml"
                                                                                   Write(Model.article.Titre_Art);

#line default
#line hidden
            EndContext();
            BeginContext(442, 34, true);
            WriteLiteral(" a <i class=\"fa fa-calendar\"></i> ");
            EndContext();
            BeginContext(477, 18, false);
#line 9 "D:\TPM9\Boutique_Natural\Boutique_Natural\Views\Commande_Client\Delete.cshtml"
                                                                                                                                             Write(Model.cmd.date_Cmd);

#line default
#line hidden
            EndContext();
            BeginContext(495, 185, true);
            WriteLiteral("</h6>\r\n                </a>\r\n\r\n                <div class=\"collapse show\" id=\"collapseCardExample\">\r\n                    <div class=\"card-body\">\r\n                        Nom :  <strong>");
            EndContext();
            BeginContext(681, 13, false);
#line 14 "D:\TPM9\Boutique_Natural\Boutique_Natural\Views\Commande_Client\Delete.cshtml"
                                  Write(Model.clt.nom);

#line default
#line hidden
            EndContext();
            BeginContext(694, 85, true);
            WriteLiteral("</strong>\r\n                        <br />\r\n                        Prenom :  <strong>");
            EndContext();
            BeginContext(780, 16, false);
#line 16 "D:\TPM9\Boutique_Natural\Boutique_Natural\Views\Commande_Client\Delete.cshtml"
                                     Write(Model.clt.prenom);

#line default
#line hidden
            EndContext();
            BeginContext(796, 84, true);
            WriteLiteral("</strong>\r\n                        <br />\r\n                        Ville :  <strong>");
            EndContext();
            BeginContext(881, 29, false);
#line 18 "D:\TPM9\Boutique_Natural\Boutique_Natural\Views\Commande_Client\Delete.cshtml"
                                    Write(Model.clt.GetVille.ville_Name);

#line default
#line hidden
            EndContext();
            BeginContext(910, 83, true);
            WriteLiteral("</strong>\r\n                        <br />\r\n                        Tele :  <strong>");
            EndContext();
            BeginContext(994, 14, false);
#line 20 "D:\TPM9\Boutique_Natural\Boutique_Natural\Views\Commande_Client\Delete.cshtml"
                                   Write(Model.clt.Tele);

#line default
#line hidden
            EndContext();
            BeginContext(1008, 86, true);
            WriteLiteral("</strong>\r\n                        <br />\r\n                        adresse :  <strong>");
            EndContext();
            BeginContext(1095, 17, false);
#line 22 "D:\TPM9\Boutique_Natural\Boutique_Natural\Views\Commande_Client\Delete.cshtml"
                                      Write(Model.clt.Adresse);

#line default
#line hidden
            EndContext();
            BeginContext(1112, 84, true);
            WriteLiteral("</strong>\r\n                        <br />\r\n                        email :  <strong>");
            EndContext();
            BeginContext(1197, 15, false);
#line 24 "D:\TPM9\Boutique_Natural\Boutique_Natural\Views\Commande_Client\Delete.cshtml"
                                    Write(Model.clt.email);

#line default
#line hidden
            EndContext();
            BeginContext(1212, 91, true);
            WriteLiteral("</strong>\r\n                        <br />\r\n                    </div>\r\n                    ");
            EndContext();
            BeginContext(1303, 912, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6912ed3e9d684898af42c0e0c0aca5b9", async() => {
                BeginContext(1329, 474, true);
                WriteLiteral(@"
                        <div class=""form-group"" style=""margin-left:10px"">
                            <button type=""submit"" class=""btn btn-danger btn-icon-split"">
                                <span class=""icon text-white-50"">
                                    <i class=""fas fa-trash""></i>
                                </span>
                                <span class=""text"">Delete</span>
                            </button>
                            ");
                EndContext();
                BeginContext(1803, 351, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dc6137230f814dc0aebebdddb8d83f37", async() => {
                    BeginContext(1864, 286, true);
                    WriteLiteral(@"
                                <span class=""icon text-white-50"">
                                    <i class=""fas fa-exclamation-triangle""></i>
                                </span>
                                <span class=""text"">Annuler</span>
                            ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2154, 54, true);
                WriteLiteral("\r\n                        </div>\r\n                    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2215, 377, true);
            WriteLiteral(@"
                </div>     
        </div>


    </div>
    <div class=""col-lg-6"">
        <div class=""card shadow mb-4"">
            <div class=""card-header py-3"">
                <h6 class=""m-0 font-weight-bold text-primary"">Illustrations</h6>
            </div>
            <div class=""card-body"">
                <div class=""text-center"">
                    ");
            EndContext();
            BeginContext(2592, 114, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "26ad45acc13248308e956f631fe0157f", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2706, 475, true);
            WriteLiteral(@"
                </div>
                <p>Add some quality, svg illustrations to your project courtesy of <a target=""_blank"" rel=""nofollow"" href=""https://undraw.co/"">unDraw</a>, a constantly updated collection of beautiful svg images that you can use completely free and without attribution!</p>
                <a target=""_blank"" rel=""nofollow"" href=""https://undraw.co/"">Browse Illustrations on unDraw &rarr;</a>
            </div>
        </div>
    </div>
</div>
");
            EndContext();
            DefineSection("Admin", async() => {
                BeginContext(3196, 1, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Boutique_Natural.ViewModel.Ligne_Cmd_ViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
