using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VehicleQuote.Shared
{

    public class User
    {
       

        [Required]
        [EmailAddress]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]

        public string username { get; set; }



        [Required]
        public string vehicletype { get; set; }
        [Required]
        public string vehicleage { get; set; }
        [Required]
        public string vehiclemake { get; set; }
        [Required]
        public string vehiclemodel { get; set; }
        [Required]
        public string vehiclecoverage { get; set; }
        [Required]




        public string formula { get; set; }



    }
}

