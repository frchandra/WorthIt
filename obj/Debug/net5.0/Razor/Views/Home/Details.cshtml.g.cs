#pragma checksum "D:\Proyek\Programs\Program\oop_kuliah\WorthIt\Views\Home\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "43a2bcbfa598069b3de39ad72c66f9f1c985e488"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Details), @"mvc.1.0.view", @"/Views/Home/Details.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"43a2bcbfa598069b3de39ad72c66f9f1c985e488", @"/Views/Home/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e8eae7ba5959c8e9420b26ab615e369d4da71257", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WorthIt.Models.ViewModels.DetailsVM>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
    <style>
        
        #test html {
            display: grid;
            min-height: 100%;
        }

        #test body {
            display: grid;
            background: #eeeeee;
            font-family: font, sans-serif;
            text-transform: uppercase;
            min-height: 100% !important;
            height: auto;
        }

        #test .card {
            position: relative;
            height: 100%;
            min-height: 100% !important;
            margin-bottom: 30px;
            border-radius: 20px;
            -webkit-box-shadow: 5px 5px 5px 0px rgba(82, 63, 105, 0.1);
        }

        #test .container {
            width: 840px;
            background: white;
            
            border-radius: 10px;
            
        }

        #test p {
            font-size: 0.8em;
            color: #4E4E4E;
            letter-spacing: 1px;
        }


        #test h1 {
            font-size: 1.8em;
            
            margin-to");
            WriteLiteral(@"p: -5px;
            color: #e0d145;
        }

        #test h3 {
            color: rgb(196, 156, 104);
            margin-top: -5px;
        }



        #test img {
            width: auto;
            border-radius: 10px;
            object-fit: cover;
            margin-top: 25px;
            height: 400px;
            margin-left:60px;
        }





        #test .product {
            top: 4%;
            position: relative;
            width: 100%;
            height: 100%;
            margin-bottom: 100px;
        }

        #test .desc {
            text-transform: none;
            letter-spacing: 0;
            margin-bottom: 17px;
            color: dark;
            font-size: 1.em;
            line-height: 1.6em;
            margin-right: 25px;
            text-align: justify;
            color: #a8a8a8;
        }

        #test button {
            background: darken(light, 10%);
            padding: 10px;
            display: inline-block;
   ");
            WriteLiteral(@"         outline: 0;
            border: 0;
            margin: -1px;
            border-radius: 2px;
            text-transform: uppercase;
            letter-spacing: 1px;
            color: white;
            background-color: #4f6370;
            cursor: pointer;
            position:relative;
            margin-bottom:-100px
        }

        #test button:hover {
            background: #73bad3;
            transition: all .4s ease-in-out;
        }
    </style>

<div");
            BeginWriteAttribute("class", " class=\"", 2589, "\"", 2597, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "43a2bcbfa598069b3de39ad72c66f9f1c985e4886401", async() => {
                WriteLiteral("\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "43a2bcbfa598069b3de39ad72c66f9f1c985e4886667", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#nullable restore
#line 115 "D:\Proyek\Programs\Program\oop_kuliah\WorthIt\Views\Home\Details.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => Model.Product.Id);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("hidden", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n        <div class=\"container\" id=\"test\">\r\n            <div class=\"card\">\r\n\r\n                <div class=\"row\">\r\n                    <div class=\"col-12 col-lg-6 \">\r\n                        <div class=\"images\">\r\n                            <img");
                BeginWriteAttribute("src", " src=\"", 2923, "\"", 2962, 2);
#nullable restore
#line 122 "D:\Proyek\Programs\Program\oop_kuliah\WorthIt\Views\Home\Details.cshtml"
WriteAttributeValue("", 2929, WC.ImagePath, 2929, 13, false);

#line default
#line hidden
#nullable disable
#nullable restore
#line 122 "D:\Proyek\Programs\Program\oop_kuliah\WorthIt\Views\Home\Details.cshtml"
WriteAttributeValue("", 2942, Model.Product.Image, 2942, 20, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"img-fluid\" alt=\"Responsive image\" />\r\n                        </div>\r\n                    </div>\r\n                    <div class=\"col-12 col-lg-6\">\r\n                        <div class=\"product\">\r\n                            <p>");
#nullable restore
#line 127 "D:\Proyek\Programs\Program\oop_kuliah\WorthIt\Views\Home\Details.cshtml"
                          Write(Model.Product.Category.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n                            <h1>");
#nullable restore
#line 128 "D:\Proyek\Programs\Program\oop_kuliah\WorthIt\Views\Home\Details.cshtml"
                           Write(Model.Product.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h1>\r\n                            <h3>Rp@Model.Product.Price</h3>\r\n                            <div class=\"desc\">\r\n                                <p class=\"text-secondary\">Short Description : ");
#nullable restore
#line 131 "D:\Proyek\Programs\Program\oop_kuliah\WorthIt\Views\Home\Details.cshtml"
                                                                         Write(Html.Raw(Model.Product.ShortDesc));

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n                                <p class=\"text-secondary\">Material : ");
#nullable restore
#line 132 "D:\Proyek\Programs\Program\oop_kuliah\WorthIt\Views\Home\Details.cshtml"
                                                                Write(Html.Raw(Model.Product.Material));

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n                                <p class=\"text-secondary\">Display Size : ");
#nullable restore
#line 133 "D:\Proyek\Programs\Program\oop_kuliah\WorthIt\Views\Home\Details.cshtml"
                                                                    Write(Html.Raw(Model.Product.DisplaySize));

#line default
#line hidden
#nullable disable
                WriteLiteral(" inch</p>\r\n                                <p class=\"text-secondary\">Display Type : ");
#nullable restore
#line 134 "D:\Proyek\Programs\Program\oop_kuliah\WorthIt\Views\Home\Details.cshtml"
                                                                    Write(Html.Raw(Model.Product.DisplayType));

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n                                <p class=\"text-secondary\">OS : ");
#nullable restore
#line 135 "D:\Proyek\Programs\Program\oop_kuliah\WorthIt\Views\Home\Details.cshtml"
                                                          Write(Html.Raw(Model.Product.OS));

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n                                <p class=\"text-secondary\">CPU : ");
#nullable restore
#line 136 "D:\Proyek\Programs\Program\oop_kuliah\WorthIt\Views\Home\Details.cshtml"
                                                           Write(Html.Raw(Model.Product.CPU));

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n                                <p class=\"text-secondary\">Benchmark : ");
#nullable restore
#line 137 "D:\Proyek\Programs\Program\oop_kuliah\WorthIt\Views\Home\Details.cshtml"
                                                                 Write(Html.Raw(Model.Product.Benchmark));

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n                                <p class=\"text-secondary\">RAM : ");
#nullable restore
#line 138 "D:\Proyek\Programs\Program\oop_kuliah\WorthIt\Views\Home\Details.cshtml"
                                                           Write(Html.Raw(Model.Product.RAM));

