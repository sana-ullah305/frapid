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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Content/Index.cshtml")]
    public partial class _Views_Content_Index_cshtml : System.Web.Mvc.WebViewPage<dynamic>
    {
        public _Views_Content_Index_cshtml()
        {
        }
        public override void Execute()
        {
            
            #line 3 "..\..\Views\Content\Index.cshtml"
  
    ViewBag.Title = "Content List";
    Layout = ViewBag.Layout;

            
            #line default
            #line hidden
WriteLiteral(@"

<script>
    var scrudFactory = new Object();

    scrudFactory.title = ""Contents"";

    scrudFactory.viewAPI = ""/api/views/website/content-scrud-view"";
    scrudFactory.viewTableName = ""website.content_scrud_view"";

    scrudFactory.formAPI = ""/api/forms/website/contents"";
    scrudFactory.formTableName = ""website.contents"";

    scrudFactory.excludedColumns = [""audit_user_id"", ""audit_ts"", ""contents"", ""markdown""];

    scrudFactory.allowDelete = true;
    scrudFactory.allowEdit = true;
    scrudFactory.addNewUrl = ""contents/manage?ReturnUrl="" + encodeURIComponent(location.pathname + location.search);
    scrudFactory.editUrl = ""contents/manage?ReturnUrl="" + encodeURIComponent(location.pathname + location.search) + ""&ContentId="";

    scrudFactory.card = {
        header: ""title"",
        meta: ""alias"",
        description: ""seo_description""
    };    

    $.get('/ScrudFactory/View.html', function (view) {
        $(""#ScrudFactoryView"").html(view);
        $.cachedScript(""/assets/js/scrudfactory-view.js"");
    });
</script>

<div");

WriteLiteral(" id=\"ScrudFactoryForm\"");

WriteLiteral("></div>\r\n<div");

WriteLiteral(" id=\"ScrudFactoryView\"");

WriteLiteral("></div>");

        }
    }
}
#pragma warning restore 1591
