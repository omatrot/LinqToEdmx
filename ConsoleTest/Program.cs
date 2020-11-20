using System;
using LinqToEdmx;
using LinqToEdmx.Map;
using LinqToEdmx.Model.Conceptual;
using LinqToEdmx.Model.Storage;

Console.WriteLine("Hello World!");

var edmx = Edmx.Load(@"/Users/omatrot/Downloads/CommonModel/CommonModel.edmx");

var entityTypes = edmx.GetItems<EntityType>();

var entityTypeStores = edmx.GetItems<EntityTypeStore>();

var entityTypeMappings = edmx.GetItems<EntityTypeMapping>();

Console.ReadKey();