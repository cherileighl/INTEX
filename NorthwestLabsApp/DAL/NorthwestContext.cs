using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using NorthwestLabsApp.Models;

namespace NorthwestLabsApp.DAL
{
    public class NorthwestContext : DbContext
    {
        public NorthwestContext() : base("NorthwestContext")
        {

        }

        public DbSet<Assay_References> assay_references { get; set; }
        public DbSet<Assay_Types> assay_types { get; set; }
        public DbSet<Assays> assays { get; set; }
        public DbSet<Company_Information> company_information { get; set; }
        public DbSet<Compounds> compounds { get; set; }
        public DbSet<Customers> customers { get; set; }
        public DbSet<Discount_Types> discount_types { get; set; }
        public DbSet<Employee_Positions> employee_positions { get; set; }
        public DbSet<Employees> employees { get; set; }
        public DbSet<FAQs> faqs { get; set; }
        public DbSet<Invoices> invoices { get; set; }
        public DbSet<Literature_References> literature_references { get; set; }
        public DbSet<Order_Discounts> order_discounts { get; set; }
        public DbSet<Order_Statuses> order_statuses { get; set; }
        public DbSet<Orders> orders { get; set; }
        public DbSet<Payments> payments { get; set; }
        public DbSet<Referrals> referrals { get; set; }
        public DbSet<Reruns> reruns { get; set; }
        public DbSet<Results> results { get; set; }
        public DbSet<Samples> samples { get; set; }
        public DbSet<Test_Tubes> test_tubes { get; set; }
        public DbSet<Test_Types> test_types { get; set; }
        public DbSet<Tests> tests { get; set; }
    }
}