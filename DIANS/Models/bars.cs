using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace DIANS.Models
{
    //Klasa koja gi definira svojstvata na kafe barovite
    public class bars
    {
        [Key]
        public int ID { get; set; }
        public int br { get; set; }
        public String lon { get; set; }
        public String lat { get; set; }
        public String amenity { get; set; }
        public String name { get; set; }
        public String cuisine { get; set; }
        public String opening_hours { get; set; }
        public String takeaway { get; set; }
        public String phone { get; set; }
        public String website { get; set; }
    }
       
}
