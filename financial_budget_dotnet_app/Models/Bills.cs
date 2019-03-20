using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace financial_budget_dotnet_app.Models
{
    public class Bills
    {
        public int Id { get; set; }
        public string billName { get; set; }
        public string billPayment { get; set; }
    }

    public class BillContext : DbContext
    {
        public DbSet<Bills> Bills { get; set; }
    }
}