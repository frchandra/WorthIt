#pragma checksum "D:\Proyek\Programs\Program\oop_kuliah\WorthIt\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "935ae35e5bebea40648e213fe6401ee7f472ff97"
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
#line 1 "D:\Proyek\Programs\Program\oop_kuliah\WorthIt\Views\_ViewImports.cshtml"
using WorthIt;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Proyek\Programs\Program\oop_kuliah\WorthIt\Views\_ViewImports.cshtml"
using WorthIt.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"935ae35e5bebea40648e213fe6401ee7f472ff97", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e8eae7ba5959c8e9420b26ab615e369d4da71257", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WorthIt.Models.ViewModels.HomeVM>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_IndividualProductCard", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<style>


    .popup-btn a {
        top: 600px;
        position: fixed;
        right: -57px;
        z-index: 1000;
        transform: rotate(-90deg);
        background-color: red;
        padding: 10px 20px 35px;
        height: 0px;
        background-color: #343a40;
        color: #fff;
    }

        .popup-btn a:hover {
            text-decoration: none;
            color: #fff;
            background-color: #ad7d52;
        }
</style>


<div class=""container"">
    <div class=""text-center"">
        <button class=""btn btn-dark filter-button"" data-filter=""all"">All</button>
");
#nullable restore
#line 30 "D:\Proyek\Programs\Program\oop_kuliah\WorthIt\Views\Home\Index.cshtml"
         foreach (var obj in Model.Categories)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <button class=\"btn btn-outline-secondary filter-button \" data-filter=\"");
#nullable restore
#line 32 "D:\Proyek\Programs\Program\oop_kuliah\WorthIt\Views\Home\Index.cshtml"
                                                                             Write(obj.Name.ToLower().Replace(' ','_'));

#line default
#line hidden
#nullable disable
            WriteLiteral("\">\r\n                ");
#nullable restore
#line 33 "D:\Proyek\Programs\Program\oop_kuliah\WorthIt\Views\Home\Index.cshtml"
           Write(obj.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </button>\r\n");
#nullable restore
#line 35 "D:\Proyek\Programs\Program\oop_kuliah\WorthIt\Views\Home\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <input id=\"myInput\" type=\"text\" placeholder=\"Search..\">\r\n\r\n");
            WriteLiteral("\r\n\r\n    </div>\r\n    <br />\r\n    <div class=\"row\">\r\n");
#nullable restore
#line 47 "D:\Proyek\Programs\Program\oop_kuliah\WorthIt\Views\Home\Index.cshtml"
         foreach (var prod in Model.Products)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "935ae35e5bebea40648e213fe6401ee7f472ff975503", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 49 "D:\Proyek\Programs\Program\oop_kuliah\WorthIt\Views\Home\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = prod;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("model", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 50 "D:\Proyek\Programs\Program\oop_kuliah\WorthIt\Views\Home\Index.cshtml"
            //display all product
        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    </div>
</div>

<div class=""container-fluid"">
    <div class=""row"">
        <div class=""col-lg-12 col-sm-12 col-12"">
            <div class=""popup-btn"" data-toggle=""modal"" data-target=""#aboutModal"">
                <a href=""#id01"">About This Page</a>
            </div>
        </div>
    </div>
</div>
<!-- Modal -->
<div class=""modal fade"" id=""aboutModal"" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">
    <div class=""modal-dialog"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"" id=""exampleModalLabel"">About This Page</h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            <div class=""modal-body"">
                <p style=""text-align:justify"">
                    Worth it adalah platform yang menyediakan saran");
            WriteLiteral(@"a untuk melakukan pembandingan pada produk elektronik.
                    Dengan data yang akurat serta presentasi yang menarik dan mudah dipahami, diharapkan dapat membantu
                    user dalam memilih smarthpone yang ingin mereka miliki. Saat ini platform kami mencakup produk-produk smartphone dan dimungkinkan pada masa yang akan datang
                    dapat memperluas cakupan kategori.
                </p>
                <br />
                *Aplikasi berbasis web ini dibuat dalam rangka memenuhi tugas praktikum Pemrograman Berorientasi Objek Universitas Gadjah Mada.
                <br /><br />

                Meet the team: <br />
                M Rifat Bagus A (muhammadrifatba@mail.ugm.ac.id)<br />
                Nismara Chandra H (nismara.chandra@mail.ugm.ac.id)
            </div>
            <div class=""modal-footer"">
                <button type=""button"" class=""btn btn-info"" data-dismiss=""modal"">Close</button>                
            </div>
        </div>
   ");
            WriteLiteral(" </div>\r\n</div>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n");
                WriteLiteral(@"    <script>
        $(document).ready(function () {
            $("".filter-button"").click(function () {
                var value = $(this).attr('data-filter');
                if (value == ""all"") {
                    $('.filter').show('1000');
                }
                else {
                    $("".filter"").not('.' + value).hide('3000');
                    $('.filter').filter('.' + value).show('3000');
                }
            });
        });


        $(document).ready(function () {
            $(""input"").on(""keyup"", function () {
                var key = $(this).val().replace(/\s+/g, '_').toLocaleLowerCase();
                console.log(key);
                if (key == """") {
                    $('.filter').show('1000');
                }
                else {
                    $('.filter').filter('[class*=' + key + ']').show('3000');
                    $("".filter"").not('[class*=' + key + ']').hide('3000');

                }
            });
        });
  ");
                WriteLiteral("  </script>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WorthIt.Models.ViewModels.HomeVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