#line default
#line hidden
#nullable disable
                WriteLiteral(" Gigabyte</p>\r\n                                <p class=\"text-secondary\">Storage : ");
#nullable restore
#line 139 "D:\Proyek\Programs\Program\oop_kuliah\WorthIt\Views\Home\Details.cshtml"
                                                               Write(Html.Raw(Model.Product.Storage));

#line default
#line hidden
#nullable disable
                WriteLiteral(" Gigabyte</p>\r\n                                <p class=\"text-secondary\">Main Camera : ");
#nullable restore
#line 140 "D:\Proyek\Programs\Program\oop_kuliah\WorthIt\Views\Home\Details.cshtml"
                                                                   Write(Html.Raw(Model.Product.MainCamera));

#line default
#line hidden
#nullable disable
                WriteLiteral(" Mega Pixel</p>\r\n                                <p class=\"text-secondary\">Front Camera : ");
#nullable restore
#line 141 "D:\Proyek\Programs\Program\oop_kuliah\WorthIt\Views\Home\Details.cshtml"
                                                                    Write(Html.Raw(Model.Product.FrontCamera));

#line default
#line hidden
#nullable disable
                WriteLiteral(" Mega Pixel</p>\r\n                                <p class=\"text-secondary\">Camera Review : ");
#nullable restore
#line 142 "D:\Proyek\Programs\Program\oop_kuliah\WorthIt\Views\Home\Details.cshtml"
                                                                     Write(Html.Raw(Model.Product.CameraFeature));

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n                                <p class=\"text-secondary\">Battery Capacity : ");
#nullable restore
#line 143 "D:\Proyek\Programs\Program\oop_kuliah\WorthIt\Views\Home\Details.cshtml"
                                                                        Write(Html.Raw(Model.Product.BatteryCapacity));

#line default
#line hidden
#nullable disable
                WriteLiteral(" mAH</p>\r\n");
#nullable restore
#line 144 "D:\Proyek\Programs\Program\oop_kuliah\WorthIt\Views\Home\Details.cshtml"
                                  
                                    double chargingSpeed = Model.Product.ChargingSpeed;
                                    if (Model.Product.ChargingSpeed / 1000 >= 1)
                                        chargingSpeed = Model.Product.ChargingSpeed / 1000;
                                    else if (Model.Product.ChargingSpeed / 100 >= 1)
                                        chargingSpeed = Model.Product.ChargingSpeed / 100;
                                    else if (Model.Product.ChargingSpeed / 10 >= 1)
                                        chargingSpeed = Model.Product.ChargingSpeed / 10;
                                

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                <p class=\"text-secondary\">Charging Speed : 0% to 100% in ");
#nullable restore
#line 154 "D:\Proyek\Programs\Program\oop_kuliah\WorthIt\Views\Home\Details.cshtml"
                                                                                    Write(chargingSpeed);

#line default
#line hidden
#nullable disable
                WriteLiteral(" hour</p>\r\n                                <p class=\"text-secondary\">Audio Jack : ");
#nullable restore
#line 155 "D:\Proyek\Programs\Program\oop_kuliah\WorthIt\Views\Home\Details.cshtml"
                                                                  Write(Html.Raw(Model.Product.AudioJack));

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n                                <p class=\"text-secondary\">Wireless Charging : ");
#nullable restore
#line 156 "D:\Proyek\Programs\Program\oop_kuliah\WorthIt\Views\Home\Details.cshtml"
                                                                         Write(Html.Raw(Model.Product.WirelesCharging));

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n                                <p class=\"text-secondary\">Overall Review: ");
#nullable restore
#line 157 "D:\Proyek\Programs\Program\oop_kuliah\WorthIt\Views\Home\Details.cshtml"
                                                                     Write(Html.Raw(Model.Product.Description));

#line default
#line hidden
#nullable disable
                WriteLiteral(@" </p>
                                <div class=""buttons"">
                                    <button class=""like""><span>⎗</span></button>
                                    <button class=""add"">Add to Comparison</button>

                                </div>
                            </div>
                            
                        </div>
                    </div>
                </div>




            </div>

        </div>
");
                WriteLiteral("    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WorthIt.Models.ViewModels.DetailsVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
