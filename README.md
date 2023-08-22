# [JSON](#) 
This structure, called Javascript Object Notation, is actually a source-independent file format created for javascript to read data from external sources. <br />
It is possible to use the JSON file structure in all programming languages.

## [Where is the JSON File Structure Used?](#)
- You can use it in all areas where your application needs to read data from outside.
- You can use it in your applications where you want to share data with the outside world.
- You can use the system logs you have received in the application to keep them on the disk regularly.

## [Data Types Used in JSON File Structure](#)
- number
- string
- boolean
- array  ->  [ ... ]  -> List<>
- object  ->  { ... }

A ready-made MSSQL database named [Bike Stores Sample Database](https://www.sqlservertutorial.net/sql-server-sample-database/) >> `Download SQL Server Sample Database` is used. <br />

    ?   create database DapperDB or otherName  :  use DapperDB or otherName;
        create object query;   >>   load data query;

## [NuGet Gallery](---------------)
- Some packages can be installed from the "[NuGet Gallery](https://www.nuget.org/packages/Microsoft.AspNet.Identity.Core)" with the help of the `Tools > NuGet Package Manager > Package Manager Console`.
- [Dapper 2.0.151](https://www.nuget.org/packages/Dapper/2.0.151) | [github](https://github.com/DapperLib/Dapper)
```
    PM>  NuGet\Install-Package Dapper -Version 2.0.151
```
- [Newtonsoft.Json 13.0.3](https://www.nuget.org/packages/Newtonsoft.Json/13.0.3) | [[source]](https://www.newtonsoft.com/json)
```
    PM>  NuGet\Install-Package Newtonsoft.Json -Version 13.0.3s
```

The projects are in the [JSON](---------------) file.
### [JSON.ConsoleApp](---------------)
Console App (.NET Core) 
- [System.Data.SqlClient 4.8.5](https://www.nuget.org/packages/System.Data.SqlClient/4.8.5)
```
    PM>  NuGet\Install-Package System.Data.SqlClient -Version 4.8.5
```
![](/pictures/consoleapp1.PNG)
![](/pictures/consoleapp2.PNG)
![](/pictures/consoleapp3.PNG)
![](/pictures/consoleapp4.PNG)

### [JSON.FormsApp](---------------)
Windows Forms App (.NET Framework) 
![](/pictures/jsonwindforms.gif)

### [JSON.WebApp](---------------)
ASP.NET Web Application (.NET Framework) 
The project runs on "[localhost:?/api/](http://localhost:63541/api/products)".
![](/pictures/webapp1.PNG)
![](/pictures/webapp2.PNG)
![](/pictures/webapp3.PNG)
![](/pictures/webapp4.PNG)

A site where you can see your data in [JSON Viewer](https://codebeautify.org/jsonviewer), JSON format cleanly as an object or a list.
![](/pictures/JSONViewer.PNG)

--------------

# [JSON](#) 
Javascript Object Notation adı verilen bu yapı aslında javascript'in harici kaynaklardan veri okuması için oluşturulmuş kaynaktan bağımsız bir dosya formatıdır.   <br />
JSON dosya desenini, kurallarına uyduğunuz tüm yazılım dillerinde kullanabilmeniz mümkündür. 

## [JSON Dosya Deseni Nerelerde Kullanılır?](#)
- Uygulamanızın dışarıdan veri okumaya ihtiyaç duyduğu tüm alanlarda kullanabilirsiniz.
- Uygulamalarınızın içerisinden dış dünya ile veri paylaşmak istediğiniz noktalarda kullanabilirsiniz.
- Uygulama içinde almış olduğunuz sistem loglarını disk üzerinde düzenli olarak saklayabilmek için kullanabilirsiniz.

Proje dosyaları [JSON](---------------) klasörü içerisindedir.  <br />

[JSON Viewer](https://codebeautify.org/jsonviewer), JSON formatındaki verilerinizi düzgün bir obje veya liste olarak görebileceğiniz bir site.