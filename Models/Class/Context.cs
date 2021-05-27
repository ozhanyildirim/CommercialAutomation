using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace TicariOtomasyon.Models.Class
{
    public class Context:DbContext
    {
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Categories> Categories { get; set; }
        public DbSet<Current> Currents { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Expenses> Expenses { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Receipt> Receipts { get; set; }
        public DbSet<ReceiptTrans> ReceiptTrans { get; set; }
        public DbSet<Sales> Sales { get; set; }
    }
}