#pragma checksum "/Users/shehryarkhan/Projects/Dynamic User-Defined Dashboards/Views/Dashboard/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6979ac5deba9ea6c7a88572414355c48ede21e63"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Dashboard_Index), @"mvc.1.0.view", @"/Views/Dashboard/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Dashboard/Index.cshtml", typeof(AspNetCore.Views_Dashboard_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6979ac5deba9ea6c7a88572414355c48ede21e63", @"/Views/Dashboard/Index.cshtml")]
    public class Views_Dashboard_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 1345, true);
            WriteLiteral(@"<style>
   #dashboard {
  align: center;  
  width: auto; 
  padding-left: 60px;
  padding-right: 60px;
  padding-top: 60px;
  padding-bottom: 60px;
}
#b {
    height: 500px;
}
</style>

<div align=""center""   class=""row"">
    <div class=""col-lg-12"">
        <div id=""b"" class=""white-box m-t-30 center-block"">
            <form id=""dashboard"" >
                <h1 class="""" >Welcome to Dashboard Wizard</h1>
                <div class=""form-group"">
                    <label for=""exampleInputkwh"">Enter Dashboard Name</label>
                    <div class=""input-group"">
                        <div class=""input-group-addon""><i class=""fa fa-dashboard""></i></div>
                        <input type=""text"" class=""form-control"" id=""dashboard-name"" name=""dashboard-name""/> 
                    </div>
                    <br>
                    <div align=""center"">
                        <button type=""button"" class=""btn custom-btn waves-effect waves-light"" data-dismiss=""modal"" data-toggle=""modal"" onclick=""DashboardTemp");
            WriteLiteral(@"lates()"">Next</button>
                    </div>
                </div>
            </form>
        </div>
    </div>
</div>

<script>
    function DashboardTemplates()
    {
        localStorage.setItem(""dashboard_name"", $(""#dashboard-name"").val());
        window.location = ""/Dashboard/TemplateList/"";
    }
</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
