# CMSLotusTech
# Introduction  

The Lotus Content Management System Tech is a comprehensive software that meets all the requirements for personal, corporate, and news websites.  

This project follows **Clean Architecture**, which consists of the following layers:  

- **Domain Layer**: Contains core business logic and domain entities.  
- **Application Layer**: Contains use cases and DTOs.  
- **Infrastructure Layer**: Handles data access, repositories, and external integrations.  
- **Config Layer**: Manages **Dependency Injection** and service configurations.  
- **Endpoints Layer**: Defines API controllers and presentation logic.

# Main Stack and Technologies  

- **Architecture & Principles**:  
  - Clean Architecture (with Domain, Application, Infrastructure, Config, Endpoints layers)  
  - Domain-Driven Design (DDD), SOLID Principles, Design Patterns, CQRS, Dependency Injection (DI)  
  - **Config Layer**: Handles **Dependency Injection** and **Service Initialization**  

- **Programming Languages & Frameworks**:  
  - C#, .NET Core, .NET 9, ASP.NET Core Web API, Middleware  

- **Data & Storage**:  
  - Entity Framework Core, Dapper, SQL Server, Elasticsearch  

- **DevOps & Containerization**:  
  - Docker, Nexus  

- **Logging & Validation**:  
  - Serilog, FluentValidation, AutoMapper 

## CQRS Implementation  

This project implements **CQRS** using **MediatR** with custom pipeline behaviors:  

- **LoggingPipelineBehavior**: Handles centralized logging for all requests.  
- **ValidationPipelineBehavior**: Ensures request validation before processing commands or queries.
