Project: Sakila

In this project, we are going to create a Web Application for the Sakila database. We will
also be taking full advantage of Entity Framework and Scaffolding to create our web
app very quickly with automatic code generation.

In the previous project, we did everything step-by-step so we could focus on learning.
Now we’ll use some of the great features Visual Studio offers to help us get work done
faster. In this lesson, we’ll be implementing the web UI and Controllers for the much
large Sakila database, mostly automatically.

Database-First Approach
To get started, click Tools > NuGet Package Manager > Package Manager Console

In the Package Manager Console window, 
1) type the command as shown below, where loginname is the username you use to sign in to the computer.
Also, be aware that on some computers, you will be using C:\, and on some computers
it will be D:\ . This depends on how your computer is setup up.
If you didn’t name your project sakila , you’ll need to change that as well to match what
you called the project.       

cd D:\users\ loginname \source\repos\ sakila \ sakila

Press enter.

2) Next, type the following command all on one line, and press enter.
dotnet ef dbcontext scaffold "Server=.\sqlexpress;Database=Sakila;Trusted_Connection=True" Microsoft.EntityFrameworkCore.SqlServer -o Models

Open the Models folder and all of the Sakila tables should now be showing up as .cs files. 

In appsettings.json, add a SQL connection string.

In Startup.cs, add EntityFrameworkcore and Sakila.Models

In Startup.cs add the DbContext

Right Click in Controllers and choose new Controller.  Select MVC Controller with Views, using Entity Framework

1. On the next step, choose Actor for the Model Class and SakilaContext for the Data context.
2. Make sure Generate Views is checked along with Use a layout page.
3. Click the three dots and select the _Layout.cshtml .
4. Give the controller the name ActorsController

Test that everything is working so far. Run the application and then browse to /actors

