# Student Course Registration System

An ASP.NET Core MVC self-learning project based on the supplied activity PDF.

## Features
- Home page
- Student registration form
- Student list
- Student details page
- Server-side validation with Data Annotations and `ModelState.IsValid`
- MVC routing, model binding, Razor Views and Tag Helpers
- In-memory student storage (no database required)

## Requirements
- .NET 8 SDK
- Visual Studio 2022 or Visual Studio Code

## Run the project
1. Extract the ZIP file.
2. Open the `StudentCourseRegistration` folder in Visual Studio or VS Code.
3. Open a terminal in the folder containing `StudentCourseRegistration.csproj`.
4. Run:

```bash
dotnet restore
dotnet run
```

5. Open the local URL shown in the terminal (usually `https://localhost:xxxx` or `http://localhost:xxxx`).

## Important
The student records are stored in a static in-memory list. They reset when the application stops. This matches the activity PDF, which says a database is not mandatory.

## Main MVC files
- `Models/Student.cs` - student fields and validation rules
- `Controllers/StudentController.cs` - Index, Create (GET/POST), Details
- `Views/Student/` - Index, Create and Details Razor views
- `Program.cs` - service setup and default MVC route

## Learning reference
Microsoft ASP.NET Core MVC documentation: https://learn.microsoft.com/aspnet/core/mvc/overview
