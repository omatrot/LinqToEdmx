using System;
using System.Linq;

Console.WriteLine("Hello World!");

//var edmxV2 = LinqToEdmx.EdmxV2.Load(@"/Users/omatrot/Downloads/linqtoedmx/sourceCode/Src/Test/Northwind.edmx");

//var entityTypesv2 = edmxV2.GetItems<LinqToEdmx.Model.ConceptualV2.EntityType>();

//foreach (var entity in entityTypesv2)
//{
//    Console.WriteLine(entity.Name);
//}

var edmxV3 = LinqToEdmx.EdmxV3.Load(@"../../../AventureWorks2019.edmx");

var entityTypes = edmxV3.GetItems<LinqToEdmx.Model.ConceptualV3.EntityType>();

foreach (var entity in entityTypes)
{
    Console.WriteLine(entity.Name);
}

var entityTypeStores = edmxV3.GetItems<LinqToEdmx.Model.StorageV3.EntityTypeStore>();

foreach(var entityTypeStore in entityTypeStores)
{
    Console.WriteLine(entityTypeStore.Name);
}

var entityTypeMappings = edmxV3.GetItems<LinqToEdmx.MapV3.EntityTypeMapping>();

Console.WriteLine(entityTypeMappings.Count());

Console.ReadKey();