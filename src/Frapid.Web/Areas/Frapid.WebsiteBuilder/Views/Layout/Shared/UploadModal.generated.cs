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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Layout/Shared/UploadModal.cshtml")]
    public partial class _Views_Layout_Shared_UploadModal_cshtml : System.Web.Mvc.WebViewPage<dynamic>
    {
        public _Views_Layout_Shared_UploadModal_cshtml()
        {
        }
        public override void Execute()
        {
WriteLiteral("<div");

WriteLiteral(" class=\"ui modal\"");

WriteLiteral(" id=\"UploadModal\"");

WriteLiteral(">\r\n    <i");

WriteLiteral(" class=\"close icon\"");

WriteLiteral("></i>\r\n    <div");

WriteLiteral(" class=\"header\"");

WriteLiteral(">\r\n        Upload a File\r\n    </div>\r\n    <div");

WriteLiteral(" class=\"content\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"ui basic segment\"");

WriteLiteral(" id=\"UploaderSegment\"");

WriteLiteral(">\r\n            <div");

WriteLiteral(" class=\"ui positive message\"");

WriteLiteral(" style=\"display: none;\"");

WriteLiteral(">\r\n                <div");

WriteLiteral(" class=\"ui small header\"");

WriteLiteral(">Awesome! Upload another file.</div>\r\n            </div>\r\n            <img");

WriteLiteral(" class=\"ui preview image vpad8\"");

WriteLiteral(" />\r\n            <div");

WriteLiteral(" class=\"ui uploader buttons\"");

WriteLiteral(">\r\n                <label");

WriteLiteral(" for=\"FileInputFile\"");

WriteLiteral(" class=\"ui positive button\"");

WriteLiteral(">Upload</label>\r\n                <button");

WriteLiteral(" class=\"ui negative close button\"");

WriteLiteral(" onclick=\"$(\'#UploadModal\').modal(\'hide\');\"");

WriteLiteral(">Close</button>\r\n                <input");

WriteLiteral(" id=\"FileInputFile\"");

WriteLiteral(" data-handler=\"\"");

WriteLiteral(" data-loader-id=\"UploaderSegment\"");

WriteLiteral("\r\n                       class=\"file\"");

WriteLiteral(" style=\"display: none\"");

WriteLiteral(" type=\"file\"");

WriteLiteral(">\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");

        }
    }
}
#pragma warning restore 1591
