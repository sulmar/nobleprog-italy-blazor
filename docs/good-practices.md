# ✅ Good Practices for Starting a .NET Blazor Project

Starting a new .NET Blazor project can be streamlined by following these good practices. This guide walks you through setting up a Blazor Server or Blazor WebAssembly project with best practices in mind.

### 1. Install the .NET SDK
Make sure you have the latest .NET SDK installed. You can download it from the official [.NET website](https://dotnet.microsoft.com/download).

```bash
dotnet --version
```

### 2. Create a New Blazor Project
Choose between Blazor Server or Blazor WebAssembly.

- For Blazor Server:

```bash
dotnet new blazorserver -o MyBlazorApp
```

- For Blazor WebAssembly:

```bash
dotnet new blazorwasm -o MyBlazorApp
```

### 3. Navigate to the Project Directory

```bash
cd MyBlazorApp
```

### 4. Initialize a Git Repository

```bash
git init
```

### 5. Add a .gitignore File
Create a `.gitignore` file to exclude build artifacts and other unnecessary files.

```bash
dotnet new gitignore
```

### 6. Restore NuGet Packages

```bash
dotnet restore
```

### 7. Build the Project

```bash
dotnet build
```

### 8. Run the Project

```bash
dotnet run
```

### 9. Add Useful NuGet Packages
Consider adding packages like `Microsoft.Extensions.Logging`, `AutoMapper`, or `FluentValidation` depending on your needs.

```bash
dotnet add package AutoMapper
```

### 10. Setup Folder Structure
Organize your project with folders like `Pages`, `Shared`, `Services`, `Models`, and `wwwroot`.

### 11. Configure Dependency Injection
Register your services in `Program.cs` or `Startup.cs` depending on the project template.

### 12. Use Component Libraries
Consider using component libraries like `MudBlazor` or `Radzen` for enhanced UI components.

```bash
dotnet add package MudBlazor
```

### 13. Add Unit Testing
Create a test project to write unit tests for your components and services.

```bash
dotnet new xunit -o MyBlazorApp.Tests
```

### 14. Commit Your Changes

```bash
git add .
git commit -m "Initial Blazor project setup with good practices"
```

## ▶️ How to Run

- **Blazor Server:**

```bash
dotnet run
```

Open your browser and navigate to `https://localhost:5001` or the URL indicated in the terminal.

- **Blazor WebAssembly:**

```bash
dotnet run
```

Navigate to the URL shown in the terminal (usually `https://localhost:5001`).

## 📂 Suggested Folder Structure

```
MyBlazorApp/
│
├── wwwroot/               # Static files (css, js, images)
├── Pages/                 # Razor pages
│   ├── Index.razor
│   ├── Counter.razor
│   └── ...
├── Shared/                # Shared components
│   ├── MainLayout.razor
│   └── NavMenu.razor
├── Services/              # Business logic and services
│   └── WeatherForecastService.cs
├── Models/                # Data models
│   └── WeatherForecast.cs
├── Program.cs             # Main entry point
├── appsettings.json       # Configuration settings
├── MyBlazorApp.csproj     # Project file
└── README.md              # Project documentation
```
