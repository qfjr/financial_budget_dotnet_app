using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using financial_budget_dotnet_app.Models;
using Newtonsoft.Json;
using System.IO;

namespace financial_budget_dotnet_app.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
                return View();
        }

        [HttpPost]
        public ActionResult Index(string billname, string billpayment)
        {
            using (var context = new BillContext())
            {
                var newBill = new Bills()
                {
                    billName = billname,
                    billPayment = billpayment
                };
                context.Bills.Add(newBill);
                context.SaveChanges();


                // This section serializes all the bills to billsFiles.txt
                List<Bills> billList = context.Bills.ToList();
                System.IO.File.WriteAllText(@"C:\Users\a179536\Desktop\Financial_Budget_Info\billsFiles.txt", JsonConvert.SerializeObject(billList));
                
            }
            

            return View();
        }

        public ActionResult GetBillInformation()
        {

        }
    }
}