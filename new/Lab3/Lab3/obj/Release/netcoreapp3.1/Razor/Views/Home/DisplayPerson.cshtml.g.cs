#pragma checksum "C:\Users\ajasa\source\repos\CST8359\new\Lab3\Lab3\Views\Home\DisplayPerson.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3ae68e9b91c48daf01d6be04dec73521884350e0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_DisplayPerson), @"mvc.1.0.view", @"/Views/Home/DisplayPerson.cshtml")]
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
#line 1 "C:\Users\ajasa\source\repos\CST8359\new\Lab3\Lab3\Views\_ViewImports.cshtml"
using Lab3;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\ajasa\source\repos\CST8359\new\Lab3\Lab3\Views\Home\DisplayPerson.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3ae68e9b91c48daf01d6be04dec73521884350e0", @"/Views/Home/DisplayPerson.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"65ad80800b45b0ce869561318aec7ce5a8253d74", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_DisplayPerson : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
            WriteLiteral("\n");
#nullable restore
#line 12 "C:\Users\ajasa\source\repos\CST8359\new\Lab3\Lab3\Views\Home\DisplayPerson.cshtml"
   Layout = "_Layout";
    ViewData["Title"] = "Lab3 display person"; 

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<!--note took table structure from prof demo-->\n<h3>Display person</h3>\n<table>\n    <tr>\n        <td>First name: </td>\n        <td>\n            ");
#nullable restore
#line 21 "C:\Users\ajasa\source\repos\CST8359\new\Lab3\Lab3\Views\Home\DisplayPerson.cshtml"
       Write(Model.firstName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </td>\n    </tr>\n    <tr>\n        <td>Last name: </td>\n        <td>\n            ");
#nullable restore
#line 27 "C:\Users\ajasa\source\repos\CST8359\new\Lab3\Lab3\Views\Home\DisplayPerson.cshtml"
       Write(Model.lastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </td>\n    </tr>\n    <tr>\n        <td>Age: </td>\n        <td>\n            ");
#nullable restore
#line 33 "C:\Users\ajasa\source\repos\CST8359\new\Lab3\Lab3\Views\Home\DisplayPerson.cshtml"
       Write(Model.age);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </td>\n    </tr>\n    <tr>\n        <td>Email address: </td>\n        <td>\n            ");
#nullable restore
#line 39 "C:\Users\ajasa\source\repos\CST8359\new\Lab3\Lab3\Views\Home\DisplayPerson.cshtml"
       Write(Model.emailAddress);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </td>\n    </tr>\n    <tr>\n        <td>Date of birth: </td>\n        <td>\n            ");
#nullable restore
#line 45 "C:\Users\ajasa\source\repos\CST8359\new\Lab3\Lab3\Views\Home\DisplayPerson.cshtml"
       Write(Model.birthDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </td>\n    </tr>\n    <tr>\n        <td>Description: </td>\n        <td>\n            ");
#nullable restore
#line 51 "C:\Users\ajasa\source\repos\CST8359\new\Lab3\Lab3\Views\Home\DisplayPerson.cshtml"
       Write(Model.description);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </td>\n    </tr>\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
