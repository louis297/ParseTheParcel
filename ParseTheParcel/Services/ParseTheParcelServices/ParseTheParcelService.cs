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
            ReloadRules();
        }
        public double? ParseTheParcel(ParcelDTO parcel)
        {
            foreach(var rule in parseRules)
            {
                if(    parcel.Length <= rule.Length
                    && parcel.Breadth <= rule.Breadth
                    && parcel.Height <= rule.Height
                    && parcel.Weight <= rule.Weight
                  )
                {
                    return rule.Price;
                }
            }
            return null;
        }
        public void ReloadRules()
        {
            parseRules = _dbContext
                .parseTheParcelRules
                .OrderBy(p => p.RuleOrder)
                .ToList();
        }
    }
}
