#pragma checksum "C:\Users\User\Desktop\Yeni klasör (6)\eTicketMVC\eTicketMVC\Views\Actors\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "94b0539efecc6607209941768e2e61af8ea81a2d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Actors_Index), @"mvc.1.0.view", @"/Views/Actors/Index.cshtml")]
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
#line 1 "C:\Users\User\Desktop\Yeni klasör (6)\eTicketMVC\eTicketMVC\Views\_ViewImports.cshtml"
using eTicketMVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\User\Desktop\Yeni klasör (6)\eTicketMVC\eTicketMVC\Views\_ViewImports.cshtml"
using eTicketMVC.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"94b0539efecc6607209941768e2e61af8ea81a2d", @"/Views/Actors/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1f133b7dcc0db6c0f7e3491c868e2907809f6af3", @"/Views/_ViewImports.cshtml")]
    public class Views_Actors_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Actor>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\User\Desktop\Yeni klasör (6)\eTicketMVC\eTicketMVC\Views\Actors\Index.cshtml"
   
    ViewData["Title"] = "List of Actors";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<div class=\"row\">\r\n    <div class=\"col-md-8 offset-md-2\">\r\n        <table class=\"table\">\r\n            <thead>\r\n                <tr class=\"text-center\">\r\n                    <th>");
#nullable restore
#line 13 "C:\Users\User\Desktop\Yeni klasör (6)\eTicketMVC\eTicketMVC\Views\Actors\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.ProfilePictureURL));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                    <th>");
#nullable restore
#line 14 "C:\Users\User\Desktop\Yeni klasör (6)\eTicketMVC\eTicketMVC\Views\Actors\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.FullName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                    <th>");
#nullable restore
#line 15 "C:\Users\User\Desktop\Yeni klasör (6)\eTicketMVC\eTicketMVC\Views\Actors\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.Bio));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                    <th>Actions</th>\r\n                </tr>\r\n            </thead>\r\n            <tbody>\r\n");
#nullable restore
#line 20 "C:\Users\User\Desktop\Yeni klasör (6)\eTicketMVC\eTicketMVC\Views\Actors\Index.cshtml"
                 foreach (var actor in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td class=\"align-middle\">\r\n                            <img class=\"rounded-circle\"");
            BeginWriteAttribute("src", " src=\"", 771, "\"", 801, 1);
#nullable restore
#line 24 "C:\Users\User\Desktop\Yeni klasör (6)\eTicketMVC\eTicketMVC\Views\Actors\Index.cshtml"
WriteAttributeValue("", 777, actor.ProfilePictureURL, 777, 24, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 802, "\"", 823, 1);
#nullable restore
#line 24 "C:\Users\User\Desktop\Yeni klasör (6)\eTicketMVC\eTicketMVC\Views\Actors\Index.cshtml"
WriteAttributeValue("", 808, actor.FullName, 808, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"max-width:150px\"/>\r\n                        </td>\r\n                        <td class=\"align-middle\">\r\n                            ");
#nullable restore
#line 27 "C:\Users\User\Desktop\Yeni klasör (6)\eTicketMVC\eTicketMVC\Views\Actors\Index.cshtml"
                       Write(Html.DisplayFor(model=>actor.FullName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td class=\"align-middle\">\r\n                            ");
#nullable restore
#line 30 "C:\Users\User\Desktop\Yeni klasör (6)\eTicketMVC\eTicketMVC\Views\Actors\Index.cshtml"
                       Write(Html.DisplayFor(model => actor.Bio));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                        </td>
                        <td class=""align-middle"">
                            <a class=""btn btn-outline-primary""><i class=""bi bi-pencil-square""></i>Edit</a> |
                            <a class=""btn btn-outline-info""><i class=""bi bi-eye""></i>Details</a> |
                            <a class=""btn btn-danger text-white""><i class=""bi bi-trash""></i>Delete</a>
                        </td>
                    </tr>
");
#nullable restore
#line 38 "C:\Users\User\Desktop\Yeni klasör (6)\eTicketMVC\eTicketMVC\Views\Actors\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\r\n        </table>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Actor>> Html { get; private set; }
    }
}
#pragma warning restore 1591