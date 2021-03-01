# LinqToEdmx

This project is a still work in progress port of [LinqToEdmx](https://archive.codeplex.com/?p=linqtoedmx) -which includes some code from [LinqToXsd](https://archive.codeplex.com/?p=linqtoxsd)- to .NET standard 2.1.

It aims to make possible the scaffolding af an EDMX file to [EF Core 5 entities and context](https://github.com/ErikEJ/EFCorePowerTools/issues/551).

The main problem right now is that LinqToEdmx has been conceived only for version 2.0 of the EDMX file format, introduced with Visual Studio 2010. There is a version 3.0 that was introduced with Visual Studio 2012.

Utimately, I would like it to work with all 3 versions of the edmx format.

I have absolutely no clue about the way the code has been generated in the codeplex archive (no doc, no comment in generated files). Using XSD? Linq2Xsd? Who knows...

Right now I've decided to duplicate the existing code and tweak namespaces to be able to work with V2 & V3 edmx files explicitely...

**Now fixed**: <strike>But... even in V2, I couldn't enumerate properly over entities without errors... Which seems to indicate that the project actually never worked properly on CodePlex :(</strike>

Nuget packages:

https://www.nuget.org/packages/linq2xsd/0.0.2-pre

https://www.nuget.org/packages/linq2edmx/0.0.2-pre

