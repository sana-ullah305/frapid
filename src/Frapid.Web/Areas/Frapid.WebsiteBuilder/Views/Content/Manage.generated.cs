﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ASP
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Text;
    using System.Web;
    using System.Web.Helpers;
    using System.Web.Mvc;
    using System.Web.Mvc.Ajax;
    using System.Web.Mvc.Html;
    using System.Web.Routing;
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.WebPages;
    using DevTrends.MvcDonutCaching;
    using Frapid.Web;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Content/Manage.cshtml")]
    public partial class _Views_Content_Manage_cshtml : System.Web.Mvc.WebViewPage<Frapid.WebsiteBuilder.DTO.Content>
    {
        public _Views_Content_Manage_cshtml()
        {
        }
        public override void Execute()
        {
            
            #line 3 "..\..\Views\Content\Manage.cshtml"
  
    bool isMarkDown = !string.IsNullOrWhiteSpace(Model.Markdown);
    ViewBag.Title = Model.Title;
    Layout = ViewBag.Layout;

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n<script");

WriteLiteral(" src=\"/Scripts/ace-1.2.2/src-min-noconflict/ace.js\"");

WriteLiteral("></script>\r\n<script");

WriteLiteral(" src=\"/Scripts/marked-0.3.5/lib/marked.js\"");

WriteLiteral("></script>\r\n<style>\r\n    #editor {\r\n        position: absolute;\r\n        top: 0;\r" +
"\n        right: 0;\r\n        bottom: 0;\r\n        left: 0;\r\n    }\r\n</style>\r\n<div");

WriteLiteral(" class=\"ui attached segment\"");

WriteLiteral(" style=\"height: 100%;\"");

WriteLiteral(">\r\n    <div");

WriteLiteral(" class=\"ui stackable divided doubling grid\"");

WriteLiteral(" style=\"height: 100%;\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"three wide column\"");

WriteLiteral(">\r\n            <div");

WriteLiteral(" class=\"ui one column grid\"");

WriteLiteral(">\r\n                <div");

WriteLiteral(" class=\"right aligned column\"");

WriteLiteral(">\r\n                    <button");

WriteLiteral(" class=\"ui icon basic violet circular button\"");

WriteLiteral(" onclick=\"maximize(\'editor\', \'\');\"");

WriteLiteral(">\r\n                        <i");

WriteLiteral(" class=\"code icon\"");

WriteLiteral("></i>\r\n                    </button>\r\n                    <button");

WriteLiteral(" class=\"ui icon violet circular button\"");

WriteLiteral(" onclick=\"maximize(\'preview\', \'\');\"");

WriteLiteral(">\r\n                        <i");

WriteLiteral(" class=\"expand icon\"");

WriteLiteral("></i>\r\n                    </button>\r\n                </div>\r\n            </div>\r" +
"\n            <div");

WriteLiteral(" class=\"column\"");

WriteLiteral(">\r\n                <div");

WriteLiteral(" class=\"ui violet header\"");

WriteLiteral(">Save This Page</div>\r\n            </div>\r\n            <div");

WriteLiteral(" class=\"ui divider\"");

WriteLiteral("></div>\r\n            <div wi");

WriteLiteral(" class=\"ui form\"");

WriteLiteral(">\r\n                <input");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" data-entity=\"content_id\"");

WriteLiteral(" class=\"integer\"");

WriteAttribute("value", Tuple.Create(" value=\"", 1435), Tuple.Create("\"", 1459)
            
            #line 38 "..\..\Views\Content\Manage.cshtml"
     , Tuple.Create(Tuple.Create("", 1443), Tuple.Create<System.Object, System.Int32>(Model.ContentId
            
            #line default
            #line hidden
, 1443), false)
);

WriteLiteral(" />\r\n                <input");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" data-entity=\"markdown\"");

WriteAttribute("value", Tuple.Create(" value=\"", 1524), Tuple.Create("\"", 1547)
            
            #line 39 "..\..\Views\Content\Manage.cshtml"
, Tuple.Create(Tuple.Create("", 1532), Tuple.Create<System.Object, System.Int32>(Model.Markdown
            
            #line default
            #line hidden
, 1532), false)
);

WriteLiteral(" />\r\n                <div");

WriteLiteral(" class=\"\"");

WriteLiteral(">\r\n                    <div");

WriteLiteral(" class=\"field\"");

WriteLiteral(">\r\n                        <label>Title</label>\r\n                        <input");

WriteLiteral(" type=\"text\"");

WriteLiteral(" data-entity=\"title\"");

WriteAttribute("value", Tuple.Create(" value=\"", 1734), Tuple.Create("\"", 1754)
            
            #line 43 "..\..\Views\Content\Manage.cshtml"
, Tuple.Create(Tuple.Create("", 1742), Tuple.Create<System.Object, System.Int32>(Model.Title
            
            #line default
            #line hidden
, 1742), false)
);

