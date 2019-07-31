using backend2.Models;
using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace backend2.GraphQL.GraphQLTypes
{
    public class OfficeType : ObjectGraphType<Office>
    {
        public OfficeType()
        {
            Field(x => x.Id, type: typeof(IdGraphType)).Description("Id property from the office object.");
            Field(x => x.Name).Description("Name property from the office object.");
            Field(x => x.City).Description("City property from the office object.");
            Field(x => x.Latitude).Description("Latitude property from the office object.");
            Field(x => x.Longitude).Description("Longitude property from the office object.");
            Field(x => x.Email).Description("Email property from the office object.");

        }
    }
}
