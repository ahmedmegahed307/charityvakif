#pragma checksum "C:\Users\dell\source\repos\zemzem\zemzem\Views\Home\galeri.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d74997d09a1db1d17c7aefcf913db28aa8f0704a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_galeri), @"mvc.1.0.view", @"/Views/Home/galeri.cshtml")]
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
#line 1 "C:\Users\dell\source\repos\zemzem\zemzem\Views\_ViewImports.cshtml"
using zemzem;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\dell\source\repos\zemzem\zemzem\Views\_ViewImports.cshtml"
using zemzem.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\dell\source\repos\zemzem\zemzem\Views\_ViewImports.cshtml"
using Domains;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d74997d09a1db1d17c7aefcf913db28aa8f0704a", @"/Views/Home/galeri.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e2e20d0c90cfb12ab54b98416cb6bf06ecc2b89b", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_galeri : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<TbProductImages>>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"en\">\r\n\r\n\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d74997d09a1db1d17c7aefcf913db28aa8f0704a3253", async() => {
                WriteLiteral(@"
    <!-- section start -->
    <section class=""section-b-space ratio_asos"">
        <div class=""collection-wrapper"">
            <div class=""container"">
                <div class=""row"">
                    <div class=""collection-content col"">
                        <div class=""page-main-content"">
                            <div class=""row"">
                                <div class=""col-sm-12"">
                                    
                                    <div class=""collection-product-wrapper"">
                                        <div class=""product-wrapper-grid"">
                                            <div class=""row margin-res"">
");
#nullable restore
#line 21 "C:\Users\dell\source\repos\zemzem\zemzem\Views\Home\galeri.cshtml"
                                                 foreach (var item in Model.OrderByDescending(a=>a.Product.ImageDate))
                                                {

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                                                <div class=""col-xl-3 col-6 col-grid-box"">
                                                    <div class=""product-box"">
                                                        <div class=""img-wrapper"">
                                                            <div class=""front"">
                                                                <img");
                BeginWriteAttribute("src", " src=\"", 1329, "\"", 1380, 1);
#nullable restore
#line 27 "C:\Users\dell\source\repos\zemzem\zemzem\Views\Home\galeri.cshtml"
WriteAttributeValue("", 1335, string.Format("/Uploads/{0}",item.ImageName), 1335, 45, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"img-fluid blur-up lazyload bg-img\"");
                BeginWriteAttribute("alt", " alt=\"", 1423, "\"", 1429, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                                                            </div>
                                                            
                                                        </div>
                                                       
                                                    </div>
                                                </div>
");
#nullable restore
#line 34 "C:\Users\dell\source\repos\zemzem\zemzem\Views\Home\galeri.cshtml"
                                                }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                                            </div>
                                        </div>
                                       
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </section>
    <!-- section End -->
   
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<TbProductImages>> Html { get; private set; }
    }
}
#pragma warning restore 1591
