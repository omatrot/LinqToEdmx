# LinqToEdmx

This project is a port of [LinqToEdmx](https://archive.codeplex.com/?p=linqtoedmx) -which includes some code from [LinqToXsd](https://archive.codeplex.com/?p=linqtoxsd)- to .NET standard 2.1.

It aims to make possible the scaffolding af an EDMX file to [EF Core 5 entities and context](https://github.com/ErikEJ/EFCorePowerTools/issues/551).

The main problem right now is that LinqToEdmx has been concieved only for version 2.0 of the EDMX file format,created using VS2010. There is a version 3.0 that was created using VS2012.

Utimately, I would it to work with all 3 versions of the edmx format.

There is absolutely no clue about the way the code has been generated in the codeplex archive (no doc, no comment in generated files). Using XSD? Who knows...
