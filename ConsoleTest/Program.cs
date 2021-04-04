using System;
using System.Linq;

Console.WriteLine("Hello World!");

//var edmxV2 = LinqToEdmx.EdmxV2.Load(@"/Users/omatrot/Downloads/linqtoedmx/sourceCode/Src/Test/Northwind.edmx");

//var entityTypesv2 = edmxV2.GetItems<LinqToEdmx.Model.ConceptualV2.EntityType>();

//foreach (var entity in entityTypesv2)
//{
//    Console.WriteLine(entity.Name);
//}

var edmxV3SqlServer = LinqToEdmx.EdmxV3.Load(@"../../../AventureWorks2019.edmx");

var entityTypesSqlServer = edmxV3SqlServer.GetItems<LinqToEdmx.Model.ConceptualV3.EntityType>();

foreach (var entity in entityTypesSqlServer)
{
    Console.WriteLine(entity.Name);
}

var entityTypeStoresSqlServer = edmxV3SqlServer.GetItems<LinqToEdmx.Model.StorageV3.EntityTypeStore>();

foreach(var entityTypeStore in entityTypeStoresSqlServer)
{
    Console.WriteLine(entityTypeStore.Name);
}

var entityTypeMappingsSqlServer = edmxV3SqlServer.GetItems<LinqToEdmx.MapV3.EntityTypeMapping>();

Console.WriteLine(entityTypeMappingsSqlServer.Count());

var edmxV3PostgreSQL = LinqToEdmx.EdmxV3.Load(@"../../../Airlines.edmx");

var entityTypesPostgreSQL = edmxV3PostgreSQL.GetItems<LinqToEdmx.Model.ConceptualV3.EntityType>();

foreach (var entity in entityTypesPostgreSQL)
{
    Console.WriteLine(entity.Name);
}

var entityTypeStoresPostgreSQL = edmxV3PostgreSQL.GetItems<LinqToEdmx.Model.StorageV3.EntityTypeStore>();

foreach (var entityTypeStore in entityTypeStoresPostgreSQL)
{
    Console.WriteLine(entityTypeStore.Name);
}

var entityTypeMappingsPostgreSQL = edmxV3PostgreSQL.GetItems<LinqToEdmx.MapV3.EntityTypeMapping>();

Console.WriteLine(entityTypeMappingsPostgreSQL.Count());


var edmxV3FireBird = LinqToEdmx.EdmxV3.Load(@"../../../Examples.edmx");

var entityTypesFireBird = edmxV3FireBird.GetItems<LinqToEdmx.Model.ConceptualV3.EntityType>();

foreach (var entity in entityTypesFireBird)
{
    Console.WriteLine(entity.Name);
}

var entityTypeStoresFireBird = edmxV3FireBird.GetItems<LinqToEdmx.Model.StorageV3.EntityTypeStore>();

foreach (var entityTypeStore in entityTypeStoresFireBird)
{
    Console.WriteLine(entityTypeStore.Name);
}

var entityTypeMappingsFireBird = edmxV3FireBird.GetItems<LinqToEdmx.MapV3.EntityTypeMapping>();

Console.WriteLine(entityTypeMappingsFireBird.Count());

Console.ReadKey();