using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace PartialViewToController.Models
{
    public class HrModel : DbContext
    {
        public DbSet<Designation> Designations { get; set; }
    }

    public class Designation
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Basic { get; set; }
        [DisplayName("House Rent")]
        public decimal HRrate { get; set; }
        [DisplayName("Medical Allownce")]
        public decimal MARate { get; set; }

        public decimal Convence { get; set; }
        [DisplayName("Mobile Bill")]
        public decimal MobileBill { get; set; }

    }
}