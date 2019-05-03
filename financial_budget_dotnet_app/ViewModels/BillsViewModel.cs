using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using financial_budget_dotnet_app.Models;

namespace financial_budget_dotnet_app.ViewModels
{
    public class BillsViewModel
    {
        public string BillName { get; set; }
        public string BillAmount { get; set; }
        public List<Bills> BillList = new List<Bills>();

        public BillsViewModel()
        {
            using (var context = new BillContext())
            {
                var billList = context.Bills.ToList();

                foreach(var bill in billList)
                {
                    BillName = bill.billName;
                    BillAmount = bill.billPayment;

                    BillList.Add(bill);
                }
            }
        }
    }
}