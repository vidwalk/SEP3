#pragma checksum "C:\Users\Claudiu\Desktop\Programming\SEP3\CustomerSide\Tier1RazorPages\SEP3RazorClient\Pages\BookSeats.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5d3acca967c86dbcd48cd939a69a28b473a1f530"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(SEP3RazorClient.Pages.Pages_BookSeats), @"mvc.1.0.razor-page", @"/Pages/BookSeats.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/BookSeats.cshtml", typeof(SEP3RazorClient.Pages.Pages_BookSeats), @"{Choice}")]
namespace SEP3RazorClient.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\Claudiu\Desktop\Programming\SEP3\CustomerSide\Tier1RazorPages\SEP3RazorClient\Pages\_ViewImports.cshtml"
using SEP3RazorClient;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemMetadataAttribute("RouteTemplate", "{Choice}")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5d3acca967c86dbcd48cd939a69a28b473a1f530", @"/Pages/BookSeats.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0b00699c1bb9350bc761f67dbb1bdd3d3470c7ca", @"/Pages/_ViewImports.cshtml")]
    public class Pages_BookSeats : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "PickSeat", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "C:\Users\Claudiu\Desktop\Programming\SEP3\CustomerSide\Tier1RazorPages\SEP3RazorClient\Pages\BookSeats.cshtml"
  
    ViewData["Title"] = "Seats";
    ScheduledMovie sm = Model.Schedule.ElementAt(Model.Choice);
    string txt = "";
    int count = sm.Seats.Count;

#line default
#line hidden
            BeginContext(221, 104, true);
            WriteLiteral("\r\n<h2>Seats</h2>\r\n<div>\r\n    <h6 align=\"center\">SCREEN</h6>\r\n    <div>\r\n        <table align=\"center\">\r\n");
            EndContext();
