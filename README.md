# Feature Tracker

<!-- A web app to track implementation of features in a given project. Developed using ASP.NET Core Razor Pages, C# and SQLServer.

## How To Run
### Prerequisites
- MSSQL Server
- Visual Studio or Visual Studio Code
- If running on Visual Studio make sure you have ASP.NET and web development installed in your version of Visual Studio otherwise open the Visual Studio Installer and [install it](https://learn.microsoft.com/en-us/visualstudio/get-started/csharp/tutorial-aspnet-core?view=vs-2022#:~:text=Then%2C%20in%20the,install%20the%20workload.)
- If using Visual Studio Code, make sure you have [.NET 7](https://dotnet.microsoft.com/) and also [C# Extension](https://marketplace.visualstudio.com/items?itemName=ms-dotnettools.csharp) for Visual Studio Code installed.

### Using Visual Studio
- First you need to clone the project to your local pc and open it with Visual Studio.
- Setup your connection string in appsettings.json using the proper format as stipulated in [connectionstrings.com](https://www.connectionstrings.com/sql-server/) e.g. ```"ConnectionStrings": {
    "FeatureDb": "Server=localhost;Database=FeatureDb;Trusted_Connection=True;"
  }```
- Using the Nuget Package Console, run migrations to update your database ```Update-Database```
- You can now run the project and explore

### Using Visual Sudio Code
- First you need to clone the project to your local pc and open the project directory with Visual Studio Code
- Restore depencencies ```dotnet restore```
- Setup your connection string in appsettings.json using the proper format as stipulated in [connectionstrings.com](https://www.connectionstrings.com/sql-server/) e.g. ```"ConnectionStrings": {
    "FeatureDb": "Server=localhost;Database=FeatureDb;Trusted_Connection=True;"
  }```. If on linux you need to setup user name and password, see [connectionstrings.com](https://www.connectionstrings.com/sql-server/)
- [Install dotnet tools](https://learn.microsoft.com/en-us/ef/core/cli/dotnet#installing-the-tools)
- Using your terminal, run migrations to update your database ```dotnet ef database update```
- You can now run the project ```dotnet run``` and explore

## Given Requirements
- [x] You should be able to insert, update and view features.
- [x] All uncompleted features should be displayed on the index page.
- [x] User input should never be empty.
- [x] Features should have 3 levels of priority; low, medium and high.
- [x] Priority should have colors based.
- [x] You should have a page to view history of completed features.
- [x] You should have a separate page to view details of a specific feature.
- [x] Features on the main page should be sorted first by priority then by creation date.

## Skills Developed
- [x] Razor Syntax
- [x] Entity Framework Core
- [x] Dependency Injection

## Resources
- [x] [EF Core Default Values](https://learn.microsoft.com/en-us/ef/core/modeling/generated-properties?tabs=data-annotations#default-values)
 -->
