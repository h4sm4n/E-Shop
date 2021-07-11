using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Entity
{
    public class Contact
    {
        public int Id  { get; set; }

        [Display(Name="Email")]
        public string Email  { get; set; }

        [Display(Name="Ad")]
        public string Name  { get; set; }

        [Display(Name="Mesaj")]
        public string Message  { get; set; }
    }
}
