#pragma checksum "I:\SEMESTR 2\NET\Projekt\CompanyManagement\Views\Managers\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ffa33e5850fde2ff85bd5b0cd6c3a1f0b5b5c37f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Managers_Create), @"mvc.1.0.view", @"/Views/Managers/Create.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Managers/Create.cshtml", typeof(AspNetCore.Views_Managers_Create))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ffa33e5850fde2ff85bd5b0cd6c3a1f0b5b5c37f", @"/Views/Managers/Create.cshtml")]
    public class Views_Managers_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2451, true);
            WriteLiteral(@"<!-- Content Header (Page header) -->
<section class=""content-header"">
    <h1>
    Managers
    </h1>
</section>
<!-- Main content -->
<section class=""content container-fluid"">
    <!-- Horizontal Form -->
    <div class=""box box-info"">
    <div class=""box-header with-border"">
        <h3 class=""box-title"">Add Manager</h3>
    </div>
    <!-- /.box-header -->
    <!-- form start -->
    <form class=""form-horizontal"" method=""post"" action=""CreateManager"">
        <div class=""box-body"">
        <div class=""form-group"">
            <label for=""inputEmail3"" class=""col-sm-2 control-label"">Name</label>
            <div class=""col-sm-10"">
            <input type=""text"" class=""form-control"" name=""Name"" placeholder=""Name"">
            </div>
        </div>
        <div class=""form-group"">
            <label for=""inputEmail3"" class=""col-sm-2 control-label"">Email</label>
            <div class=""col-sm-10"">
            <input type=""email"" class=""form-control"" name=""Email"" placeholder=""Email"">
            </div>
        <");
            WriteLiteral(@"/div>
        <div class=""form-group"">
            <label for=""inputPassword3"" class=""col-sm-2 control-label"">Password</label>
            <div class=""col-sm-10"">
            <input type=""password"" class=""form-control"" name=""Password"" placeholder=""Password"">
            </div>
        </div>
        <div class=""form-group"">
            <label for=""inputEmail3"" class=""col-sm-2 control-label"">Phone</label>
            <div class=""col-sm-10"">
            <input type=""text"" class=""form-control"" name=""Phone"" placeholder=""Phone"">
            </div>
        </div>
        <div class=""form-group"">
            <label for=""inputEmail3"" class=""col-sm-2 control-label"">Gender</label>
            <div class=""col-sm-10"">
            <input type=""text"" class=""form-control"" name=""Gender"" placeholder=""Gender"">
            </div>
        </div>
        <div class=""form-group"">
            <label for=""inputEmail3"" class=""col-sm-2 control-label"">Team</label>
            <div class=""col-sm-10"">
            <input type=""text"" class");
            WriteLiteral(@"=""form-control"" name=""Team"" placeholder=""Team"">
            </div>
        </div>
        </div>
        <!-- /.box-body -->
        <div class=""box-footer"">
        <button type=""submit"" class=""btn btn-default"">Cancel</button>
        <button type=""submit"" class=""btn btn-info pull-right"">Create</button>
        </div>
        <!-- /.box-footer -->
    </form>
    </div>
    <!-- /.box -->
</section>");
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
