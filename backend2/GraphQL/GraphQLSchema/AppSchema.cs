using backend2.GraphQL.GraphQLQueries;
using GraphQL;
using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace backend2.GraphQL.GraphQLSchema
{
    public class AppSchema : Schema
    {
        public AppSchema(IDependencyResolver resolver)
            : base(resolver)
        {
            Query = resolver.Resolve<AppQuery>();
        }
    }
}
