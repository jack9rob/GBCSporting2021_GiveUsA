#pragma checksum "S:\Web Application Development\GBCSporting2021_GiveUsA\GBCSporting2021_GiveUsA\GBCSporting2021_GiveUsA\Views\TechIncident\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2924d62f2c2b507fec5a9ebbc0b80a4c9b8e8eb5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_TechIncident_List), @"mvc.1.0.view", @"/Views/TechIncident/List.cshtml")]
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
#line 1 "S:\Web Application Development\GBCSporting2021_GiveUsA\GBCSporting2021_GiveUsA\GBCSporting2021_GiveUsA\Views\_ViewImports.cshtml"
using GBCSporting2021_GiveUsA;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "S:\Web Application Development\GBCSporting2021_GiveUsA\GBCSporting2021_GiveUsA\GBCSporting2021_GiveUsA\Views\_ViewImports.cshtml"
using GBCSporting2021_GiveUsA.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2924d62f2c2b507fec5a9ebbc0b80a4c9b8e8eb5", @"/Views/TechIncident/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8027e112dec9acdf96b06b3d291df3f703682dbe", @"/Views/_ViewImports.cshtml")]
    public class Views_TechIncident_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Incident>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "SelectTechnician", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "TechIncident", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2924d62f2c2b507fec5a9ebbc0b80a4c9b8e8eb54845", async() => {
                WriteLiteral("\r\n    <button type=\"submit\">Switch Technician</button>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 8 "S:\Web Application Development\GBCSporting2021_GiveUsA\GBCSporting2021_GiveUsA\GBCSporting2021_GiveUsA\Views\TechIncident\List.cshtml"
 if (Model.Count() == 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h1>No Incidents</h1>\r\n");
#nullable restore
#line 11 "S:\Web Application Development\GBCSporting2021_GiveUsA\GBCSporting2021_GiveUsA\GBCSporting2021_GiveUsA\Views\TechIncident\List.cshtml"
}
else
{



#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <table class=""table"">
        <thead>
            <tr>
                <th>Title</th>
                <th>Customer Name</th>
                <th>Product Name</th>
                <th>Date Opened</th>
            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 26 "S:\Web Application Development\GBCSporting2021_GiveUsA\GBCSporting2021_GiveUsA\GBCSporting2021_GiveUsA\Views\TechIncident\List.cshtml"
             foreach (Incident incident in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>");
#nullable restore
#line 29 "S:\Web Application Development\GBCSporting2021_GiveUsA\GBCSporting2021_GiveUsA\GBCSporting2021_GiveUsA\Views\TechIncident\List.cshtml"
                   Write(incident.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 30 "S:\Web Application Development\GBCSporting2021_GiveUsA\GBCSporting2021_GiveUsA\GBCSporting2021_GiveUsA\Views\TechIncident\List.cshtml"
                   Write(incident.Customer.Firstname);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 30 "S:\Web Application Development\GBCSporting2021_GiveUsA\GBCSporting2021_GiveUsA\GBCSporting2021_GiveUsA\Views\TechIncident\List.cshtml"
                                                Write(incident.Customer.Lastname);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                    <td>");
#nullable restore
#line 31 "S:\Web Application Development\GBCSporting2021_GiveUsA\GBCSporting2021_GiveUsA\GBCSporting2021_GiveUsA\Views\TechIncident\List.cshtml"
                   Write(incident.Product.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 32 "S:\Web Application Development\GBCSporting2021_GiveUsA\GBCSporting2021_GiveUsA\GBCSporting2021_GiveUsA\Views\TechIncident\List.cshtml"
                   Write(incident.DateOpened.ToString("MM'/'dd'/'yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2924d62f2c2b507fec5a9ebbc0b80a4c9b8e8eb59231", async() => {
                WriteLiteral("Edit");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 34 "S:\Web Application Development\GBCSporting2021_GiveUsA\GBCSporting2021_GiveUsA\GBCSporting2021_GiveUsA\Views\TechIncident\List.cshtml"
                                                                             WriteLiteral(incident.IncidentId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 34 "S:\Web Application Development\GBCSporting2021_GiveUsA\GBCSporting2021_GiveUsA\GBCSporting2021_GiveUsA\Views\TechIncident\List.cshtml"
                                                                                                                   WriteLiteral(incident.Slug);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["slug"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-slug", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["slug"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 37 "S:\Web Application Development\GBCSporting2021_GiveUsA\GBCSporting2021_GiveUsA\GBCSporting2021_GiveUsA\Views\TechIncident\List.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n\r\n\r\n    </table>\r\n");
#nullable restore
#line 42 "S:\Web Application Development\GBCSporting2021_GiveUsA\GBCSporting2021_GiveUsA\GBCSporting2021_GiveUsA\Views\TechIncident\List.cshtml"

}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Incident>> Html { get; private set; }
    }
}
#pragma warning restore 1591
