#pragma checksum "C:\Users\solta\source\repos\PayrollSystem\PayrollSystem.HRM.WEB\Views\EmployeesDetails\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2a371fdb069376f3fa33399c590c16667aca07ae"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_EmployeesDetails_Index), @"mvc.1.0.view", @"/Views/EmployeesDetails/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/EmployeesDetails/Index.cshtml", typeof(AspNetCore.Views_EmployeesDetails_Index))]
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
#line 1 "C:\Users\solta\source\repos\PayrollSystem\PayrollSystem.HRM.WEB\Views\_ViewImports.cshtml"
using PayrollSystem.HRM.WEB;

#line default
#line hidden
#line 2 "C:\Users\solta\source\repos\PayrollSystem\PayrollSystem.HRM.WEB\Views\_ViewImports.cshtml"
using PayrollSystem.HRM.WEB.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2a371fdb069376f3fa33399c590c16667aca07ae", @"/Views/EmployeesDetails/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7452b7a8deb2898afa023f83195d5179e457dbba", @"/Views/_ViewImports.cshtml")]
    public class Views_EmployeesDetails_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<PayrollSystem.HRM.Entity.Employee>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\solta\source\repos\PayrollSystem\PayrollSystem.HRM.WEB\Views\EmployeesDetails\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(97, 102, true);
            WriteLiteral("\r\n<h1>Index</h1>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(200, 40, false);
#line 11 "C:\Users\solta\source\repos\PayrollSystem\PayrollSystem.HRM.WEB\Views\EmployeesDetails\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(240, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(296, 43, false);
#line 14 "C:\Users\solta\source\repos\PayrollSystem\PayrollSystem.HRM.WEB\Views\EmployeesDetails\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Surname));

#line default
#line hidden
            EndContext();
            BeginContext(339, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(395, 46, false);
#line 17 "C:\Users\solta\source\repos\PayrollSystem\PayrollSystem.HRM.WEB\Views\EmployeesDetails\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.FatherName));

#line default
#line hidden
            EndContext();
            BeginContext(441, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(497, 45, false);
#line 20 "C:\Users\solta\source\repos\PayrollSystem\PayrollSystem.HRM.WEB\Views\EmployeesDetails\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Birthdate));

#line default
#line hidden
            EndContext();
            BeginContext(542, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(598, 42, false);
#line 23 "C:\Users\solta\source\repos\PayrollSystem\PayrollSystem.HRM.WEB\Views\EmployeesDetails\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Adress));

#line default
#line hidden
            EndContext();
            BeginContext(640, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(696, 50, false);
#line 26 "C:\Users\solta\source\repos\PayrollSystem\PayrollSystem.HRM.WEB\Views\EmployeesDetails\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.RegisterAdress));

#line default
#line hidden
            EndContext();
            BeginContext(746, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(802, 46, false);
#line 29 "C:\Users\solta\source\repos\PayrollSystem\PayrollSystem.HRM.WEB\Views\EmployeesDetails\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.PassportId));

#line default
#line hidden
            EndContext();
            BeginContext(848, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(904, 51, false);
#line 32 "C:\Users\solta\source\repos\PayrollSystem\PayrollSystem.HRM.WEB\Views\EmployeesDetails\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.PassportExpDate));

#line default
#line hidden
            EndContext();
            BeginContext(955, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1011, 45, false);
#line 35 "C:\Users\solta\source\repos\PayrollSystem\PayrollSystem.HRM.WEB\Views\EmployeesDetails\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Education));

#line default
#line hidden
            EndContext();
            BeginContext(1056, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1112, 49, false);
#line 38 "C:\Users\solta\source\repos\PayrollSystem\PayrollSystem.HRM.WEB\Views\EmployeesDetails\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.MartialStatus));

#line default
#line hidden
            EndContext();
            BeginContext(1161, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1217, 42, false);
#line 41 "C:\Users\solta\source\repos\PayrollSystem\PayrollSystem.HRM.WEB\Views\EmployeesDetails\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Gender));

#line default
#line hidden
            EndContext();
            BeginContext(1259, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1315, 47, false);
#line 44 "C:\Users\solta\source\repos\PayrollSystem\PayrollSystem.HRM.WEB\Views\EmployeesDetails\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Attendances));

#line default
#line hidden
            EndContext();
            BeginContext(1362, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1418, 41, false);
#line 47 "C:\Users\solta\source\repos\PayrollSystem\PayrollSystem.HRM.WEB\Views\EmployeesDetails\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Bonus));

#line default
#line hidden
            EndContext();
            BeginContext(1459, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1515, 43, false);
#line 50 "C:\Users\solta\source\repos\PayrollSystem\PayrollSystem.HRM.WEB\Views\EmployeesDetails\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Penalty));

#line default
#line hidden
            EndContext();
            BeginContext(1558, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1614, 46, false);
#line 53 "C:\Users\solta\source\repos\PayrollSystem\PayrollSystem.HRM.WEB\Views\EmployeesDetails\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.WorkPlaces));

#line default
#line hidden
            EndContext();
            BeginContext(1660, 88, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n\r\n    <tbody>\r\n");
            EndContext();
#line 60 "C:\Users\solta\source\repos\PayrollSystem\PayrollSystem.HRM.WEB\Views\EmployeesDetails\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
            BeginContext(1797, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1846, 39, false);
#line 64 "C:\Users\solta\source\repos\PayrollSystem\PayrollSystem.HRM.WEB\Views\EmployeesDetails\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
            EndContext();
            BeginContext(1885, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1941, 42, false);
#line 67 "C:\Users\solta\source\repos\PayrollSystem\PayrollSystem.HRM.WEB\Views\EmployeesDetails\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Surname));

#line default
#line hidden
            EndContext();
            BeginContext(1983, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2039, 45, false);
#line 70 "C:\Users\solta\source\repos\PayrollSystem\PayrollSystem.HRM.WEB\Views\EmployeesDetails\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.FatherName));

#line default
#line hidden
            EndContext();
            BeginContext(2084, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2140, 44, false);
#line 73 "C:\Users\solta\source\repos\PayrollSystem\PayrollSystem.HRM.WEB\Views\EmployeesDetails\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Birthdate));

#line default
#line hidden
            EndContext();
            BeginContext(2184, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2240, 41, false);
#line 76 "C:\Users\solta\source\repos\PayrollSystem\PayrollSystem.HRM.WEB\Views\EmployeesDetails\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Adress));

#line default
#line hidden
            EndContext();
            BeginContext(2281, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2337, 49, false);
#line 79 "C:\Users\solta\source\repos\PayrollSystem\PayrollSystem.HRM.WEB\Views\EmployeesDetails\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.RegisterAdress));

#line default
#line hidden
            EndContext();
            BeginContext(2386, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2442, 45, false);
#line 82 "C:\Users\solta\source\repos\PayrollSystem\PayrollSystem.HRM.WEB\Views\EmployeesDetails\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.PassportId));

#line default
#line hidden
            EndContext();
            BeginContext(2487, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2543, 50, false);
#line 85 "C:\Users\solta\source\repos\PayrollSystem\PayrollSystem.HRM.WEB\Views\EmployeesDetails\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.PassportExpDate));

#line default
#line hidden
            EndContext();
            BeginContext(2593, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2649, 44, false);
#line 88 "C:\Users\solta\source\repos\PayrollSystem\PayrollSystem.HRM.WEB\Views\EmployeesDetails\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Education));

#line default
#line hidden
            EndContext();
            BeginContext(2693, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2749, 48, false);
#line 91 "C:\Users\solta\source\repos\PayrollSystem\PayrollSystem.HRM.WEB\Views\EmployeesDetails\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.MartialStatus));

#line default
#line hidden
            EndContext();
            BeginContext(2797, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2853, 41, false);
#line 94 "C:\Users\solta\source\repos\PayrollSystem\PayrollSystem.HRM.WEB\Views\EmployeesDetails\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Gender));

#line default
#line hidden
            EndContext();
            BeginContext(2894, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2950, 59, false);
#line 97 "C:\Users\solta\source\repos\PayrollSystem\PayrollSystem.HRM.WEB\Views\EmployeesDetails\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Attendances.First().Date));

#line default
#line hidden
            EndContext();
            BeginContext(3009, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(3065, 55, false);
#line 100 "C:\Users\solta\source\repos\PayrollSystem\PayrollSystem.HRM.WEB\Views\EmployeesDetails\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Bonus.First().Amount));

#line default
#line hidden
            EndContext();
            BeginContext(3120, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(3176, 48, false);
#line 103 "C:\Users\solta\source\repos\PayrollSystem\PayrollSystem.HRM.WEB\Views\EmployeesDetails\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Penalty.Count));

#line default
#line hidden
            EndContext();
            BeginContext(3224, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(3280, 51, false);
#line 106 "C:\Users\solta\source\repos\PayrollSystem\PayrollSystem.HRM.WEB\Views\EmployeesDetails\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.WorkPlaces.Count));

#line default
#line hidden
            EndContext();
            BeginContext(3331, 36, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 109 "C:\Users\solta\source\repos\PayrollSystem\PayrollSystem.HRM.WEB\Views\EmployeesDetails\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(3378, 22, true);
            WriteLiteral("    </tbody>\r\n</table>");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<PayrollSystem.HRM.Entity.Employee>> Html { get; private set; }
    }
}
#pragma warning restore 1591