# 🚀 BaseApp - Clean architecture for a TODO Project



[![Build Status](https://img.shields.io/badge/build-passing-brightgreen)]()
[![License](https://img.shields.io/badge/license-MIT-blue.svg)]()
[![NuGet](https://img.shields.io/nuget/v/BaseApp.svg)]()

---

## ✨ Overview

Welcome to **BaseApp**, a clean, scalable, and maintainable **Todo List Manager** designed with modern architectural principles:

- **Domain-Driven Design (DDD)**
- **Clean Architecture** inspired by [Ardalis](https://ardalis.com/) & [Jason Taylor](https://jasontaylordev.com/)
- **Onion Architecture** for strict separation of concerns  
- **SOLID principles** for code quality and maintainability  

---

## 🏗️ Architecture

Our layered architecture is built to maximize flexibility, testability, and separation of concerns:

| Layer            | Responsibility                                  |
| ---------------- | ----------------------------------------------- |
| **API**          | REST API endpoints, Swagger docs, Controllers  |
| **Application**  | Business logic, CQRS (MediatR), AutoMapper, Validation |
| **Domain**       | Core entities, enums, business rules            |
| **Infrastructure** | Data access, repositories, external services |

This approach ensures that:

- Core business logic stays isolated from infrastructure and UI  
- Dependency flow is inward, preventing tight coupling  
- Your codebase is easy to maintain and evolve over time  

---

## 🚀 Features

- **CQRS + MediatR:** Clear separation between commands and queries  
- **AutoMapper:** Effortless mapping between domain models and DTOs  
- **Repository Pattern:** Abstract data access to support multiple data stores  
- **FluentValidation:** Declarative validation integrated seamlessly via MediatR pipeline  
- **Dependency Injection:** Organized per-layer registration keeping Program.cs clean  
- **Swagger UI:** Interactive API documentation out-of-the-box  

---

## 🧰 Technologies & Packages

This project targets **.NET 6.0** and uses the following key NuGet packages:

- `AutoMapper.Extensions.Microsoft.DependencyInjection` (v12.0.1)  
- `BCrypt.Net-Next` (v4.0.3) for password hashing  
- `FluentValidation` (v11.5.1) with `FluentValidation.DependencyInjectionExtensions`  
- `MediatR` (v12.5.0) and `MediatR.Extensions.Microsoft.DependencyInjection` (v11.1.0)  

### Sample `.csproj` Dependencies Configuration

```xml
<Project Sdk="Microsoft.NET.Sdk">

  <ItemGroup>
    <ProjectReference Include="..\BaseApp.Domain\BaseApp.Domain.csproj" />
  </ItemGroup>

  <ItemGroup>
    <PackageReference Include="AutoMapper.Extensions.Microsoft.DependencyInjection" Version="12.0.1" />
    <PackageReference Include="BCrypt.Net-Next" Version="4.0.3" />
    <PackageReference Include="FluentValidation.DependencyInjectionExtensions" Version="11.5.1" />
    <PackageReference Include="MediatR" Version="12.5.0" />
    <PackageReference Include="MediatR.Extensions.Microsoft.DependencyInjection" Version="11.1.0" />
    <PackageReference Include="FluentValidation" Version="11.5.1" />
  </ItemGroup>

  <PropertyGroup>
    <TargetFramework>net6.0</TargetFramework>
    <ImplicitUsings>enable</ImplicitUsings>
    <Nullable>enable</Nullable>
  </PropertyGroup>

</Project>
```
## ⚙️ Getting Started

### Prerequisites

- .NET 6 SDK  
- SQL Server or preferred supported database  
- (Optional) Docker for containerized deployment  

### Setup & Run

```bash
git clone https://github.com/Farouk973/BaseApp.git
cd BaseApp
dotnet restore
dotnet build
dotnet run --project BaseApp.API
```
## 📬 Contact

Created with ❤️ by **Farouk** —  
[Visit my website](https://felfeltech.vercel.app/)
