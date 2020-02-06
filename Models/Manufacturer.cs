using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace PhoneApplication.Models
{
    public class Manufacturer
    {
        public Manufacturer()
        {
            ManufacturerName = "";
            URL = "";
            DateReleased = new DateTime();
        }

        [Key]
        public int ManufacturerID { get; set; }
        public String ManufacturerName { get; set; }
        public String URL { get; set; }
        public DateTime DateReleased { get; set; }
        public virtual ICollection<Phone> PhoneList { get; set; }
        
        

    }
}