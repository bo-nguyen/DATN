#pragma checksum "D:\DATN\Source\Source\WebBanHang\Views\Home\Index.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "195ceb22cc4dbd25f6ba90b6e7abc15728d39044849aab66405307b5d6095062"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCoreGeneratedDocument.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
namespace AspNetCoreGeneratedDocument
{
    #line default
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "D:\DATN\Source\Source\WebBanHang\Views\_ViewImports.cshtml"
using WebBanHang

#nullable disable
    ;
#nullable restore
#line 2 "D:\DATN\Source\Source\WebBanHang\Views\_ViewImports.cshtml"
using WebBanHang.Models

#line default
#line hidden
#nullable disable
    ;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"195ceb22cc4dbd25f6ba90b6e7abc15728d39044849aab66405307b5d6095062", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"20e31815b6ab70dd67ecbb34d4a392b79e2a67146353b6f597a36821de7a03b6", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    internal sealed class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<
#nullable restore
#line 1 "D:\DATN\Source\Source\WebBanHang\Views\Home\Index.cshtml"
       WebBanHang.ModelViews.HomeViewVM

#line default
#line hidden
#nullable disable
    >
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/banners/banner1.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("slide-inner bg-height"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width:100%;height:60vh;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("70px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/banners/icon1.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Shipping Icon"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/banners/icon3.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Product Icon"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\DATN\Source\Source\WebBanHang\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "HN Store";
    Layout = "~/Views/Shared/_Layout.cshtml";
    List<SanPham> allProduct = ViewBag.AllProducts;

#line default
#line hidden
#nullable disable

            WriteLiteral("\n<!-- Begin Slider Area -->\n<!-- Begin Slider Area -->\n<!-- Begin Slider Area -->\n<div class=\"slider-area\">\n\n    <!-- Main Slider -->\n    <div class=\"swiper-container main-slider-2 swiper-arrow with-bg_white\">\n        <div class=\"swiper-wrapper\">\n");
            WriteLiteral("\n            <div class=\"swiper-slide animation-style-01\">\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "195ceb22cc4dbd25f6ba90b6e7abc15728d39044849aab66405307b5d60950626914", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
            </div>
        </div>
        <!-- Add Pagination -->
        <div class=""swiper-pagination with-bg d-md-none""></div>

        <!-- Add Arrows -->
        <div class=""swiper-button-next""></div>
        <div class=""swiper-button-prev""></div>
    </div>

</div>
<!-- Slider Area End Here -->

<!-- Begin Shipping Area -->
<div class=""shipping-area section-space-top-100"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-lg-4 col-md-6"">
                <div class=""shipping-item"">
                    <div class=""shipping-img"">
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "195ceb22cc4dbd25f6ba90b6e7abc15728d39044849aab66405307b5d60950628745", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                    </div>
                    <div class=""shipping-content"">
                        <h5 class=""title"">Giao hàng tận nhà</h5>
                        <p class=""short-desc mb-0"">Miễn phí ship đơn từ 999k</p>
                    </div>
                </div>
            </div>
            <div class=""col-lg-4 col-md-6 pt-6 pt-md-0"">
                <div class=""shipping-item"">
                    <div class=""shipping-img"">
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "195ceb22cc4dbd25f6ba90b6e7abc15728d39044849aab66405307b5d609506210441", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                    </div>
                    <div class=""shipping-content"">
                        <h5 class=""title"">Giá quá tốt</h5>
                        <p class=""short-desc mb-0"">Mức giá cực kỳ ưu đãi</p>
                    </div>
                </div>
            </div>
            <div class=""col-lg-4 col-md-6 pt-6 pt-lg-0"">
                <div class=""shipping-item"">
                    <div class=""shipping-img"">
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "195ceb22cc4dbd25f6ba90b6e7abc15728d39044849aab66405307b5d609506212128", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                    </div>
                    <div class=""shipping-content"">
                        <h5 class=""title"">Hàng chính hãng</h5>
                        <p class=""short-desc mb-0"">Cam kết hàng 100% chính hãng</p>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>
<!-- Shipping Area End Here -->

<!-- Begin Product Area -->
<div class=""product-area section-space-top-100"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-lg-12"">
                <ul class=""nav product-tab-nav pb-10"" id=""myTab"" role=""tablist"">
                    <li class=""nav-item"" role=""presentation"">
                        <a class=""active"" id=""all-items-tab"" data-bs-toggle=""tab"" href=""#all-items"" role=""tab"" aria-controls=""all-items"" aria-selected=""true"">
                            <div class=""product-tab-icon"">
                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "195ceb22cc4dbd25f6ba90b6e7abc15728d39044849aab66405307b5d609506214308", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                            </div>\n                            Tất cả\n                        </a>\n                    </li>\n");
#nullable restore
#line 89 "D:\DATN\Source\Source\WebBanHang\Views\Home\Index.cshtml"
                     foreach(var item in Model.Products)
                    {

#line default
#line hidden
#nullable disable

            WriteLiteral("                        <li class=\"nav-item\" role=\"presentation\">\n                            <a id=\"fresh-fruits-tab\" data-bs-toggle=\"tab\"");
            BeginWriteAttribute("href", " href=\"", 3777, "\"", 3808, 2);
            WriteAttributeValue("", 3784, "#m-", 3784, 3, true);
            WriteAttributeValue("", 3787, 
#nullable restore
#line 92 "D:\DATN\Source\Source\WebBanHang\Views\Home\Index.cshtml"
                                                                                    item.category.MaLoai

#line default
#line hidden
#nullable disable
            , 3787, 21, false);
            EndWriteAttribute();
            WriteLiteral(" role=\"tab\"");
            BeginWriteAttribute("aria-controls", " aria-controls=\"", 3820, "\"", 3857, 1);
            WriteAttributeValue("", 3836, 
#nullable restore
#line 92 "D:\DATN\Source\Source\WebBanHang\Views\Home\Index.cshtml"
                                                                                                                                     item.category.MaLoai

#line default
#line hidden
#nullable disable
            , 3836, 21, false);
            EndWriteAttribute();
            WriteLiteral(" aria-selected=\"false\">\n                            <div class=\"product-tab-icon\">\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "195ceb22cc4dbd25f6ba90b6e7abc15728d39044849aab66405307b5d609506217247", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                            </div>\n                            ");
            Write(
#nullable restore
#line 96 "D:\DATN\Source\Source\WebBanHang\Views\Home\Index.cshtml"
                             item.category.TenLoai

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\n                        </a>\n                    </li>\n");
#nullable restore
#line 99 "D:\DATN\Source\Source\WebBanHang\Views\Home\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable

            WriteLiteral("                </ul>\n\n                <div class=\"tab-content\" id=\"myTabContent\">\n                    <div class=\"tab-pane fade show active\" id=\"all-items\" role=\"tabpanel\" aria-labelledby=\"all-items-tab\">\n                        ");
            Write(
#nullable restore
#line 104 "D:\DATN\Source\Source\WebBanHang\Views\Home\Index.cshtml"
                         await Html.PartialAsync("_ListProductPartialView.cshtml", allProduct)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\n                    </div>\n");
#nullable restore
#line 106 "D:\DATN\Source\Source\WebBanHang\Views\Home\Index.cshtml"
                     foreach(var item in Model.Products)
                    {

#line default
#line hidden
#nullable disable

            WriteLiteral("                        <div class=\"tab-pane fade\"");
            BeginWriteAttribute("id", " id=\"", 4671, "\"", 4699, 2);
            WriteAttributeValue("", 4676, "m-", 4676, 2, true);
            WriteAttributeValue("", 4678, 
#nullable restore
#line 108 "D:\DATN\Source\Source\WebBanHang\Views\Home\Index.cshtml"
                                                          item.category.MaLoai

#line default
#line hidden
#nullable disable
            , 4678, 21, false);
            EndWriteAttribute();
            WriteLiteral(" role=\"tabpanel\"");
            BeginWriteAttribute("aria-labelledby", " aria-labelledby=\"", 4716, "\"", 4759, 2);
            WriteAttributeValue("", 4734, 
#nullable restore
#line 108 "D:\DATN\Source\Source\WebBanHang\Views\Home\Index.cshtml"
                                                                                                                  item.category.MaLoai

#line default
#line hidden
#nullable disable
            , 4734, 21, false);
            WriteAttributeValue("", 4755, "-tab", 4755, 4, true);
            EndWriteAttribute();
            WriteLiteral(">\n                            ");
            Write(
#nullable restore
#line 109 "D:\DATN\Source\Source\WebBanHang\Views\Home\Index.cshtml"
                             await Html.PartialAsync("_ListProductPartialView.cshtml", item.lsProducts)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\n                        </div>\n");
#nullable restore
#line 111 "D:\DATN\Source\Source\WebBanHang\Views\Home\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable

            WriteLiteral("\n                </div>\n            </div>\n        </div>\n    </div>\n</div>\n<!-- Product Area End Here -->\n\n<!-- Begin Blog Area -->\n<div class=\"blog-area section-space-y-axis-100\">\n</div>\n<!-- Blog Area End Here -->\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebBanHang.ModelViews.HomeViewVM> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
