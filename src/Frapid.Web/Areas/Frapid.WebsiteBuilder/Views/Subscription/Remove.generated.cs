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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Subscription/Remove.cshtml")]
    public partial class _Views_Subscription_Remove_cshtml : System.Web.Mvc.WebViewPage<dynamic>
    {
        public _Views_Subscription_Remove_cshtml()
        {
        }
        public override void Execute()
        {
            
            #line 1 "..\..\Views\Subscription\Remove.cshtml"
  
    ViewBag.Title = "Unsubscribe";
    Layout = ViewBag.LayoutPath + ViewBag.Layout;

            
            #line default
            #line hidden
WriteLiteral("\r\n<script");

WriteLiteral(" src=\"/Scripts/frapid/core/frapid-ajax.js\"");

WriteLiteral("></script>\r\n<script");

WriteLiteral(" src=\"/Scripts/frapid/utilities/validator.js\"");

WriteLiteral("></script>\r\n<script");

WriteLiteral(" src=\"/Scripts/frapid/utilities/form.js\"");

WriteLiteral("></script>\r\n\r\n<div");

WriteLiteral(" class=\"ui vertically padded basic segment\"");

WriteLiteral(">\r\n    <div");

WriteLiteral(" class=\"ui story container\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"ui grey header\"");

WriteLiteral(">Unsubscribe from our mailing list</div>\r\n        <div");

WriteLiteral(" class=\"ui divider\"");

WriteLiteral(@"></div>
        <p>
            We are sorry that you had this experience! <br/><br/>
            Although we want you to stay connected with us, it seems that you already made a choice. <br/>
            We appreciate your decision to not receive emails from our mailing list anymore. <br/>
        </p>
        <p>
            Once you confirm to unsubcribe, <strong>we won't send you</strong> automated emails anymore.
        </p>
        <div");

WriteLiteral(" class=\"ui center aligned page subscription grid\"");

WriteLiteral(">\r\n            <div");

WriteLiteral(" class=\"column\"");

WriteLiteral(">\r\n                <div");

WriteLiteral(" class=\"ui green header\"");

WriteLiteral(">We will miss you!</div>\r\n                <div");

WriteLiteral(" class=\"ui subscription form\"");

WriteLiteral(">\r\n                    <div");

WriteLiteral(" class=\"field\"");

WriteLiteral(">\r\n                        <div");

WriteLiteral(" class=\"ui input\"");

WriteLiteral(">\r\n                            <input");

WriteLiteral(" id=\"EmailAddressInputEmail\"");

WriteLiteral(" placeholder=\"Enter your email address to unsubscribe\"");

WriteLiteral(" type=\"email\"");

WriteLiteral(">\r\n                        </div>\r\n                    </div>\r\n                  " +
"  <div");

WriteLiteral(" class=\"field\"");

WriteLiteral(">\r\n                        <div");

WriteLiteral(" class=\"ui confirm email input\"");

WriteLiteral(">\r\n                            <input");

WriteLiteral(" id=\"ConfirmEmailAddressInputEmail\"");

WriteLiteral(" placeholder=\"Enter your email address here\"");

WriteLiteral(" type=\"email\"");

WriteLiteral(">\r\n                        </div>\r\n                    </div>\r\n                  " +
"  <div");

WriteLiteral(" class=\"field\"");

WriteLiteral(">\r\n                        <input");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" id=\"TokenHiddenInputHidden\"");

WriteAttribute("value", Tuple.Create(" value=\"", 1826), Tuple.Create("\"", 1848)
            
            #line 36 "..\..\Views\Subscription\Remove.cshtml"
, Tuple.Create(Tuple.Create("", 1834), Tuple.Create<System.Object, System.Int32>(ViewBag.Token
            
            #line default
            #line hidden
, 1834), false)
);

WriteLiteral("/>\r\n                    </div>\r\n                    <button");

WriteLiteral(" class=\"ui negative button\"");

WriteLiteral(" onclick=\"unsubscribe()\"");

WriteLiteral(">Unsubscribe Me</button>\r\n                    <button");

WriteLiteral(" class=\"ui positive button\"");

WriteLiteral(">Cancel</button>\r\n                </div>\r\n                <div");

WriteLiteral(" class=\"ui positive thank you message\"");

WriteLiteral(" style=\"display: none;\"");

WriteLiteral(">Thank you for unsubscribing.</div>\r\n            </div>\r\n        </div>\r\n    </di" +
"v>\r\n</div>\r\n<script");

WriteLiteral(" src=\"/Areas/Frapid.WebsiteBuilder/Scripts/Subscription/Remove.js\"");

WriteLiteral("></script>\r\n");

        }
    }
}
#pragma warning restore 1591
