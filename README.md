# Dr. Sillystringz's Factory

#### By Rafael Petrachini

## Description

A program created for an engineer factory that allows the company to keep track of their machine repairs, by creating profiles to each engineer and the machines they are licensed to fix. The factory manager is able to add a list of engineers, a list of machines, and specify which engineers are licensed to repais which machines.

## Technologies Used

- Visual Studio Code
- C#
- ASP.NET Core MVC
- Object Oriented Programming
- MySQL
- MySQL Workbench
- MySqlConnector
- Entity Framework Core

## Setup/Installation Requirements

C# and .NET needs to be installed for this project to work. Go [here for Windows](https://dotnet.microsoft.com/download/thank-you/dotnet-sdk-2.2.203-windows-x64-installer) and [here for MacOS](https://dotnet.microsoft.com/download/thank-you/dotnet-sdk-2.2.106-macos-x64-installer).

1. Download this repository by clicking the "Clone or Download" button
2. Navigate to the folder where it downloaded
3. Open your terminal and go to HairSalon.Solution > HairSalon
4. Type in 'dotnet restore' to download necessary packages
5. Install Entity Framework package in the root folder. Go [here](https://www.learnhowtoprogram.com/c-and-net-part-time/database-basics/configuration-for-entity-framework-core) for instructions.
6. Download MySQL Workbench and create a database in your localhost. Go [here](https://www.learnhowtoprogram.com/c-and-net-part-time/database-basics/introduction-to-mysql-workbench-creating-a-database) for instructions.
7. Connect the database to the application with MySqlConnector. Create a 'appsettings.json' file in the project folder 'Factory' and enter your database name, your localserver/MySQL username and password. Go [here](https://www.learnhowtoprogram.com/c-and-net-part-time/database-basics/connecting-a-database-to-an-asp-net-core-app-with-mysqlconnector) for instructions.
8. Import the included schema file located in the root folder to your local database. Go [here](https://www.learnhowtoprogram.com/c-and-net-part-time/database-basics/creating-a-test-database-exporting-and-importing-databases-with-mysql-workbench) for instructions.
9. Type in 'dotnet run' to run the application. Enjoy the program!

## Known Bugs

- n/a

## License

MIT

Copyright (c) [2023] [Rafael Petrachini]

Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
