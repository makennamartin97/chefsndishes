#pragma checksum "/Users/makennamartin97/Documents/coding_dojo/csharpstack/chefsndishes/Views/Home/dishes.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7351e1b0c400b8c1d3c2ac22ac97f4a39aa5e180"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_dishes), @"mvc.1.0.view", @"/Views/Home/dishes.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/dishes.cshtml", typeof(AspNetCore.Views_Home_dishes))]
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
#line 1 "/Users/makennamartin97/Documents/coding_dojo/csharpstack/chefsndishes/Views/_ViewImports.cshtml"
using chefsndishes;

#line default
#line hidden
#line 2 "/Users/makennamartin97/Documents/coding_dojo/csharpstack/chefsndishes/Views/_ViewImports.cshtml"
using chefsndishes.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7351e1b0c400b8c1d3c2ac22ac97f4a39aa5e180", @"/Views/Home/dishes.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f5ba7a60c68383fd41db25449a6c7fece97c2002", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_dishes : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Dish>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "/Users/makennamartin97/Documents/coding_dojo/csharpstack/chefsndishes/Views/Home/dishes.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
            BeginContext(60, 441, true);
            WriteLiteral(@"

<div class=""jumbotron"">
  <h3>Check out some recent dishes!</h3>
  <a href=""/adddish"" class=""btn btn-primary active"" role=""button"" aria-pressed=""true"">Add a Dish</a>
  <table class=""table-striped table"">
    <thead>
        <tr>
            <th scope=""col"">Dish Name</th>
            <th scope=""col"">Chef Name</th>
            <th scope=""col"">Tastiness</th>
            <th scope=""col"">Calories</th>
        </tr>
    </thead>
    <tbody>
");
            EndContext();
#line 20 "/Users/makennamartin97/Documents/coding_dojo/csharpstack/chefsndishes/Views/Home/dishes.cshtml"
       foreach (Dish d in Model)
      {          

#line default
#line hidden
            BeginContext(552, 27, true);
            WriteLiteral("        <tr>\n          <td>");
            EndContext();
            BeginContext(580, 10, false);
#line 23 "/Users/makennamartin97/Documents/coding_dojo/csharpstack/chefsndishes/Views/Home/dishes.cshtml"
         Write(d.DishName);

#line default
#line hidden
            EndContext();
            BeginContext(590, 20, true);
            WriteLiteral("</td>\n          <td>");
            EndContext();
            BeginContext(611, 17, false);
#line 24 "/Users/makennamartin97/Documents/coding_dojo/csharpstack/chefsndishes/Views/Home/dishes.cshtml"
         Write(d.Maker.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(628, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(630, 16, false);
#line 24 "/Users/makennamartin97/Documents/coding_dojo/csharpstack/chefsndishes/Views/Home/dishes.cshtml"
                            Write(d.Maker.LastName);

#line default
#line hidden
            EndContext();
            BeginContext(646, 20, true);
            WriteLiteral("</td>\n          <td>");
            EndContext();
            BeginContext(667, 11, false);
#line 25 "/Users/makennamartin97/Documents/coding_dojo/csharpstack/chefsndishes/Views/Home/dishes.cshtml"
         Write(d.Tastiness);

#line default
#line hidden
            EndContext();
            BeginContext(678, 20, true);
            WriteLiteral("</td>\n          <td>");
            EndContext();
            BeginContext(699, 10, false);
#line 26 "/Users/makennamartin97/Documents/coding_dojo/csharpstack/chefsndishes/Views/Home/dishes.cshtml"
         Write(d.Calories);

#line default
#line hidden
            EndContext();
            BeginContext(709, 20, true);
            WriteLiteral("</td>\n        </tr>\n");
            EndContext();
#line 28 "/Users/makennamartin97/Documents/coding_dojo/csharpstack/chefsndishes/Views/Home/dishes.cshtml"
      }

#line default
#line hidden
            BeginContext(737, 28, true);
            WriteLiteral("    </tbody>\n</table>\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Dish>> Html { get; private set; }
    }
}
#pragma warning restore 1591