WriteLiteral(" required=\"\"");

WriteLiteral(" />\r\n                    </div>\r\n                    <div");

WriteLiteral(" class=\"field\"");

WriteLiteral(">\r\n                        <label>Alias</label>\r\n                        <input");

WriteLiteral(" type=\"text\"");

WriteLiteral(" data-entity=\"alias\"");

WriteAttribute("value", Tuple.Create(" value=\"", 1949), Tuple.Create("\"", 1969)
            
            #line 47 "..\..\Views\Content\Manage.cshtml"
, Tuple.Create(Tuple.Create("", 1957), Tuple.Create<System.Object, System.Int32>(Model.Alias
            
            #line default
            #line hidden
, 1957), false)
);

WriteLiteral(" required=\"\"");

WriteLiteral(" />\r\n                    </div>\r\n                    <div");

WriteLiteral(" class=\"field\"");

WriteLiteral(">\r\n                        <label>Category</label>\r\n                        <sele" +
"ct");

WriteLiteral(" id=\"CategorySelect\"");

WriteLiteral(" class=\"ui search integer dropdown\"");

WriteLiteral("\r\n                                data-entity=\"category_id\"");

WriteLiteral("\r\n                                required=\"\"");

WriteLiteral("\r\n                                data-placeholder=\"true\"");

WriteLiteral("\r\n                                data-api=\"/api/forms/website/categories/display" +
"-fields\"");

WriteLiteral("\r\n                                data-api-value-field=\"Value\"");

WriteLiteral("\r\n                                data-api-key-field=\"Key\"");

WriteLiteral("\r\n                                data-api-selected-value=\"");

            
            #line 58 "..\..\Views\Content\Manage.cshtml"
                                                    Write(Model.CategoryId);

            
            #line default
            #line hidden
WriteLiteral("\"");

WriteLiteral("></select>\r\n                    </div>\r\n                    <div");

WriteLiteral(" class=\"field\"");

WriteLiteral(">\r\n                        <label>Tags</label>\r\n                        <select");

WriteLiteral(" id=\"TagsSelect\"");

WriteLiteral(" class=\"ui fluid multiple search selection tag dropdown\"");

WriteLiteral("\r\n                                data-entity=\"tags\"");

WriteLiteral("\r\n                                data-api=\"/api/views/website/tag-view/all\"");

WriteLiteral("\r\n                                data-api-value-field=\"Tag\"");

WriteLiteral("\r\n                                data-api-key-field=\"Tag\"");

WriteLiteral("\r\n                                data-api-selected-values=\"");

            
            #line 67 "..\..\Views\Content\Manage.cshtml"
                                                     Write(Model.Tags);

            
            #line default
            #line hidden
WriteLiteral("\"");

WriteLiteral("\r\n                                multiple=\"\"");

WriteLiteral("></select>\r\n                    </div>\r\n                    <div");

WriteLiteral(" class=\"field\"");

WriteLiteral(">\r\n                        <label>Publish On</label>\r\n                        <in" +
"put");

WriteLiteral(" type=\"date\"");

WriteLiteral(" class=\"date\"");

WriteLiteral(" data-entity=\"publish_on\"");

WriteAttribute("value", Tuple.Create(" value=\"", 3442), Tuple.Create("\"", 3480)
            
            #line 72 "..\..\Views\Content\Manage.cshtml"
        , Tuple.Create(Tuple.Create("", 3450), Tuple.Create<System.Object, System.Int32>(Model.PublishOn.ToString("d")
            
            #line default
            #line hidden
, 3450), false)
);

WriteLiteral(" required=\"\"");

WriteLiteral(" />\r\n                    </div>\r\n                    <div");

WriteLiteral(" class=\"field\"");

WriteLiteral(">\r\n                        <label>Seo Description</label>\r\n                      " +
"  <input");

WriteLiteral(" type=\"text\"");

WriteLiteral(" data-entity=\"seo_description\"");

WriteAttribute("value", Tuple.Create(" value=\"", 3695), Tuple.Create("\"", 3724)
            
            #line 76 "..\..\Views\Content\Manage.cshtml"
, Tuple.Create(Tuple.Create("", 3703), Tuple.Create<System.Object, System.Int32>(Model.SeoDescription
            
            #line default
            #line hidden
, 3703), false)
);

WriteLiteral(" required=\"\"");

WriteLiteral(" />\r\n                    </div>\r\n                </div>\r\n                <div");

WriteLiteral(" class=\"field\"");

WriteLiteral(">\r\n                    <label>&nbsp;</label>\r\n                    <div");

WriteLiteral(" class=\"ui checkbox\"");

WriteLiteral(">\r\n");

