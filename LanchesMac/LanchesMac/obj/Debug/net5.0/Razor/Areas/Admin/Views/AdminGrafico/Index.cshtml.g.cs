#pragma checksum "D:\_migra_net6\LanchesMac_Net5_Graficos\LanchesMac\LanchesMac\Areas\Admin\Views\AdminGrafico\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6c39740f119e28f2bde84ea7c4266ba29790151b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_AdminGrafico_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/AdminGrafico/Index.cshtml")]
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
#line 1 "D:\_migra_net6\LanchesMac_Net5_Graficos\LanchesMac\LanchesMac\Areas\Admin\Views\_ViewImports.cshtml"
using LanchesMac;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\_migra_net6\LanchesMac_Net5_Graficos\LanchesMac\LanchesMac\Areas\Admin\Views\_ViewImports.cshtml"
using LanchesMac.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\_migra_net6\LanchesMac_Net5_Graficos\LanchesMac\LanchesMac\Areas\Admin\Views\_ViewImports.cshtml"
using LanchesMac.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\_migra_net6\LanchesMac_Net5_Graficos\LanchesMac\LanchesMac\Areas\Admin\Views\_ViewImports.cshtml"
using ReflectionIT.Mvc.Paging;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\_migra_net6\LanchesMac_Net5_Graficos\LanchesMac\LanchesMac\Areas\Admin\Views\_ViewImports.cshtml"
using System.IO;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6c39740f119e28f2bde84ea7c4266ba29790151b", @"/Areas/Admin/Views/AdminGrafico/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"798c89ae1590f3f97cffe7393fc1f92d2ad95e33", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_AdminGrafico_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<title>\r\n    ");
#nullable restore
#line 2 "D:\_migra_net6\LanchesMac_Net5_Graficos\LanchesMac\LanchesMac\Areas\Admin\Views\AdminGrafico\Index.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" - Grafico de Vendas
</title>

<script type=""text/javascript"" src=""https://www.gstatic.com/charts/loader.js""></script>

<div id=""chart_div"" style=""width: 900px; height: 500px;""></div>

<script type=""text/javascript"">

    google.charts.load('current', {packages: ['corechart', 'bar']});
    google.charts.setOnLoadCallback(CarregaDados);

    function CarregaDados() {
        $.ajax({
            url: '");
#nullable restore
#line 16 "D:\_migra_net6\LanchesMac_Net5_Graficos\LanchesMac\LanchesMac\Areas\Admin\Views\AdminGrafico\Index.cshtml"
             Write(Url.Action("VendasLanches", "AdminGrafico"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"',
            data: {dias: 360},
            dataType: ""json"",
            type: ""GET"",
            error: function(xhr, status, error) {
                var err = eval(""("" + xhr.responseText + "")"");
                toastr.error(err.message);
            },
            success: function(data) {
                GraficoVendasLanches(data);
                return false;
            }
        });
        return false;
    }

    function GraficoVendasLanches(data) {
        var dataArray = [
            ['Lanche', 'Quantidade' , 'Valores(R$)']
        ];
        $.each(data, function(i, item) {
            dataArray.push([item.lancheNome, item.lanchesQuantidade, item.lanchesValorTotal]);
        });
        var data = google.visualization.arrayToDataTable(dataArray);
        var options = {
            title: 'Lanches - Vendas nos últimos 360 dias',
            chartArea: {
                width: '70%'
            },
            colors: ['#5202b5', '#d2a828'],
            hAxis: {
");
            WriteLiteral(@"                title: 'Valor Total (em Reais)',
                minValue: 0
            },
            vAxis: {
                title: 'Lanches'
            }
        };
        var chart = new google.visualization.BarChart(document.getElementById('chart_div'));
        chart.draw(data, options);
    }
</script>");
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
