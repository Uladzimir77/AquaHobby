#pragma checksum "C:\Users\Vladimir\Desktop\VS2019\AquaHobby\AquaHobby\Views\Fauna\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9e77c92e22b69d75af3403d83260f1f8c12b6190"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Fauna_Index), @"mvc.1.0.view", @"/Views/Fauna/Index.cshtml")]
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
#line 1 "C:\Users\Vladimir\Desktop\VS2019\AquaHobby\AquaHobby\Views\_ViewImports.cshtml"
using AquaHobby;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Vladimir\Desktop\VS2019\AquaHobby\AquaHobby\Views\_ViewImports.cshtml"
using AquaHobby.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9e77c92e22b69d75af3403d83260f1f8c12b6190", @"/Views/Fauna/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"25e26de707a0249eab7cffa5e5b1954c082ad007", @"/Views/_ViewImports.cshtml")]
    public class Views_Fauna_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<FaunaViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div class=\"fauns\">\r\n");
#nullable restore
#line 3 "C:\Users\Vladimir\Desktop\VS2019\AquaHobby\AquaHobby\Views\Fauna\Index.cshtml"
     foreach (var fauna in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"fauna\">\r\n            <div class=\"name\">\r\n                ");
#nullable restore
#line 7 "C:\Users\Vladimir\Desktop\VS2019\AquaHobby\AquaHobby\Views\Fauna\Index.cshtml"
           Write(fauna.FaunaName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <a");
            BeginWriteAttribute("href", " href=\"", 188, "\"", 221, 2);
            WriteAttributeValue("", 195, "/Fauna/Remove?id=", 195, 17, true);
#nullable restore
#line 7 "C:\Users\Vladimir\Desktop\VS2019\AquaHobby\AquaHobby\Views\Fauna\Index.cshtml"
WriteAttributeValue("", 212, fauna.Id, 212, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"icon close\"></a>\r\n            </div>\r\n            <div class=\"fauna-block-image\">\r\n                <img class=\"fauna-img\"");
            BeginWriteAttribute("src", " src=\"", 351, "\"", 372, 1);
#nullable restore
#line 10 "C:\Users\Vladimir\Desktop\VS2019\AquaHobby\AquaHobby\Views\Fauna\Index.cshtml"
WriteAttributeValue("", 357, fauna.ImageUrl, 357, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n            </div>\r\n            <div>\r\n                Цена:");
#nullable restore
#line 13 "C:\Users\Vladimir\Desktop\VS2019\AquaHobby\AquaHobby\Views\Fauna\Index.cshtml"
                Write(fauna.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n            <div>\r\n                Остаток:");
#nullable restore
#line 16 "C:\Users\Vladimir\Desktop\VS2019\AquaHobby\AquaHobby\Views\Fauna\Index.cshtml"
                   Write(fauna.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 19 "C:\Users\Vladimir\Desktop\VS2019\AquaHobby\AquaHobby\Views\Fauna\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("  \r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<FaunaViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
