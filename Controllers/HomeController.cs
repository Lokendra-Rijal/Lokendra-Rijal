using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace myportfolio.Controllers
{
	public class HomeController : Controller
	{
		public ActionResult Index()
		{
			return View();
		}

		public ActionResult About()
		{
			ViewBag.Message = "Your application description page.";

			return View();
		}

		public ActionResult Contact()
		{
			ViewBag.Message = "Your contact page.";

			return View();
		}
		public ActionResult DownloadSampleReport()
		{

			string path = AppDomain.CurrentDomain.BaseDirectory + "SampleFile/";
			byte[] fileBytes = System.IO.File.ReadAllBytes(path + "Sample.xlsx");
			string fileName = "Samplefile.xlsx";
			return File(fileBytes, System.Net.Mime.MediaTypeNames.Application.Octet, fileName);



		}
	}
}