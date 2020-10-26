using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ParseTheParcel.Models.ParseTheParcelModels
{
    public class ParseTheParcelRule
    {
        [Key]
        public int RuleID { get; set; }
        [Required]
        public int RuleOrder { get; set; }
        [Required]
        public int Length { get; set; } // mm
        [Required]
        public int Breadth { get; set; } // mm
        [Required]
        public int Height { get; set; } // mm
        [Required]
        public int Weight { get; set; } // gram
        [Required]
        public double Price { get; set; } // NZD
        [Required]
        [StringLength(100)]
        public string RuleName { get; set; }
    }
}
