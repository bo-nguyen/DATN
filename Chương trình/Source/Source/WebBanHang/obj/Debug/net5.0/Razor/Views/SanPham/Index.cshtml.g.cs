#pragma checksum "D:\DATN\Source\Source\WebBanHang\Views\SanPham\Index.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "bbe8e14fad4154317f947af1ab898bec2a6378932733944d08d180c5a1c507da"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCoreGeneratedDocument.Views_SanPham_Index), @"mvc.1.0.view", @"/Views/SanPham/Index.cshtml")]
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

#nullable disable
    ;
#nullable restore
#line 1 "D:\DATN\Source\Source\WebBanHang\Views\SanPham\Index.cshtml"
 using PagedList.Core.Mvc

#line default
#line hidden
#nullable disable
    ;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"bbe8e14fad4154317f947af1ab898bec2a6378932733944d08d180c5a1c507da", @"/Views/SanPham/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"20e31815b6ab70dd67ecbb34d4a392b79e2a67146353b6f597a36821de7a03b6", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    internal sealed class Views_SanPham_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<
#nullable restore
#line 2 "D:\DATN\Source\Source\WebBanHang\Views\SanPham\Index.cshtml"
       PagedList.Core.IPagedList<WebBanHang.Models.SanPham>

#line default
#line hidden
#nullable disable
    >
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "SanPham", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-full"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Product Images"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "0", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "1", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "2", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("pager-container"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        private global::PagedList.Core.Mvc.PagerTagHelper __PagedList_Core_Mvc_PagerTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "D:\DATN\Source\Source\WebBanHang\Views\SanPham\Index.cshtml"
  

    ViewData["Title"] = "Sản phẩm";
    Layout = "~/Views/Shared/_Layout.cshtml";
    int CurrentPage = ViewBag.CurrentPage;
    int PageNext = CurrentPage + 1;
    List<LoaiSanPham> dmsp = ViewBag.DMSP;
    List<SanPham> spm = ViewBag.SPM;

#line default
#line hidden
#nullable disable

            WriteLiteral(@"

<!-- Begin Main Content Area -->
<main class=""main-content"">
    <div class=""breadcrumb-area breadcrumb-height"" style=""height:150px;background-color:#E3F0E1"">
        <div class=""container h-100"">
            <div class=""row h-100"">
                <div class=""col-lg-12"">
                    <div class=""breadcrumb-item"">
                        <h2 class=""breadcrumb-heading"" style=""font-family:Verdana"">Sản phẩm</h2>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <div class=""shop-area section-space-y-axis-100"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-lg-3 order-lg-1 order-2 pt-10 pt-lg-0"">
                    <div class=""sidebar-area"">
                        <div class=""widgets-searchbox mb-9"">
                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bbe8e14fad4154317f947af1ab898bec2a6378932733944d08d180c5a1c507da8181", async() => {
                WriteLiteral(@"
                                <input class=""input-field"" name=""searchKey"" type=""text"" placeholder=""Tìm"">
                                <button class=""widgets-searchbox-btn"" type=""submit"">
                                    <i class=""pe-7s-search""></i>
                                </button>
                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                        </div>\n\n                        ");
            Write(
#nullable restore
#line 41 "D:\DATN\Source\Source\WebBanHang\Views\SanPham\Index.cshtml"
                         await Html.PartialAsync("_DMSPPartialView.cshtml", dmsp)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral(@"

                        <div class=""widgets-area mb-9"">
                            <h2 class=""widgets-title mb-5"">Sản phẩm mới</h2>
                            <div class=""widgets-item"">
                                <div class=""swiper-container widgets-list-slider"">
                                    <div class=""swiper-wrapper"">
                                        <div class=""swiper-slide"">
");
#nullable restore
#line 49 "D:\DATN\Source\Source\WebBanHang\Views\SanPham\Index.cshtml"
                                             foreach (var item in spm)
                                            {

#line default
#line hidden
#nullable disable

            WriteLiteral("                                                <div class=\"product-list-item\">\n                                                    <div class=\"product-img img-zoom-effect\">\n                                                        <a");
            BeginWriteAttribute("href", " href=\"", 2439, "\"", 2464, 2);
            WriteAttributeValue("", 2446, "sanpham/", 2446, 8, true);
            WriteAttributeValue("", 2454, 
#nullable restore
#line 53 "D:\DATN\Source\Source\WebBanHang\Views\SanPham\Index.cshtml"
                                                                          item.MaSp

#line default
#line hidden
#nullable disable
            , 2454, 10, false);
            EndWriteAttribute();
            WriteLiteral(">\n                                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "bbe8e14fad4154317f947af1ab898bec2a6378932733944d08d180c5a1c507da12250", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2554, "~/images/sanpham/", 2554, 17, true);
            AddHtmlAttributeValue("", 2571, 
#nullable restore
#line 54 "D:\DATN\Source\Source\WebBanHang\Views\SanPham\Index.cshtml"
                                                                                                         item.Anh

#line default
#line hidden
#nullable disable
            , 2571, 9, false);
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                                        </a>
                                                        <div class=""product-add-action"">
                                                            <ul>
                                                                <li>
                                                                    <a href=""cart.html"">
                                                                        <i class=""pe-7s-cart""></i>
                                                                    </a>
                                                                </li>

                                                            </ul>
                                                        </div>
                                                    </div>
                                                    <div class=""product-content"">
                                                        <a class=""product-name""");
            BeginWriteAttribute("href", " href=\"", 3569, "\"", 3594, 2);
            WriteAttributeValue("", 3576, "sanpham/", 3576, 8, true);
            WriteAttributeValue("", 3584, 
#nullable restore
#line 68 "D:\DATN\Source\Source\WebBanHang\Views\SanPham\Index.cshtml"
                                                                                               item.MaSp

#line default
#line hidden
#nullable disable
            , 3584, 10, false);
            EndWriteAttribute();
            WriteLiteral(">");
            Write(
#nullable restore
#line 68 "D:\DATN\Source\Source\WebBanHang\Views\SanPham\Index.cshtml"
                                                                                                           item.TenSp

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</a>\n                                                        <div class=\"price-box pb-1\">\n                                                            <span class=\"old-price text-dark\">");
            Write(
#nullable restore
#line 70 "D:\DATN\Source\Source\WebBanHang\Views\SanPham\Index.cshtml"
                                                                                               item.GiaBan.Value.ToString("#,##0")

#line default
#line hidden
#nullable disable
            );
            WriteLiteral(" đ</span>\n                                                            <span class=\"new-price text-danger\">");
            Write(
#nullable restore
#line 71 "D:\DATN\Source\Source\WebBanHang\Views\SanPham\Index.cshtml"
                                                                                                 item.GiaGiam.Value.ToString("#,##0")

#line default
#line hidden
#nullable disable
            );
            WriteLiteral(" đ</span>\n                                                        </div>\n                                                    </div>\n                                                </div>\n");
#nullable restore
#line 75 "D:\DATN\Source\Source\WebBanHang\Views\SanPham\Index.cshtml"
                                            }

#line default
#line hidden
#nullable disable

            WriteLiteral(@"
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
                <div class=""col-lg-9 order-lg-2 order-1"">
                    <div class=""product-topbar"">
                        <ul>
                            <li class=""product-view-wrap"">
                                <ul class=""nav"" role=""tablist"">
                                    <li class=""grid-view"" role=""presentation"">
                                        <a class=""active"" id=""grid-view-tab"" data-bs-toggle=""tab"" href=""#grid-view"" role=""tab"" aria-selected=""true"">
                                            <i class=""fa fa-th""></i>
                                        </a>
                                    </li>
                                </ul>
                            </li>

                            <li class=""short col-lg-2"">
      ");
            WriteLiteral("                          <select id=\"sort_pros\" name=\"sort_pros\" class=\"nice-select wide rounded-0\">\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bbe8e14fad4154317f947af1ab898bec2a6378932733944d08d180c5a1c507da18500", async() => {
                WriteLiteral("Sắp xếp");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            BeginWriteTagHelperAttribute();
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("selected", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bbe8e14fad4154317f947af1ab898bec2a6378932733944d08d180c5a1c507da20030", async() => {
                WriteLiteral("Giá tăng dần");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bbe8e14fad4154317f947af1ab898bec2a6378932733944d08d180c5a1c507da21254", async() => {
                WriteLiteral("Giá giảm dần");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                </select>
                            </li>
                        </ul>
                    </div>
                    <div class=""tab-content text-charcoal pt-8"">
                        <div class=""tab-pane fade show active"" id=""grid-view"" role=""tabpanel"" aria-labelledby=""grid-view-tab"">
                            <div class=""product-grid-view row"">
");
#nullable restore
#line 109 "D:\DATN\Source\Source\WebBanHang\Views\SanPham\Index.cshtml"
                                 if (Model != null && Model.Count() > 0)
                                {
                                    foreach (var item in Model)
                                    {

#line default
#line hidden
#nullable disable

            WriteLiteral(@"                                        <div class=""col-lg-4 col-sm-6 pt-6"">
                                            <div class=""product-item"">
                                                <div class=""product-img img-zoom-effect"">
                                                    <a");
            BeginWriteAttribute("href", " href=\"", 6451, "\"", 6476, 2);
            WriteAttributeValue("", 6458, "sanpham/", 6458, 8, true);
            WriteAttributeValue("", 6466, 
#nullable restore
#line 116 "D:\DATN\Source\Source\WebBanHang\Views\SanPham\Index.cshtml"
                                                                      item.MaSp

#line default
#line hidden
#nullable disable
            , 6466, 10, false);
            EndWriteAttribute();
            WriteLiteral(">\n                                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "bbe8e14fad4154317f947af1ab898bec2a6378932733944d08d180c5a1c507da24096", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 6562, "~/images/sanpham/", 6562, 17, true);
            AddHtmlAttributeValue("", 6579, 
#nullable restore
#line 117 "D:\DATN\Source\Source\WebBanHang\Views\SanPham\Index.cshtml"
                                                                                                     item.Anh

#line default
#line hidden
#nullable disable
            , 6579, 9, false);
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                                    </a>
                                                    <div class=""product-add-action"">
                                                        <ul>
                                                            <li class=""add-to-cart"">
                                                                <a href=""javascript:void(0)"">
                                                                    <i class=""pe-7s-cart""></i>
                                                                </a>
                                                                <input hidden id=""MaSp"" name=""MaSp""");
            BeginWriteAttribute("value", " value=\"", 7257, "\"", 7275, 1);
            WriteAttributeValue("", 7265, 
#nullable restore
#line 125 "D:\DATN\Source\Source\WebBanHang\Views\SanPham\Index.cshtml"
                                                                                                            item.MaSp

#line default
#line hidden
#nullable disable
            , 7265, 10, false);
            EndWriteAttribute();
            WriteLiteral(@" />

                                                            </li>
                                                            <li class=""quantity"">
                                                                <div>
                                                                    <input hidden id=""txtsoLuong"" name=""txtsoLuong"" class=""cart-plus-minus-box"" value=""1"" type=""text"">
                                                                </div>
                                                            </li>


                                                        </ul>
                                                    </div>
                                                </div>
                                                <div class=""product-content"" >
                                                    <a style=""display: block; height:72px"" class=""product-name""");
            BeginWriteAttribute("href", " href=\"", 8171, "\"", 8196, 2);
            WriteAttributeValue("", 8178, "sanpham/", 8178, 8, true);
            WriteAttributeValue("", 8186, 
#nullable restore
#line 139 "D:\DATN\Source\Source\WebBanHang\Views\SanPham\Index.cshtml"
                                                                                                                               item.MaSp

#line default
#line hidden
#nullable disable
            , 8186, 10, false);
            EndWriteAttribute();
            WriteLiteral(">");
            Write(
#nullable restore
#line 139 "D:\DATN\Source\Source\WebBanHang\Views\SanPham\Index.cshtml"
                                                                                                                                           item.TenSp

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</a>\n                                                    <div class=\"price-box pb-1\">\n                                                        <span class=\"old-price text-dark\">");
            Write(
#nullable restore
#line 141 "D:\DATN\Source\Source\WebBanHang\Views\SanPham\Index.cshtml"
                                                                                           item.GiaBan.Value.ToString("#,##0")

#line default
#line hidden
#nullable disable
            );
            WriteLiteral(" đ</span><br />\n                                                        <span class=\"new-price text-danger\">");
            Write(
#nullable restore
#line 142 "D:\DATN\Source\Source\WebBanHang\Views\SanPham\Index.cshtml"
                                                                                             item.GiaGiam.Value.ToString("#,##0")

#line default
#line hidden
#nullable disable
            );
            WriteLiteral(" đ</span>\n                                                    </div>\n                                                </div>\n                                            </div>\n                                        </div>\n");
#nullable restore
#line 147 "D:\DATN\Source\Source\WebBanHang\Views\SanPham\Index.cshtml"
                                    }
                                }

#line default
#line hidden
#nullable disable

            WriteLiteral("                            </div>\n                        </div>\n\n                    </div>\n                    <div class=\"pagination-area pt-10\">\n                        <ul class=\"pagination justify-content-center\">\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("pager", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "bbe8e14fad4154317f947af1ab898bec2a6378932733944d08d180c5a1c507da30564", async() => {
            }
            );
            __PagedList_Core_Mvc_PagerTagHelper = CreateTagHelper<global::PagedList.Core.Mvc.PagerTagHelper>();
            __tagHelperExecutionContext.Add(__PagedList_Core_Mvc_PagerTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            __PagedList_Core_Mvc_PagerTagHelper.Options = 
#nullable restore
#line 155 "D:\DATN\Source\Source\WebBanHang\Views\SanPham\Index.cshtml"
                                                                     PagedListRenderOptions.Bootstrap4PageNumbersOnly

#line default
#line hidden
#nullable disable
            ;
            __tagHelperExecutionContext.AddTagHelperAttribute("options", __PagedList_Core_Mvc_PagerTagHelper.Options, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __PagedList_Core_Mvc_PagerTagHelper.List = 
#nullable restore
#line 155 "D:\DATN\Source\Source\WebBanHang\Views\SanPham\Index.cshtml"
                                                                                                                              Model

#line default
#line hidden
#nullable disable
            ;
            __tagHelperExecutionContext.AddTagHelperAttribute("list", __PagedList_Core_Mvc_PagerTagHelper.List, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __PagedList_Core_Mvc_PagerTagHelper.AspController = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __PagedList_Core_Mvc_PagerTagHelper.AspAction = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                        </ul>\n                    </div>\n                </div>\n            </div>\n        </div>\n    </div>\n</main>\n<!-- Main Content Area End Here -->\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script>
        $(document).ready(function () {
            //add cart
            $(function () {
                function loadHeaderCart() {
                    $(""#miniCart"").load(""/AjaxContent/HeaderCart"");
                    $(""#numberCart"").load(""/AjaxContent/NumberCart"");
                }
                $("".add-to-cart"").click(function () {
                    var productid = $(this).children('#MaSp').val();
                    var soLuong = $('#txtsoLuong').val();

                    $.ajax({
                        url: '/api/cart/add',
                        datatype: ""json"",
                        type: ""POST"",
                        data: {
                            productID: productid,
                            amount: soLuong
                        },
                        success: function (response) {
                            loadHeaderCart();
                            location.reload();
                        },
                        error: function (error) {
    ");
                WriteLiteral(@"                        alert(""Lỗi!"" + error.responseText);
                        }
                    });
                });
            });

            //sắp xếp
            jQuery(""#sort_pros"").change(function () {
                var sx = jQuery(this).children("":selected"").attr(""value"");
                sx = parseFloat(sx);

                $('#sort_pros option')
                    .removeAttr('selected');
                $(""#sort_pros > [value="" + sx + ""]"").attr(""selected"", ""true"");

                $.ajax({
                    url: 'sanpham/sort',
                    datatype: ""json"",
                    type: ""GET"",
                    data: {
                        sort: sx,
                    },
                    async: true,
                    success: function (results) {
                        if (results.status == ""success"") {
                            window.location.href = results.redirectUrl;
                        }
                    },
                    error: function (xh");
                WriteLiteral("r) {\n                        alert(\'error\');\n                    }\n                });\n            });\n        });\n    </script>\n");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PagedList.Core.IPagedList<WebBanHang.Models.SanPham>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
