#pragma checksum "D:\Frontend-Semester 5\UAS\Pages\DetailStudentPage.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "14bdd1cf2f5166f42afd9f2777a3eb1b0213491e"
// <auto-generated/>
#pragma warning disable 1591
namespace UAS.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\Frontend-Semester 5\UAS\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Frontend-Semester 5\UAS\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Frontend-Semester 5\UAS\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Frontend-Semester 5\UAS\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Frontend-Semester 5\UAS\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Frontend-Semester 5\UAS\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Frontend-Semester 5\UAS\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Frontend-Semester 5\UAS\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Frontend-Semester 5\UAS\_Imports.razor"
using UAS;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\Frontend-Semester 5\UAS\_Imports.razor"
using UAS.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/studentdetail/{id}")]
    public partial class DetailStudentPage : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h2>Detail</h2>\r\n");
            __builder.AddMarkupContent(1, "<h4>Students</h4>\r\n<span class=\"border-bottom\"></span>\r\n<br>\r\n");
            __builder.OpenElement(2, "table");
            __builder.AddAttribute(3, "style", "width:100%");
            __builder.OpenElement(4, "tr");
            __builder.AddMarkupContent(5, "<th style=\"width:20%\">NIM</th>\r\n        ");
            __builder.OpenElement(6, "td");
            __builder.AddAttribute(7, "style", "width:70%");
            __builder.AddContent(8, 
#nullable restore
#line 10 "D:\Frontend-Semester 5\UAS\Pages\DetailStudentPage.razor"
                               Student.studentId

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n    ");
            __builder.OpenElement(10, "tr");
            __builder.AddMarkupContent(11, "<th style=\"width:20%\">Nama</th>\r\n        ");
            __builder.OpenElement(12, "td");
            __builder.AddAttribute(13, "style", "width:70%");
            __builder.AddContent(14, 
#nullable restore
#line 14 "D:\Frontend-Semester 5\UAS\Pages\DetailStudentPage.razor"
                               Student.firstName

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(15, " ");
            __builder.AddContent(16, 
#nullable restore
#line 14 "D:\Frontend-Semester 5\UAS\Pages\DetailStudentPage.razor"
                                                  Student.lastName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n    ");
            __builder.OpenElement(18, "tr");
            __builder.AddMarkupContent(19, "<th style=\"width:20%\">Tanggal Masuk</th>\r\n        ");
            __builder.OpenElement(20, "td");
            __builder.AddAttribute(21, "style", "width:70%");
            __builder.AddContent(22, 
#nullable restore
#line 18 "D:\Frontend-Semester 5\UAS\Pages\DetailStudentPage.razor"
                               Student.enrollmentDate

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n<br>\r\n");
            __builder.OpenElement(24, "a");
            __builder.AddAttribute(25, "href", 
#nullable restore
#line 22 "D:\Frontend-Semester 5\UAS\Pages\DetailStudentPage.razor"
           $"studentedit/{Student.studentId}"

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(26, "Edit");
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "<a> | </a>");
            __builder.AddMarkupContent(28, "<a href=\"/studentpage\">Back to List</a>");
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
