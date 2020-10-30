using ParseTheParcel.DTOs.ParseTheParcelDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ParseTheParcel.Services.ParseAndParcelServices
{
    public interface IParseTheParcelService
    {
        public double? ParseTheParcel(ParcelDTO parcel);
        public void UpdateRules();
    }
}
