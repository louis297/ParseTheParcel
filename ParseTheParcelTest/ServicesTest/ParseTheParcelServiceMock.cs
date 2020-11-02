using ParseTheParcel.DTOs.ParseTheParcelDTOs;
using ParseTheParcel.Models.ParseTheParcelModels;
using ParseTheParcel.Services.ParseAndParcelServices;
using System;
using System.Collections.Generic;
using System.Text;

namespace ParseTheParcelTest.ServicesTest
{
    class ParseTheParcelServiceMock : IParseTheParcelService
    {
        List<ParseTheParcelRule> _rules;
        public ParseTheParcelServiceMock()
        {
            _rules = new List<ParseTheParcelRule> {
                new ParseTheParcelRule
                {
                    RuleID = 1,
                    RuleName = "Small",
                    RuleOrder = 1,
                    Length = 200,
                    Breadth = 300,
                    Height = 150,
                    Weight = 25000,
                    Price = 5.0
                },
                new ParseTheParcelRule
                {
                    RuleID = 2,
                    RuleName = "Medium",
                    RuleOrder = 2,
                    Length = 300,
                    Breadth = 400,
                    Height = 200,
                    Weight = 25000,
                    Price = 7.5
                },
                new ParseTheParcelRule
                {
                    RuleID = 3,
                    RuleName = "Large",
                    RuleOrder = 3,
                    Length = 400,
                    Breadth = 600,
                    Height = 250,
                    Weight = 25000,
                    Price = 8.5
                }
            };
        }
        public double? ParseTheParcel(ParcelDTO parcel)
        {
            foreach (var rule in _rules)
            {
                if (parcel.Length <= rule.Length
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
            throw new NotImplementedException();
        }
    }
}
