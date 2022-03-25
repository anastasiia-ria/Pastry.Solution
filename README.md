# Pierre's Sweet and Savory Treats

#### Tracks Pierre's Sweet and Savory Treats' flavors and treats

#### By [Anastasiia Riabets](https://github.com/anastasiia-ria)

## Technologies Used

- CSS
- HTML
- C#
- .NET 5.0
- ASP.Net
- Razor
- dotnet script REPL
- MySQL
- Workbench
- EF Core

## Description

Pierre's Sweet and Savory Treats lets users to add and track their flavors and treats.

## Setup/Installation Requirements

- Clone this repository to your Desktop:
  1. Your computer will need to have GIT installed. If you do not currently have GIT installed, follow [these](https://docs.github.com/en/get-started/quickstart/set-up-git) directions for installing and setting up GIT.
  2. Once GIT is installed, clone this repository by typing following commands in your command line:
     ```
     ~ $ cd Desktop
     ~/Desktop $ git clone https://github.com/anastasiia-ria/Pastry.Solution.git
     ~/Desktop $ cd Pastry.Solution
     ```
- Install the [.NET 5 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/5.0)
- Create .gitignore file:
  ```
   ~/Desktop/Pastry.Solution/ $ touch .gitignore
   ~/Desktop/Pastry.Solution/ $ echo "*/obj/
   */bin/
   */appsettings.json" > .gitignore
  ```
- Create appsettings.json file:
  ```
   ~/Desktop/Pastry.Solution $ cd Pastry
   ~/Desktop/Pastry.Solution/Pastry $ touch appsettings.json
   ~/Desktop/Pastry.Solution/Pastry $ echo '{
      "ConnectionStrings": {
        "DefaultConnection": "Server=localhost;Port=3306;database=anastasiia_riabets;uid=root;pwd=[PASSWORD];"
      }
    }' > appsettings.json
  ```
  [PASSWORD] is your password
- Install packages and tools:
  ```
  ~/Desktop/Pastry.Solution/Pastry $ dotnet add package Microsoft.EntityFrameworkCore -v 5.0.0
  ~/Desktop/Pastry.Solution/Pastry $ dotnet add package Pomelo.EntityFrameworkCore.MySql -v 5.0.0-alpha.2
  ~/Desktop/Pastry.Solution/Pastry $ dotnet tool install --global dotnet-ef --version 5.0.1
  ~/Desktop/Pastry.Solution/Pastry $ dotnet add package Microsoft.AspNetCore.Identity.EntityFrameworkCore -v 5.0.0
  ~/Desktop/Pastry.Solution/Pastry $ dotnet add package Microsoft.EntityFrameworkCore.SqlServer --version 5.0.0
  ```
- Update Database:
  ```
  ~/Desktop/Pastry.Solution/Pastry $ dotnet ef database update
  ```
- Build the project:
  ```
   ~/Desktop/Pastry.Solution/Pastry $ dotnet build
  ```
- Run the project
  ```
   ~/Desktop/Pastry.Solution/Pastry $ dotnet run
  ```
- Visit [http://localhost:5000](http://localhost:5000) to try this application

## Known Bugs

- Layout is not adjusted for the small screens

## License

[ISC](https://opensource.org/licenses/ISC)

Copyright (c) 03/25/2022 Anastasiia Riabets
