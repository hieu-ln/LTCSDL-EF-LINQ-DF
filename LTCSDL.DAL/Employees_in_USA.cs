namespace LTCSDL.DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Employees_in_USA
    {
        [Key]
        [Column(Order = 0)]
        public int EmployeeID { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(31)]
        public string Fullname { get; set; }

        [StringLength(30)]
        public string Title { get; set; }

        [StringLength(25)]
        public string TitleOfCourtesy { get; set; }

        [StringLength(60)]
        public string Address { get; set; }
    }
}
