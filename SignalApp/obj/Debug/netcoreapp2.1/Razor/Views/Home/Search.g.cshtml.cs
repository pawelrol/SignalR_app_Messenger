#pragma checksum "C:\Users\Pawel\source\repos\SignalApp2\SignalApp\Views\Home\Search.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "71fa4020c4d4e45b76f96966699cc82b37ef52f8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Search), @"mvc.1.0.view", @"/Views/Home/Search.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Search.cshtml", typeof(AspNetCore.Views_Home_Search))]
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
#line 1 "C:\Users\Pawel\source\repos\SignalApp2\SignalApp\Views\_ViewImports.cshtml"
using SignalApp;

#line default
#line hidden
#line 2 "C:\Users\Pawel\source\repos\SignalApp2\SignalApp\Views\_ViewImports.cshtml"
using SignalApp.Models;

#line default
#line hidden
#line 3 "C:\Users\Pawel\source\repos\SignalApp2\SignalApp\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"71fa4020c4d4e45b76f96966699cc82b37ef52f8", @"/Views/Home/Search.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1ac70cf073248c3e07b2c789239db6b6ebb75f4d", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Search : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<IdentityUser>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery/dist/jquery.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
            BeginContext(27, 6, true);
            WriteLiteral("\r\n\r\n\r\n");
            EndContext();
#line 5 "C:\Users\Pawel\source\repos\SignalApp2\SignalApp\Views\Home\Search.cshtml"
  
    ViewData["Title"] = "Search";

#line default
#line hidden
            BeginContext(75, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(77, 51, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "69ce564762d8426a910d65baeb4eb388", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(128, 23, true);
            WriteLiteral("\r\n\r\n<h2>Search</h2>\r\n\r\n");
            EndContext();
#line 13 "C:\Users\Pawel\source\repos\SignalApp2\SignalApp\Views\Home\Search.cshtml"
 foreach(var u in Model)
{

#line default
#line hidden
            BeginContext(180, 36, true);
            WriteLiteral("    <div class=\"cart\">\r\n        <h2>");
            EndContext();
            BeginContext(217, 10, false);
#line 16 "C:\Users\Pawel\source\repos\SignalApp2\SignalApp\Views\Home\Search.cshtml"
       Write(u.UserName);

#line default
#line hidden
            EndContext();
            BeginContext(227, 43, true);
            WriteLiteral("</h2>\r\n        <button class=\"btn btn-info\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 270, "\"", 280, 1);
#line 17 "C:\Users\Pawel\source\repos\SignalApp2\SignalApp\Views\Home\Search.cshtml"
WriteAttributeValue("", 275, u.Id, 275, 5, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(281, 34, true);
            WriteLiteral(" > Dodaj </button>\r\n\r\n    </div>\r\n");
            EndContext();
#line 20 "C:\Users\Pawel\source\repos\SignalApp2\SignalApp\Views\Home\Search.cshtml"
}

#line default
#line hidden
            BeginContext(318, 406, true);
            WriteLiteral(@"
<script>

    $('.btn-info').click(function () {
        var userId = $(this).attr('id');

        $.ajax({
            url: ""home/AddFriend/"" + userId,    //to za nas robi MVC że rozumie żeto jest nasz url z parametrem czyli www.url.pl?id=userId
            success: function () {
                alert(""dodan do listy znajomych"");
            }

        })

    })

    

</script>

");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<IdentityUser>> Html { get; private set; }
    }
}
#pragma warning restore 1591