#line 15 "C:\Users\Claudiu\Desktop\Programming\SEP3\CustomerSide\Tier1RazorPages\SEP3RazorClient\Pages\BookSeats.cshtml"
             for (int i = 0; i < count / 10; i++)
            {

#line default
#line hidden
            BeginContext(391, 18, true);
            WriteLiteral("            <tr>\r\n");
            EndContext();
#line 18 "C:\Users\Claudiu\Desktop\Programming\SEP3\CustomerSide\Tier1RazorPages\SEP3RazorClient\Pages\BookSeats.cshtml"
                 if (@sm.Seats.ElementAt(i * 10 + 0).Booked)
                {
                    txt = "red";
                }
                else
                {
                    txt = "green";
                }

#line default
#line hidden
            BeginContext(639, 19, true);
            WriteLiteral("                <td");
            EndContext();
            BeginWriteAttribute("class", " class=", 658, "", 669, 1);
#line 26 "C:\Users\Claudiu\Desktop\Programming\SEP3\CustomerSide\Tier1RazorPages\SEP3RazorClient\Pages\BookSeats.cshtml"
WriteAttributeValue("", 665, txt, 665, 4, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(669, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(672, 10, false);
#line 26 "C:\Users\Claudiu\Desktop\Programming\SEP3\CustomerSide\Tier1RazorPages\SEP3RazorClient\Pages\BookSeats.cshtml"
                           Write(i * 10 + 1);

#line default
#line hidden
            EndContext();
            BeginContext(683, 7, true);
            WriteLiteral("</td>\r\n");
            EndContext();
#line 27 "C:\Users\Claudiu\Desktop\Programming\SEP3\CustomerSide\Tier1RazorPages\SEP3RazorClient\Pages\BookSeats.cshtml"
                 if (@sm.Seats.ElementAt(i * 10 + 1).Booked)
                {
                    txt = "red";
                }
                else
                {
                    txt = "green";
                }

#line default
#line hidden
            BeginContext(920, 19, true);
            WriteLiteral("                <td");
            EndContext();
            BeginWriteAttribute("class", " class=", 939, "", 950, 1);
#line 35 "C:\Users\Claudiu\Desktop\Programming\SEP3\CustomerSide\Tier1RazorPages\SEP3RazorClient\Pages\BookSeats.cshtml"
WriteAttributeValue("", 946, txt, 946, 4, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(950, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(953, 10, false);
#line 35 "C:\Users\Claudiu\Desktop\Programming\SEP3\CustomerSide\Tier1RazorPages\SEP3RazorClient\Pages\BookSeats.cshtml"
                           Write(i * 10 + 2);

#line default
#line hidden
            EndContext();
            BeginContext(964, 7, true);
            WriteLiteral("</td>\r\n");
            EndContext();
#line 36 "C:\Users\Claudiu\Desktop\Programming\SEP3\CustomerSide\Tier1RazorPages\SEP3RazorClient\Pages\BookSeats.cshtml"
                 if (@sm.Seats.ElementAt(i * 10 + 2).Booked)
                {
                    txt = "red";
                }
                else
                {
                    txt = "green";
                }

#line default
#line hidden
            BeginContext(1201, 19, true);
            WriteLiteral("                <td");
            EndContext();
            BeginWriteAttribute("class", " class=", 1220, "", 1231, 1);
#line 44 "C:\Users\Claudiu\Desktop\Programming\SEP3\CustomerSide\Tier1RazorPages\SEP3RazorClient\Pages\BookSeats.cshtml"
WriteAttributeValue("", 1227, txt, 1227, 4, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1231, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(1234, 10, false);
#line 44 "C:\Users\Claudiu\Desktop\Programming\SEP3\CustomerSide\Tier1RazorPages\SEP3RazorClient\Pages\BookSeats.cshtml"
                           Write(i * 10 + 3);

#line default
#line hidden
            EndContext();
            BeginContext(1245, 7, true);
            WriteLiteral("</td>\r\n");
            EndContext();
#line 45 "C:\Users\Claudiu\Desktop\Programming\SEP3\CustomerSide\Tier1RazorPages\SEP3RazorClient\Pages\BookSeats.cshtml"
                 if (@sm.Seats.ElementAt(i * 10 + 3).Booked)
                {
                    txt = "red";
                }
                else
                {
                    txt = "green";
                }

#line default
#line hidden
            BeginContext(1482, 19, true);
            WriteLiteral("                <td");
            EndContext();
            BeginWriteAttribute("class", " class=", 1501, "", 1512, 1);
#line 53 "C:\Users\Claudiu\Desktop\Programming\SEP3\CustomerSide\Tier1RazorPages\SEP3RazorClient\Pages\BookSeats.cshtml"
WriteAttributeValue("", 1508, txt, 1508, 4, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1512, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(1515, 10, false);
#line 53 "C:\Users\Claudiu\Desktop\Programming\SEP3\CustomerSide\Tier1RazorPages\SEP3RazorClient\Pages\BookSeats.cshtml"
                           Write(i * 10 + 4);

#line default
#line hidden
            EndContext();
            BeginContext(1526, 7, true);
            WriteLiteral("</td>\r\n");
            EndContext();
#line 54 "C:\Users\Claudiu\Desktop\Programming\SEP3\CustomerSide\Tier1RazorPages\SEP3RazorClient\Pages\BookSeats.cshtml"
                 if (@sm.Seats.ElementAt(i * 10 + 4).Booked)
                {
                    txt = "red";
                }
                else
                {
                    txt = "green";
                }

#line default
#line hidden
            BeginContext(1763, 19, true);
            WriteLiteral("                <td");
            EndContext();
            BeginWriteAttribute("class", " class=", 1782, "", 1793, 1);
#line 62 "C:\Users\Claudiu\Desktop\Programming\SEP3\CustomerSide\Tier1RazorPages\SEP3RazorClient\Pages\BookSeats.cshtml"
WriteAttributeValue("", 1789, txt, 1789, 4, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1793, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(1796, 10, false);
#line 62 "C:\Users\Claudiu\Desktop\Programming\SEP3\CustomerSide\Tier1RazorPages\SEP3RazorClient\Pages\BookSeats.cshtml"
                           Write(i * 10 + 5);

#line default
#line hidden
            EndContext();
            BeginContext(1807, 7, true);
            WriteLiteral("</td>\r\n");
            EndContext();
#line 63 "C:\Users\Claudiu\Desktop\Programming\SEP3\CustomerSide\Tier1RazorPages\SEP3RazorClient\Pages\BookSeats.cshtml"
                 if (@sm.Seats.ElementAt(i * 10 + 5).Booked)
                {
                    txt = "red";
                }
                else
                {
                    txt = "green";
                }

#line default
#line hidden
            BeginContext(2044, 19, true);
            WriteLiteral("                <td");
            EndContext();
            BeginWriteAttribute("class", " class=", 2063, "", 2074, 1);
#line 71 "C:\Users\Claudiu\Desktop\Programming\SEP3\CustomerSide\Tier1RazorPages\SEP3RazorClient\Pages\BookSeats.cshtml"
WriteAttributeValue("", 2070, txt, 2070, 4, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2074, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(2077, 10, false);
#line 71 "C:\Users\Claudiu\Desktop\Programming\SEP3\CustomerSide\Tier1RazorPages\SEP3RazorClient\Pages\BookSeats.cshtml"
                           Write(i * 10 + 6);

#line default
#line hidden
            EndContext();
            BeginContext(2088, 7, true);
            WriteLiteral("</td>\r\n");
            EndContext();
#line 72 "C:\Users\Claudiu\Desktop\Programming\SEP3\CustomerSide\Tier1RazorPages\SEP3RazorClient\Pages\BookSeats.cshtml"
                 if (@sm.Seats.ElementAt(i * 10 + 6).Booked)
                {
                    txt = "red";
                }
                else
                {
                    txt = "green";
                }

#line default
#line hidden
            BeginContext(2325, 19, true);
            WriteLiteral("                <td");
            EndContext();
            BeginWriteAttribute("class", " class=", 2344, "", 2355, 1);
#line 80 "C:\Users\Claudiu\Desktop\Programming\SEP3\CustomerSide\Tier1RazorPages\SEP3RazorClient\Pages\BookSeats.cshtml"
WriteAttributeValue("", 2351, txt, 2351, 4, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2355, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(2358, 10, false);
#line 80 "C:\Users\Claudiu\Desktop\Programming\SEP3\CustomerSide\Tier1RazorPages\SEP3RazorClient\Pages\BookSeats.cshtml"
                           Write(i * 10 + 7);

#line default
#line hidden
            EndContext();
            BeginContext(2369, 7, true);
            WriteLiteral("</td>\r\n");
            EndContext();
#line 81 "C:\Users\Claudiu\Desktop\Programming\SEP3\CustomerSide\Tier1RazorPages\SEP3RazorClient\Pages\BookSeats.cshtml"
                 if (@sm.Seats.ElementAt(i * 10 + 7).Booked)
                {
                    txt = "red";
                }
                else
                {
                    txt = "green";
                }

#line default
#line hidden
            BeginContext(2606, 19, true);
            WriteLiteral("                <td");
            EndContext();
            BeginWriteAttribute("class", " class=", 2625, "", 2636, 1);
#line 89 "C:\Users\Claudiu\Desktop\Programming\SEP3\CustomerSide\Tier1RazorPages\SEP3RazorClient\Pages\BookSeats.cshtml"
WriteAttributeValue("", 2632, txt, 2632, 4, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2636, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(2639, 10, false);
#line 89 "C:\Users\Claudiu\Desktop\Programming\SEP3\CustomerSide\Tier1RazorPages\SEP3RazorClient\Pages\BookSeats.cshtml"
                           Write(i * 10 + 8);

#line default
#line hidden
            EndContext();
            BeginContext(2650, 7, true);
            WriteLiteral("</td>\r\n");
            EndContext();
#line 90 "C:\Users\Claudiu\Desktop\Programming\SEP3\CustomerSide\Tier1RazorPages\SEP3RazorClient\Pages\BookSeats.cshtml"
                 if (@sm.Seats.ElementAt(i * 10 + 8).Booked)
                {
                    txt = "red";
                }
                else
                {
                    txt = "green";
                }

#line default
#line hidden
            BeginContext(2887, 19, true);
            WriteLiteral("                <td");
            EndContext();
            BeginWriteAttribute("class", " class=", 2906, "", 2917, 1);
#line 98 "C:\Users\Claudiu\Desktop\Programming\SEP3\CustomerSide\Tier1RazorPages\SEP3RazorClient\Pages\BookSeats.cshtml"
WriteAttributeValue("", 2913, txt, 2913, 4, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2917, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(2920, 10, false);
#line 98 "C:\Users\Claudiu\Desktop\Programming\SEP3\CustomerSide\Tier1RazorPages\SEP3RazorClient\Pages\BookSeats.cshtml"
                           Write(i * 10 + 9);

#line default
#line hidden
            EndContext();
            BeginContext(2931, 7, true);
            WriteLiteral("</td>\r\n");
            EndContext();
#line 99 "C:\Users\Claudiu\Desktop\Programming\SEP3\CustomerSide\Tier1RazorPages\SEP3RazorClient\Pages\BookSeats.cshtml"
                 if (@sm.Seats.ElementAt(i * 10 + 9).Booked)
                {
                    txt = "red";
                }
                else
                {
                    txt = "green";
                }

#line default
#line hidden
            BeginContext(3168, 19, true);
            WriteLiteral("                <td");
            EndContext();
            BeginWriteAttribute("class", " class=", 3187, "", 3198, 1);
#line 107 "C:\Users\Claudiu\Desktop\Programming\SEP3\CustomerSide\Tier1RazorPages\SEP3RazorClient\Pages\BookSeats.cshtml"
WriteAttributeValue("", 3194, txt, 3194, 4, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3198, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(3201, 11, false);
#line 107 "C:\Users\Claudiu\Desktop\Programming\SEP3\CustomerSide\Tier1RazorPages\SEP3RazorClient\Pages\BookSeats.cshtml"
                           Write(i * 10 + 10);

#line default
#line hidden
            EndContext();
            BeginContext(3213, 26, true);
            WriteLiteral("</td>\r\n            </tr>\r\n");
            EndContext();
#line 109 "C:\Users\Claudiu\Desktop\Programming\SEP3\CustomerSide\Tier1RazorPages\SEP3RazorClient\Pages\BookSeats.cshtml"
            }

#line default
#line hidden
            BeginContext(3254, 49, true);
            WriteLiteral("        </table>\r\n    </div>\r\n    <div>\r\n        ");
            EndContext();
            BeginContext(3303, 389, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cfd411f2f2584da58d1909926aaed7da", async() => {
                BeginContext(3347, 78, true);
                WriteLiteral("\r\n            Use the slider or write directly the desired seat between 1 and ");
                EndContext();
                BeginContext(3427, 7, false);
#line 114 "C:\Users\Claudiu\Desktop\Programming\SEP3\CustomerSide\Tier1RazorPages\SEP3RazorClient\Pages\BookSeats.cshtml"
                                                                        Write(count-1);

#line default
#line hidden
                EndContext();
                BeginContext(3435, 32, true);
                WriteLiteral("\r\n            <br>\r\n            ");
                EndContext();
                BeginContext(3468, 21, false);
#line 116 "C:\Users\Claudiu\Desktop\Programming\SEP3\CustomerSide\Tier1RazorPages\SEP3RazorClient\Pages\BookSeats.cshtml"
       Write(Html.Hidden("Choice"));

#line default
#line hidden
                EndContext();
                BeginContext(3489, 102, true);
                WriteLiteral("\r\n            <label for=\"Seat Number\">Seat Number</label>\r\n            <input type = \"number\" min=\"1\"");
                EndContext();
                BeginWriteAttribute("max", " max=", 3591, "", 3606, 1);
#line 118 "C:\Users\Claudiu\Desktop\Programming\SEP3\CustomerSide\Tier1RazorPages\SEP3RazorClient\Pages\BookSeats.cshtml"
WriteAttributeValue("", 3596, count-1, 3596, 10, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(3606, 79, true);
                WriteLiteral(" name =\"SeatChoice\">\r\n            <button type=\"submit\">BOOK</button>\r\n        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3692, 52, true);
            WriteLiteral("\r\n    </div>\r\n    <div>\r\n        <h4 align=\"center\">");
            EndContext();
            BeginContext(3744, 41, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "eaf06d1245404a6f95dbb33598268dad", async() => {
                BeginContext(3764, 17, true);
                WriteLiteral("BACK TO HOME PAGE");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3785, 29, true);
            WriteLiteral("</h4>\r\n    </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SEP3RazorClient.Pages.SeatsModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<SEP3RazorClient.Pages.SeatsModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<SEP3RazorClient.Pages.SeatsModel>)PageContext?.ViewData;
        public SEP3RazorClient.Pages.SeatsModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
