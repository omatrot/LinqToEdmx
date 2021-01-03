using System;
using System.Linq;

Console.WriteLine("Hello World!");

//var edmxV2 = LinqToEdmx.EdmxV2.Load(@"/Users/omatrot/Downloads/linqtoedmx/sourceCode/Src/Test/Northwind.edmx");

//var entityTypesv2 = edmxV2.GetItems<LinqToEdmx.Model.ConceptualV2.EntityType>();

//foreach (var entity in entityTypesv2)
//{
//    Console.WriteLine(entity.Name);
//}

var edmxPath = @"../../../AventureWorks2019.edmx";

// Assume EDMX version is 3.0

var edmxv3 = LinqToEdmx.EdmxV3.Load(edmxPath);

if (edmxv3.Version == "3.0")
{
    string GetSchemaName(string entityName)
    {
        var entitySetContainer = edmxv3.GetItems<LinqToEdmx.Model.StorageV3.EntityContainer>();
        foreach(var container in entitySetContainer)
        {
            foreach (var entitySet in container.EntitySets.Where(es => es.Type == "Tables"))
            {
                if (entitySet.Name == entityName)
                {
                    return entitySet.Schema;
                }
            }
            // FIXME Return the correct schema for views
            //foreach (var entitySet in container.EntitySets.Where(es => es.Type == "Views"))
            //{
            //    if (entitySet.EntityType.Contains(entityName))
            //    {
            //        return entitySet.Schema;
            //    }
            //}
        }
        return string.Empty;
    }

    var entityTypes = edmxv3.GetItems<LinqToEdmx.Model.ConceptualV3.EntityType>();

    foreach (var entity in entityTypes)
    {
        Console.WriteLine(string.Concat(GetSchemaName(entity.Name), ".", entity.Name));

        // PK columns
        foreach (var pref in entity.Key.PropertyRefs)
        {
            Console.WriteLine(@$" PK => [{pref.Name}]");
        }

        // Scalar properties
        foreach (var column in entity.Properties)
        {
            Console.WriteLine(@$" P => [{column.Name}] IsNullable [{column.Nullable}] ");
        }

        // Navigation properties
        foreach (var column in entity.NavigationProperties)
        {
            Console.WriteLine(@$" P => [{column.Name}]");
        }

        //foreach(var fk in entity.)
    }

    var entityTypeStores = edmxv3.GetItems<LinqToEdmx.Model.StorageV3.EntityTypeStore>();

    foreach (var entityTypeStore in entityTypeStores)
    {
        Console.WriteLine(entityTypeStore.Name);
    }

    var entityTypeMappings = edmxv3.GetItems<LinqToEdmx.MapV3.EntityTypeMapping>();

    foreach (var table in entityTypeMappings)
    {
        foreach (var fragment in table.MappingFragments)
        {
            Console.WriteLine(fragment.StoreEntitySet);
        }
    }

    var entitySetContainer = edmxv3.GetItems<LinqToEdmx.Model.StorageV3.EntityContainer>();

    Console.WriteLine(entityTypeMappings.Count());
}
else if (edmxv3.Version == "2.0")
{
    var edmxv2 = LinqToEdmx.EdmxV2.Load(edmxPath);


    var entityTypes = edmxv2.GetItems<LinqToEdmx.Model.ConceptualV2.EntityType>();

    foreach (var entity in entityTypes)
    {
        Console.WriteLine(entity.Name);
    }

    var entityTypeStores = edmxv2.GetItems<LinqToEdmx.Model.StorageV2.EntityTypeStore>();

    foreach (var entityTypeStore in entityTypeStores)
    {
        Console.WriteLine(entityTypeStore.Name);
    }

    var entityTypeMappings = edmxv2.GetItems<LinqToEdmx.MapV2.EntityTypeMapping>();

    Console.WriteLine(entityTypeMappings.Count());
}
Console.ReadKey();