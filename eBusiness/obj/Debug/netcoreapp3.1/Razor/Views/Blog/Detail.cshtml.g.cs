#pragma checksum "C:\Users\Lenovo\source\repos\eBusiness\eBusiness\Views\Blog\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "96bb9aea5d1a5c1663f381c1ddfabdc0da953a4d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Blog_Detail), @"mvc.1.0.view", @"/Views/Blog/Detail.cshtml")]
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
#line 1 "C:\Users\Lenovo\source\repos\eBusiness\eBusiness\Views\_ViewImports.cshtml"
using eBusiness;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Lenovo\source\repos\eBusiness\eBusiness\Views\_ViewImports.cshtml"
using eBusiness.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"96bb9aea5d1a5c1663f381c1ddfabdc0da953a4d", @"/Views/Blog/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4b482611c90c03b328d47f4fed7fb1cc86b57c63", @"/Views/_ViewImports.cshtml")]
    public class Views_Blog_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Blog>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("#"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/img/blog/1.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/img/blog/2.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/img/blog/3.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/img/blog/4.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/img/blog/b02.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("post-author"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Lenovo\source\repos\eBusiness\eBusiness\Views\Blog\Detail.cshtml"
  
    ViewData["Title"] = "Detail";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<main id=""main"">

    <!-- ======= Blog Header ======= -->
    <div class=""header-bg page-area"">
        <div class=""container position-relative"">
            <div class=""row"">
                <div class=""col-md-12 col-sm-12 col-xs-12"">
                    <div class=""slider-content text-center"">
                        <div class=""header-bottom"">
                            <div class=""layer2"">
                                <h1 class=""title2"">Blog Details </h1>
                            </div>
                            <div class=""layer3"">
                                <h2 class=""title3"">profesional Blog Page</h2>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div><!-- End Blog Header -->
    <!-- ======= Blog Page ======= -->
    <div class=""blog-page area-padding"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-lg-4 co");
            WriteLiteral("l-md-4\">\r\n                    <div class=\"page-head-blog\">\r\n                        <div class=\"single-blog-page\">\r\n                            <!-- search option start -->\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "96bb9aea5d1a5c1663f381c1ddfabdc0da953a4d7679", async() => {
                WriteLiteral(@"
                                <div class=""search-option"">
                                    <input type=""text"" placeholder=""Search..."">
                                    <button class=""button"" type=""submit"">
                                        <i class=""bi bi-search""></i>
                                    </button>
                                </div>
                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                            <!-- search option end -->
                        </div>
                        <div class=""single-blog-page"">
                            <!-- recent start -->
                            <div class=""left-blog"">
                                <h4>recent post</h4>
                                <div class=""recent-post"">
                                    <!-- start single post -->
                                    <div class=""recent-single-post"">
                                        <div class=""post-img"">
                                            <a href=""#"">
                                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "96bb9aea5d1a5c1663f381c1ddfabdc0da953a4d10082", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                            </a>
                                        </div>
                                        <div class=""pst-content"">
                                            <p><a href=""#""> Redug Lerse dolor sit amet consect adipis elit.</a></p>
                                        </div>
                                    </div>
                                    <!-- End single post -->
                                    <!-- start single post -->
                                    <div class=""recent-single-post"">
                                        <div class=""post-img"">
                                            <a href=""#"">
                                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "96bb9aea5d1a5c1663f381c1ddfabdc0da953a4d11946", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                            </a>
                                        </div>
                                        <div class=""pst-content"">
                                            <p><a href=""#""> Redug Lerse dolor sit amet consect adipis elit.</a></p>
                                        </div>
                                    </div>
                                    <!-- End single post -->
                                    <!-- start single post -->
                                    <div class=""recent-single-post"">
                                        <div class=""post-img"">
                                            <a href=""#"">
                                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "96bb9aea5d1a5c1663f381c1ddfabdc0da953a4d13810", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                            </a>
                                        </div>
                                        <div class=""pst-content"">
                                            <p><a href=""#""> Redug Lerse dolor sit amet consect adipis elit.</a></p>
                                        </div>
                                    </div>
                                    <!-- End single post -->
                                    <!-- start single post -->
                                    <div class=""recent-single-post"">
                                        <div class=""post-img"">
                                            <a href=""#"">
                                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "96bb9aea5d1a5c1663f381c1ddfabdc0da953a4d15674", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                            </a>
                                        </div>
                                        <div class=""pst-content"">
                                            <p><a href=""#""> Redug Lerse dolor sit amet consect adipis elit.</a></p>
                                        </div>
                                    </div>
                                    <!-- End single post -->
                                </div>
                            </div>
                            <!-- recent end -->
                        </div>
                        <div class=""single-blog-page"">
                            <div class=""left-blog"">
                                <h4>categories</h4>
                                <ul>
                                    <li>
                                        <a href=""#"">Portfolio</a>
                                    </li>
                                    <li>
                                   ");
            WriteLiteral(@"     <a href=""#"">Project</a>
                                    </li>
                                    <li>
                                        <a href=""#"">Design</a>
                                    </li>
                                    <li>
                                        <a href=""#"">wordpress</a>
                                    </li>
                                    <li>
                                        <a href=""#"">Joomla</a>
                                    </li>
                                    <li>
                                        <a href=""#"">Html</a>
                                    </li>
                                    <li>
                                        <a href=""#"">Website</a>
                                    </li>
                                </ul>
                            </div>
                        </div>
                        <div class=""single-blog-page"">
                            <div class=""l");
            WriteLiteral(@"eft-blog"">
                                <h4>archive</h4>
                                <ul>
                                    <li>
                                        <a href=""#"">07 July 2016</a>
                                    </li>
                                    <li>
                                        <a href=""#"">29 June 2016</a>
                                    </li>
                                    <li>
                                        <a href=""#"">13 May 2016</a>
                                    </li>
                                    <li>
                                        <a href=""#"">20 March 2016</a>
                                    </li>
                                    <li>
                                        <a href=""#"">09 Fabruary 2016</a>
                                    </li>
                                </ul>
                            </div>
                        </div>
                        <div class=""si");
            WriteLiteral(@"ngle-blog-page"">
                            <div class=""left-tags blog-tags"">
                                <div class=""popular-tag left-side-tags left-blog"">
                                    <h4>popular tags</h4>
                                    <ul>
                                        <li>
                                            <a href=""#"">Portfolio</a>
                                        </li>
                                        <li>
                                            <a href=""#"">Project</a>
                                        </li>
                                        <li>
                                            <a href=""#"">Design</a>
                                        </li>
                                        <li>
                                            <a href=""#"">wordpress</a>
                                        </li>
                                        <li>
                                            <a href=""#"">Jooml");
            WriteLiteral(@"a</a>
                                        </li>
                                        <li>
                                            <a href=""#"">Html</a>
                                        </li>
                                        <li>
                                            <a href=""#"">Masonry</a>
                                        </li>
                                        <li>
                                            <a href=""#"">Website</a>
                                        </li>
                                    </ul>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
                <!-- End left sidebar -->
                <!-- Start single blog -->
                <div class=""col-md-8 col-sm-8 col-xs-12"">
                    <div class=""row"">
                        <div class=""col-md-12 col-sm-12 col-xs-12"">
                            <!");
            WriteLiteral("-- single-blog start -->\r\n                            <article class=\"blog-post-wrapper\">\r\n                                <div class=\"post-thumbnail\">\r\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "96bb9aea5d1a5c1663f381c1ddfabdc0da953a4d22328", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 10089, "~/assets/img/blog/", 10089, 18, true);
#nullable restore
#line 195 "C:\Users\Lenovo\source\repos\eBusiness\eBusiness\Views\Blog\Detail.cshtml"
AddHtmlAttributeValue("", 10107, Model.Image, 10107, 12, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                </div>
                                <div class=""post-information"">
                                    <h2>Blog image post layout</h2>
                                    <div class=""entry-meta"">
                                        <span class=""author-meta""><i class=""bi bi-person""></i> <a href=""#"">");
#nullable restore
#line 200 "C:\Users\Lenovo\source\repos\eBusiness\eBusiness\Views\Blog\Detail.cshtml"
                                                                                                      Write(Model.Admin);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></span>\r\n                                        <span><i class=\"bi bi-clock\"></i> ");
#nullable restore
#line 201 "C:\Users\Lenovo\source\repos\eBusiness\eBusiness\Views\Blog\Detail.cshtml"
                                                                     Write(Model.Date);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
                                        <span class=""tag-meta"">
                                            <i class=""bi bi-folder""></i>
                                            <a href=""#"">painting</a>,
                                            <a href=""#"">work</a>
                                        </span>
                                        <span>
                                            <i class=""bi bi-tags""></i>
                                            <a href=""#"">tools</a>,
                                            <a href=""#""> Humer</a>,
                                            <a href=""#"">House</a>
                                        </span>
                                        <span><i class=""bi bi-chat""></i> <a href=""#"">6 comments</a></span>
                                    </div>
                                    <div class=""entry-content"">
                                        <p>
                                            ");
#nullable restore
#line 217 "C:\Users\Lenovo\source\repos\eBusiness\eBusiness\Views\Blog\Detail.cshtml"
                                       Write(Model.Desc);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </p>\r\n                                        <blockquote>\r\n                                            <p>\r\n                                                ");
#nullable restore
#line 221 "C:\Users\Lenovo\source\repos\eBusiness\eBusiness\Views\Blog\Detail.cshtml"
                                           Write(Model.Quote);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                            </p>
                                        </blockquote>
                                        <p>
                                            Aenean et tempor eros, vitae sollicitudin velit. Etiam varius enim nec quam tempor, sed efficitur ex ultrices. Phasellus pretium est vel dui vestibulum condimentum. Aenean nec suscipit nibh. Phasellus nec lacus id arcu facilisis elementum.
                                            Curabitur lobortis, elit ut elementum congue, erat ex bibendum odio, nec iaculis lacus sem non lorem. Duis suscipit metus ante, sed convallis quam posuere quis. Ut tincidunt eleifend odio, ac fringilla mi vehicula nec. Nunc vitae
                                            lacus eget lectus imperdiet tempus sed in dui. Nam molestie magna at risus consectetur, placerat suscipit justo dignissim. Sed vitae fringilla enim, nec ullamcorper arcu.
                                        </p>
                                    </div>
      ");
            WriteLiteral(@"                          </div>
                            </article>
                            <div class=""clear""></div>
                            <div class=""single-post-comments"">
                                <div class=""comments-area"">
                                    <div class=""comments-heading"">
");
#nullable restore
#line 236 "C:\Users\Lenovo\source\repos\eBusiness\eBusiness\Views\Blog\Detail.cshtml"
                                         if(Model.BlogComments.Count() != 0){

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <h3>");
#nullable restore
#line 237 "C:\Users\Lenovo\source\repos\eBusiness\eBusiness\Views\Blog\Detail.cshtml"
                                       Write(Model.BlogComments.Count());

#line default
#line hidden
#nullable disable
            WriteLiteral(" comments</h3>\r\n");
#nullable restore
#line 238 "C:\Users\Lenovo\source\repos\eBusiness\eBusiness\Views\Blog\Detail.cshtml"
                                        }else{

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <h3>There is no comment</h3>\r\n");
#nullable restore
#line 240 "C:\Users\Lenovo\source\repos\eBusiness\eBusiness\Views\Blog\Detail.cshtml"
                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    </div>\r\n                                    <div class=\"comments-list\">\r\n                                        <ul>\r\n");
#nullable restore
#line 244 "C:\Users\Lenovo\source\repos\eBusiness\eBusiness\Views\Blog\Detail.cshtml"
                                             foreach(BlogComment comment in Model.BlogComments){

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                            <li>
                                                <div class=""comments-details"">
                                                    <div class=""comments-list-img"">
                                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "96bb9aea5d1a5c1663f381c1ddfabdc0da953a4d29907", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                                    </div>
                                                    <div class=""comments-content-wrap"">
                                                        <span>
                                                            <b><a href=""#"">");
#nullable restore
#line 252 "C:\Users\Lenovo\source\repos\eBusiness\eBusiness\Views\Blog\Detail.cshtml"
                                                                      Write(comment.User);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></b>\r\n                                                            Post author\r\n                                                            <span class=\"post-time\">");
#nullable restore
#line 254 "C:\Users\Lenovo\source\repos\eBusiness\eBusiness\Views\Blog\Detail.cshtml"
                                                                               Write(comment.Date.ToString("dd,MMMM,yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </span>\r\n                                                            <a href=\"#\">Reply</a>\r\n                                                        </span>\r\n                                                        <p>");
#nullable restore
#line 257 "C:\Users\Lenovo\source\repos\eBusiness\eBusiness\Views\Blog\Detail.cshtml"
                                                      Write(comment.Desc);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                                    </div>\r\n                                                </div>\r\n                                            </li>\r\n");
#nullable restore
#line 261 "C:\Users\Lenovo\source\repos\eBusiness\eBusiness\Views\Blog\Detail.cshtml"
                                            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                        </ul>
                                    </div>
                                </div>
                                <div class=""comment-respond"">
                                    <h3 class=""comment-reply-title"">Leave a Reply </h3>
                                    <span class=""email-notes"">Your email address will not be published. Required fields are marked *</span>
                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "96bb9aea5d1a5c1663f381c1ddfabdc0da953a4d33448", async() => {
                WriteLiteral(@"
                                        <div class=""row"">
                                            <div class=""col-lg-4 col-md-4"">
                                                <p>Name *</p>
                                                <input type=""text"" />
                                            </div>
                                            <div class=""col-lg-4 col-md-4"">
                                                <p>Email *</p>
                                                <input type=""email"" />
                                            </div>
                                            <div class=""col-lg-4 col-md-4"">
                                                <p>Website</p>
                                                <input type=""text"" />
                                            </div>
                                            <div class=""col-lg-12 col-md-12 col-sm-12 comment-form-comment"">
                                                <p>Website</p");
                WriteLiteral(@">
                                                <textarea id=""message-box"" cols=""30"" rows=""10""></textarea>
                                                <input type=""submit"" value=""Post Comment"" />
                                            </div>
                                        </div>
                                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                </div>
                            </div>
                            <!-- single-blog end -->
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div><!-- End Blog Page -->

</main><!-- End #main -->
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Blog> Html { get; private set; }
    }
}
#pragma warning restore 1591
