#pragma checksum "D:\DATN\Source\Source\WebBanHang\Views\SanPham\_DMSPPartialView.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "bc0d409284c3c12edfdbdf2216e1849d82cf3c1112a9f2b3d43f9ee45250a9f0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCoreGeneratedDocument.Views_SanPham__DMSPPartialView), @"mvc.1.0.view", @"/Views/SanPham/_DMSPPartialView.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"bc0d409284c3c12edfdbdf2216e1849d82cf3c1112a9f2b3d43f9ee45250a9f0", @"/Views/SanPham/_DMSPPartialView.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"20e31815b6ab70dd67ecbb34d4a392b79e2a67146353b6f597a36821de7a03b6", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    internal sealed class Views_SanPham__DMSPPartialView : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<
#nullable restore
#line 1 "D:\DATN\Source\Source\WebBanHang\Views\SanPham\_DMSPPartialView.cshtml"
       List<LoaiSanPham>

#line default
#line hidden
#nullable disable
    >
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n<div class=\"widgets-area mb-9\">\n    <h2 class=\"widgets-title mb-5\">Danh mục</h2>\n    <div class=\"widgets-item\">\n        <ul class=\"widgets-category\">\n");
#nullable restore
#line 7 "D:\DATN\Source\Source\WebBanHang\Views\SanPham\_DMSPPartialView.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable

            WriteLiteral("                <li>\n                    <a");
            BeginWriteAttribute("href", " href=\"", 274, "\"", 303, 2);
            WriteAttributeValue("", 281, "/sanphams/", 281, 10, true);
            WriteAttributeValue("", 291, 
#nullable restore
#line 10 "D:\DATN\Source\Source\WebBanHang\Views\SanPham\_DMSPPartialView.cshtml"
                                        item.MaLoai

#line default
#line hidden
#nullable disable
            , 291, 12, false);
            EndWriteAttribute();
            WriteLiteral(">\n                        ");
            Write(
#nullable restore
#line 11 "D:\DATN\Source\Source\WebBanHang\Views\SanPham\_DMSPPartialView.cshtml"
                         item.TenLoai

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\n                        <span></span>\n                    </a>\n                </li>\n");
#nullable restore
#line 15 "D:\DATN\Source\Source\WebBanHang\Views\SanPham\_DMSPPartialView.cshtml"
            }

#line default
#line hidden
#nullable disable

            WriteLiteral("\n        </ul>\n    </div>\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<LoaiSanPham>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
