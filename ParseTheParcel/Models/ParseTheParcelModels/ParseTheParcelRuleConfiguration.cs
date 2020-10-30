using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ParseTheParcel.Models.ParseTheParcelModels
{
    public class ParseTheParcelRuleConfiguration: IEntityTypeConfiguration<ParseTheParcelRule>
    {
        public void Configure(EntityTypeBuilder<ParseTheParcelRule> builder)
        {
            builder.HasIndex(p => p.RuleOrder).IsUnique();

            builder.HasData(
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
                );
        }
    }
}
