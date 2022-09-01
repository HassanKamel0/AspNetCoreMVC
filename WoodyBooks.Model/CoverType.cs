using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WoodyBook.Model
{
    public class CoverType
    {
        [Key]
        public int ID { get; set; }
        [Required]
        [Display(Name="Cover Type")]
        [MaxLength(50)]
        public string Name { get; set; }
    }
}
