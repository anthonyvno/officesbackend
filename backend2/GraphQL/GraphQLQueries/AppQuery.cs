using backend2.GraphQL.GraphQLTypes;
using backend2.Models;
using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace backend2.GraphQL.GraphQLQueries
{
    public class AppQuery : ObjectGraphType
    {
        public AppQuery(IOfficeRepository repository)
        {
            Field<ListGraphType<OfficeType>>(
               "officesAll",
               resolve: context => repository.GetAll()
           );
            Field<ListGraphType<OfficeType>>(
               "officesByDistance",
               arguments: new QueryArguments(new QueryArgument<NonNullGraphType<FloatGraphType>> { Name = "latitude" },
               new QueryArgument<NonNullGraphType<FloatGraphType>> { Name = "longitude" }),
               resolve: context => {
                   var lat = context.GetArgument<double>("latitude");
                   var longi = context.GetArgument<double>("longitude");

                   return repository.GetByLatLong(lat,longi);
                   }
           );
        }
    }
}