WriteLiteral("                        ");

            
            #line 82 "..\..\Views\Content\Manage.cshtml"
                   Write(Html.CheckBox("IsDraftInputCheckbox", Model.IsDraft, new { @id = "IsDraftInputCheckbox", @data_entity = "is_draft" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n                        <label");

WriteLiteral(" for=\"IsDraftInputCheckbox\"");

WriteLiteral(">Draft</label>\r\n                    </div>\r\n                    <div");

WriteLiteral(" class=\"ui checkbox\"");

WriteLiteral(">\r\n");

WriteLiteral("                        ");

            
            #line 86 "..\..\Views\Content\Manage.cshtml"
                   Write(Html.CheckBox("IsHomePageInputCheckbox", Model.IsHomepage, new { @id = "IsHomePageInputCheckbox", @data_entity = "is_homepage" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n                        <label");

WriteLiteral(" for=\"IsHomePageInputCheckbox\"");

WriteLiteral(">Home Page</label>\r\n                    </div>\r\n                    <div");

WriteLiteral(" class=\"ui checkbox\"");

WriteLiteral(">\r\n");

WriteLiteral("                        ");

            
            #line 90 "..\..\Views\Content\Manage.cshtml"
                   Write(Html.CheckBox("IsMarkdownInputCheckbox", isMarkDown, new { @id = "IsMarkdownInputCheckbox" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n                        <label");

WriteLiteral(" for=\"IsMarkdownInputCheckbox\"");

WriteLiteral(">Is Markdown</label>\r\n                    </div>\r\n                </div>\r\n       " +
"         <div");

WriteLiteral(" class=\"ui basic buttons\"");

WriteLiteral(">\r\n                    <button");

WriteLiteral(" class=\"ui basic button\"");

WriteLiteral(" id=\"SaveButton\"");

WriteLiteral(">Save</button>\r\n                    <a");

WriteLiteral(" class=\"ui basic button\"");

WriteLiteral(" id=\"CancelButton\"");

WriteLiteral(">Cancel</a>\r\n                </div>\r\n            </div>\r\n\r\n            <div");

WriteLiteral(" class=\"ui container\"");

WriteLiteral(">\r\n                <div");

WriteLiteral(" class=\"error vpad8 initially hidden\"");

WriteLiteral(">\r\n                    <div");

WriteLiteral(" class=\"ui brown header\"");

WriteLiteral(">Error</div>\r\n                    <div");

WriteLiteral(" class=\"ui red bulleted list\"");

WriteLiteral(">\r\n                    </div>\r\n                    <div");

WriteLiteral(" class=\"ui divider\"");

WriteLiteral("></div>\r\n                </div>\r\n            </div>\r\n\r\n        </div>\r\n        <d" +
"iv");

WriteLiteral(" class=\"thirteen wide column\"");

WriteLiteral(" style=\"height: 100%;\"");

WriteLiteral(">\r\n            <div");

WriteLiteral(" class=\"ui stackable two column divided grid\"");

WriteLiteral(" style=\"height: 100%;\"");

WriteLiteral(">\r\n                <div");

WriteLiteral(" class=\"column\"");

WriteLiteral(" data-target=\"editor\"");

WriteLiteral(" style=\"height: 100%;\"");

WriteLiteral(">\r\n                    <div");

WriteLiteral(" id=\"editor\"");

WriteLiteral(">\r\n                    </div>\r\n                </div>\r\n                <div");

WriteLiteral(" class=\"column\"");

WriteLiteral(" style=\"height: 100%; overflow: auto;\"");

WriteLiteral(" data-target=\"preview\"");

WriteLiteral(">\r\n                    <div");

WriteLiteral(" id=\"content\"");

WriteLiteral(" class=\"body\"");

WriteLiteral(" data-entity=\"contents\"");

WriteLiteral(" data-raw=\"true\"");

WriteLiteral(">\r\n                    </div>\r\n                </div>\r\n            </div>\r\n\r\n    " +
"    </div>\r\n    </div>\r\n</div>\r\n\r\n<script>\r\n    var html = \"");

            
            #line 127 "..\..\Views\Content\Manage.cshtml"
           Write(Html.Encode(HttpUtility.JavaScriptStringEncode(Model.Contents)));

            
            #line default
            #line hidden
WriteLiteral("\";\r\n</script>\r\n\r\n\r\n<script");

WriteAttribute("src", Tuple.Create(" src=\"", 6134), Tuple.Create("\"", 6202)
, Tuple.Create(Tuple.Create("", 6140), Tuple.Create<System.Object, System.Int32>(Href("~/Areas/Frapid.WebsiteBuilder/Scripts/Contents/EntityParser.js")
, 6140), false)
);

WriteLiteral("></script>\r\n<script");

WriteAttribute("src", Tuple.Create(" src=\"", 6222), Tuple.Create("\"", 6284)
, Tuple.Create(Tuple.Create("", 6228), Tuple.Create<System.Object, System.Int32>(Href("~/Areas/Frapid.WebsiteBuilder/Scripts/Contents/Manage.js")
, 6228), false)
);

WriteLiteral("></script>\r\n");

        }
    }
}
#pragma warning restore 1591
