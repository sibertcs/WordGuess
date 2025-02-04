#pragma checksum "C:\Users\Student\Projects\Hangman_Game\Views\Game\CurrentGame.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a652bdcc671ee6099355dac65337b875245fc36a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Game_CurrentGame), @"mvc.1.0.view", @"/Views/Game/CurrentGame.cshtml")]
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
#line 1 "C:\Users\Student\Projects\Hangman_Game\Views\_ViewImports.cshtml"
using Hangman_Game;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Student\Projects\Hangman_Game\Views\_ViewImports.cshtml"
using Hangman_Game.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a652bdcc671ee6099355dac65337b875245fc36a", @"/Views/Game/CurrentGame.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bd171c2b416b34659e598aebeb3772f1e32d133e", @"/Views/_ViewImports.cshtml")]
    public class Views_Game_CurrentGame : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WordGuessGame>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Game", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "MakePlay", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("display: inline"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Student\Projects\Hangman_Game\Views\Game\CurrentGame.cshtml"
  
    ViewData["Title"] = "CurrentGame";
    //string name = ViewData["name"].ToString();
    int score = Convert.ToInt32(ViewData["score"]);
    int roundNumber = Convert.ToInt32(ViewData["roundNumber"]);
    bool isGuessRight = Convert.ToBoolean(ViewData["isCorrectLetter"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<section class=\"content\">\r\n    <h1 class=\"title\">10 Word Guess!</h1>\r\n    <div class=\"game_container\">\r\n        <div class=\"clipart\">\r\n            <img");
            BeginWriteAttribute("src", " src=", 463, "", 549, 1);
#nullable restore
#line 14 "C:\Users\Student\Projects\Hangman_Game\Views\Game\CurrentGame.cshtml"
WriteAttributeValue("", 468, isGuessRight ? "/Images/happy_controller.jpg" : "/Images/upset_controller.jpg", 468, 81, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n        </div>\r\n        <div class=\"form\">\r\n            <div class=\"scoreboard\">\r\n                <h4><strong>Score:</strong> ");
#nullable restore
#line 18 "C:\Users\Student\Projects\Hangman_Game\Views\Game\CurrentGame.cshtml"
                                       Write(score);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                <h4><strong>Round:</strong> ");
#nullable restore
#line 19 "C:\Users\Student\Projects\Hangman_Game\Views\Game\CurrentGame.cshtml"
                                       Write(roundNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral(" / 10</h4>\r\n                <h4><strong>Guesses Left:</strong> ");
#nullable restore
#line 20 "C:\Users\Student\Projects\Hangman_Game\Views\Game\CurrentGame.cshtml"
                                              Write(Model.Counter.GuessesRemaining);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n            </div>\r\n            <h3>\r\n");
#nullable restore
#line 23 "C:\Users\Student\Projects\Hangman_Game\Views\Game\CurrentGame.cshtml"
                 foreach (Char character in Model.SecretWord)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <span>");
#nullable restore
#line 25 "C:\Users\Student\Projects\Hangman_Game\Views\Game\CurrentGame.cshtml"
                     Write(character);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n");
#nullable restore
#line 26 "C:\Users\Student\Projects\Hangman_Game\Views\Game\CurrentGame.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </h3>\r\n            <div class =\"button-form\">\r\n");
#nullable restore
#line 29 "C:\Users\Student\Projects\Hangman_Game\Views\Game\CurrentGame.cshtml"
                 for (int i = 0; i <= Model.PossibleLetters.Length - 1; i++)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a652bdcc671ee6099355dac65337b875245fc36a7611", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 32 "C:\Users\Student\Projects\Hangman_Game\Views\Game\CurrentGame.cshtml"
                         if (!Model.Guesses.Contains(Model.PossibleLetters[i]))
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <div class=\"form-group\">\r\n                                <input type=\"hidden\"");
                BeginWriteAttribute("value", " value=\"", 1514, "\"", 1524, 1);
#nullable restore
#line 35 "C:\Users\Student\Projects\Hangman_Game\Views\Game\CurrentGame.cshtml"
WriteAttributeValue("", 1522, i, 1522, 2, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" name=\"index\" />\r\n                                <input class=\"button\" type=\"submit\"");
                BeginWriteAttribute("value", " value=\"", 1610, "\"", 1643, 1);
#nullable restore
#line 36 "C:\Users\Student\Projects\Hangman_Game\Views\Game\CurrentGame.cshtml"
WriteAttributeValue("", 1618, Model.PossibleLetters[i], 1618, 25, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                            </div>\r\n");
#nullable restore
#line 38 "C:\Users\Student\Projects\Hangman_Game\Views\Game\CurrentGame.cshtml"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <div class=\"form-group\">\r\n                                <input type=\"hidden\"");
                BeginWriteAttribute("value", " value=\"", 1875, "\"", 1885, 1);
#nullable restore
#line 42 "C:\Users\Student\Projects\Hangman_Game\Views\Game\CurrentGame.cshtml"
WriteAttributeValue("", 1883, i, 1883, 2, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" name=\"index\" />\r\n                                <input class=\"button disabled\" type=\"submit\"");
                BeginWriteAttribute("value", " value=\"", 1980, "\"", 2013, 1);
#nullable restore
#line 43 "C:\Users\Student\Projects\Hangman_Game\Views\Game\CurrentGame.cshtml"
WriteAttributeValue("", 1988, Model.PossibleLetters[i], 1988, 25, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" disabled />\r\n                            </div>\r\n");
#nullable restore
#line 45 "C:\Users\Student\Projects\Hangman_Game\Views\Game\CurrentGame.cshtml"
                       }

#line default
#line hidden
#nullable disable
                WriteLiteral("                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 47 "C:\Users\Student\Projects\Hangman_Game\Views\Game\CurrentGame.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n        </div>\r\n    </div>\r\n</section>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WordGuessGame> Html { get; private set; }
    }
}
#pragma warning restore 1591
