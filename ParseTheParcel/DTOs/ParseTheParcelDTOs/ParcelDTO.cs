using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ParseTheParcel.DTOs.ParseTheParcelDTOs
{
    public class ParcelDTO
    {
        public int Length { get; set; } // mm
        public int Breadth { get; set; } // mm
        public int Height { get; set; } // mm
        public int Weight { get; set; } // gram
    }
}
