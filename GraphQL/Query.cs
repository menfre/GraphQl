using System;
using System.Linq;
using CommanderGQL.Data;
using CommanderGQL.Models;
using HotChocolate;
using HotChocolate.Data;

namespace CommanderGQL.GraphQL
{
   public class Query
   {
      [UseDbContext(typeof(AppDbContext))]
      [UseFiltering]
      [UseSorting]
      public IQueryable<Platform> GetPlatform([ScopedService] AppDbContext context)
      {
         var result = context.Platforms;
         return result;
      }
      [UseDbContext(typeof(AppDbContext))]
      [UseFiltering]
      [UseSorting]
      public IQueryable<Command> GetCommand([ScopedService] AppDbContext context)
      {
         var result = context.Commands;
         return result;
      }
   }
}