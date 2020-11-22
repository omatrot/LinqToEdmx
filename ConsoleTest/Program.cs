using System;
using LinqToEdmxV2;
using LinqToEdmxV2.MapV2;
using LinqToEdmxV2.Model.ConceptualV2;
using LinqToEdmxV2.Model.StorageV2;

Console.WriteLine("Hello World!");

var edmx = Edmx.Load(@"/Users/omatrot/Downloads/CommonModel/CommonModel.edmx");

var entityTypes = edmx.GetItems<EntityType>();

var entityTypeStores = edmx.GetItems<EntityTypeStore>();

var entityTypeMappings = edmx.GetItems<EntityTypeMapping>();

Console.ReadKey();