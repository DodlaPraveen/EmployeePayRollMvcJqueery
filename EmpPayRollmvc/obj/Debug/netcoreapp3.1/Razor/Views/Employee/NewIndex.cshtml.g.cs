#pragma checksum "C:\Users\HP\Desktop\AJAX\EmpPayRollmvc\EmpPayRollmvc\Views\Employee\NewIndex.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8fe6308dbc249ffe21b34e7d1598ec7c64dff3bb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Employee_NewIndex), @"mvc.1.0.view", @"/Views/Employee/NewIndex.cshtml")]
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
#line 1 "C:\Users\HP\Desktop\AJAX\EmpPayRollmvc\EmpPayRollmvc\Views\_ViewImports.cshtml"
using EmpPayRollmvc;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\HP\Desktop\AJAX\EmpPayRollmvc\EmpPayRollmvc\Views\_ViewImports.cshtml"
using EmpPayRollmvc.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8fe6308dbc249ffe21b34e7d1598ec7c64dff3bb", @"/Views/Employee/NewIndex.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"154538f96e4399a7fdcd8a88787a95319633f527", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Employee_NewIndex : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<link rel=""stylesheet"" type=""text/css"" href=""https://cdn.datatables.net/1.12.1/css/jquery.dataTables.css"">
<h1 class=""text-center""><i class=""fas fa-comment-dollar text-success""></i>Employee Payroll</h1>
<div class=""column"">
    <div class=""a"">
        <a href=""#"" onclick=""CreateNew(); return false;"" class=""btn btn-primary"">Create New</a>
       ");
#nullable restore
#line 7 "C:\Users\HP\Desktop\AJAX\EmpPayRollmvc\EmpPayRollmvc\Views\Employee\NewIndex.cshtml"
  Write(Html.Partial("~/Views/Shared/_employee.cshtml"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
    </div>
    <div class=""b"">
        <br />
        <table id=""tblEmp"" class=""table"">
            <thead>
                <tr>
                    <th>EMPID</th>
                    <th>IMG</th>
                    <th>NAME</th>
                    <th>GENDER</th>
                    <th>DEPARTMENT</th>
                    <th>SALARY</th>
                    <th>START_DATE</th>
                    <th>NOTES</th>
                </tr>
            </thead>
            <tbody>
            </tbody>
        </table>
    </div>
</div>
<script type=""text/javascript"" src=""https://code.jquery.com/jquery-3.6.0.min.js""></script>
<script type=""text/javascript"" charset=""utf8"" src=""https://cdn.datatables.net/1.12.1/js/jquery.dataTables.js""></script>
<script type=""text/javascript"">
    var js = jQuery.noConflict(true);
    js(document).ready(function () {
       // alert();
        LoadEmployee();
    });
   
    function CreateNew() {
        ClearAll();
        $('#btnmodel').trigger('c");
            WriteLiteral(@"lick');
    }
    function ClearAll() {
        $('#txtEMPID').val('');
        $('#txtIMG').val('');
        $('#txtNAME').val('');
        $('#txtGENDER').val('');
        $('#txtDEPARTMENT').val('');
        $('#txtSALARY').val('');
        $('#txtSTART_DATE').val('');
        $('#txtNOTES').val('');
    }
    function Create() {
        var isproceed = true;
        var EMPID = $('#txtEMPID').val();
        var IMG = $('#txtIMG').val();
        var NAME = $('#txtNAME').val();
        var GENDER = $('#txtGENDER').val();
        var DEPARTMENT = $('#txtDEPARTMENT').val();
        var SALARY = $('#txtSALARY').val();
        var START_DATE = $('#txtSTART_DATE').val();
        var NOTES = $('#txtNOTES').val();

        if (NAME == '') {
            var isproceed = false;
            $('#txtNAME').css('border-color', 'red');
        }
        else {
            $('#txtNAME').css('border-color', '#ccc')
        }
        if (isproceed) {
            var empdata = new Object();
   ");
            WriteLiteral(@"         empdata.id = EMPID;
            empdata.img = IMG;
            empdata.name = NAME;
            empdata.gender = GENDER;
            empdata.department = DEPARTMENT;
            empdata.salary = SALARY;
            empdata.start_date = START_DATE;
            empdata.notes = NOTES;
            $.ajax({
                type: 'post',
                url: 'AddEmployee',
                data: empdata,
                success(data) {
                    if (data != null) {
                        alert('Data Saved Successfully')
                    }
                    else {
                        alert('Failed');
                    }
                },
               
            });
        }
    }
    function LoadEmployee() {
        var empdata = [];
        $.ajax({
            type: 'GET',
            url: 'GetAllEmployees',
            data: {},
            async: false,
            success(data) {
                if (data != null) {
                    $.each(");
            WriteLiteral(@"data, function (key, value) {
                        empdata.push([
                            value.EMPID, value.IMG, value.NAME, value.GENDER, value.DEPARTMENT,
                            value.SALARY, value.START_DATE, value.NOTES]);
                    });
                }
            },
            error() {
            }
        });

        js('#tblEmp').dataTable({
            destroy: true,
            data: empdata
        });
    }
</script>

");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
