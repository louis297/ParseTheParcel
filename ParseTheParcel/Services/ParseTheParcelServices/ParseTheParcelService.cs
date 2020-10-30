using ParseTheParcel.DTOs.ParseTheParcelDTOs;
using ParseTheParcel.Models;
using ParseTheParcel.Models.ParseTheParcelModels;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace ParseTheParcel.Services.ParseAndParcelServices
{
    public class ParseTheParcelService: IParseTheParcelService
    {
        private ParseTheParcelDbContext _dbContext;
        List<ParseTheParcelRule> parseRules;
        public ParseTheParcelService(ParseTheParcelDbContext dbContext)
        {
            _dbContext = dbContext;
            parseRules = new List<ParseTheParcelRule>();
            UpdateRules();
        }
        public double? ParseTheParcel(ParcelDTO parcel)
        {
            foreach(var rule in parseRules)
            {

            }
            return null;
        }
        public void UpdateRules()
        {
            parseRules = _dbContext
                .parseTheParcelRules
                .OrderBy(p => p.RuleOrder)
                .ToList();
        }
    }
}
