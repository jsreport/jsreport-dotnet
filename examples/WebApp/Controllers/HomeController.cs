using Microsoft.AspNetCore.Mvc;
using WebApp.Model;
using jsreport.MVC;
using jsreport.Types;
using System.Threading.Tasks;

namespace WebApp.Controllers
{
    public class HomeController : Controller
    {
        public IJsReportMVCService JsReportMVCService { get; }

        public HomeController(IJsReportMVCService jsReportMVCService)
        {
            JsReportMVCService = jsReportMVCService;
        }

        public IActionResult Index()
        {
            return View();
        }

        [MiddlewareFilter(typeof(JsReportPipeline))]
        public IActionResult Invoice()
        {
            HttpContext.JsReportFeature().Recipe(Recipe.PhantomPdf);

            return View(InvoiceModel.Example());
        }

        [MiddlewareFilter(typeof(JsReportPipeline))]
        public IActionResult InvoiceDownload()
        {
            HttpContext.JsReportFeature().Recipe(Recipe.PhantomPdf)
                .OnAfterRender((r) => HttpContext.Response.Headers["Content-Disposition"] = "attachment; filename=\"myReport.pdf\"");

            return View("Invoice", InvoiceModel.Example());
        }

        [MiddlewareFilter(typeof(JsReportPipeline))]
        public IActionResult InvoiceWithHeader()
        {
            HttpContext.JsReportFeature()
                .Recipe(Recipe.PhantomPdf)
                .Configure(async (r) => r.Template.Phantom.Header = 
                    await JsReportMVCService.RenderViewToStringAsync(HttpContext, RouteData, "Header", new { }));

            return View("Invoice", InvoiceModel.Example());
        }

        [MiddlewareFilter(typeof(JsReportPipeline))]
        public IActionResult Items()
        {
            HttpContext.JsReportFeature()                
                .Recipe(Recipe.HtmlToXlsx);

            return View(InvoiceModel.Example());
        }

        [MiddlewareFilter(typeof(JsReportPipeline))]
        public IActionResult ItemsExcelOnline()
        {
            HttpContext.JsReportFeature()
                .Configure(req => req.Options.Preview = true)
                .Recipe(Recipe.HtmlToXlsx);

            return View("Items", InvoiceModel.Example());
        }

        [MiddlewareFilter(typeof(JsReportPipeline))]
        public IActionResult InvoiceDebugLogs()
        {
            HttpContext.JsReportFeature()
                .DebugLogsToResponse()
                .Recipe(Recipe.PhantomPdf);

            return View("Invoice", InvoiceModel.Example());
        }
    }
}
