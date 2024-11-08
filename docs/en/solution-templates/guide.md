# Solution Templates: A Guide to Select the Right One For You

ABP provides several [startup templates](index.md) to you. It is important to start with the right startup template that is suitable for your project and team. This guide aims to lead you to select the most proper startup template for your requirements.

## What is a Startup Template?

Before going further, it is important to understand what is a startup solution template and what it provides for you.

### Pre-Architected Solution Structure

A startup solution template is a pre-architected structure for a purpose. For example, the [layered startup template](layered-web-application/index.md) is a great starting point if you want to build a layered application codebase based on [Domain-Driven Design](../framework/architecture/domain-driven-design/index.md) principles and patterns.

However, starting with any startup template don't limit you. After creating the solution, you can add or remove projects, layers, integration packages, or even create other applications and services in the solution to build a microservice solution. However, if your purpose is to build a microservice solution, it is best to start with the [microservice startup template](microservice/index.md).

So, it is best to start with the most suitable startup template for your purpose and then modify the solution to fit your requirements.

### Well-Structured Code Organization

Beside the overall solution structure, internals of each project in a solution template is well-structured. It is clear where will you place your [entities](../framework/architecture/domain-driven-design/entities.md), [repositories](../framework/architecture/domain-driven-design/repositories.md), [data access code](../framework/data/index.md), [application services](../framework/architecture/domain-driven-design/application-services.md), [API controllers](../framework/api-development/index.md), [UI elements](../framework/ui/index.md), etc. In that way, you don't need to spend your time to think about how to organize your codebase in every new project. Tests projects are also included and pre-configured if you prefer to build automated tests for your application.

### Library Integrations & Configurations

When you use ABP startup solution templates to create a new solution, some fundamental library installations (Serilog, Autofac, AutoMapper, Swagger, HealthCheck, etc..) and their fine-tuned configurations are already prepared for you. Also, many [ABP packages](https://abp.io/packages) are  just installed (based on your preferences) and configured for development and production environments.

### Development Ready

When you create a new solution, or when a new teammate starts to work on your existing solution, it is pretty easy to understand the solution structure, design decisions and the development flow by the help of [solution structure documents](index.md) and [development tutorials](../tutorials/index.md).

### Production Ready

ABP's startup templates are ready for production. You can just create a new solution and deploy it to your production environment. It is not only about technical readiness, but also about functional readiness.

When you create a new ABP solution, fundamental modules are already installed. Your application have a robust [account module](../modules/account.md) (user registration, login, social logins, 2-factor authentication, user lockout, password complexity control...), an advanced [identity module](../modules/identity.md) (user, role and permission management), and many other production-ready [pre-built application modules](../modules/index.md) are just working as a part your application in the first day.

## The Startup Solution Templates

We understood what is a startup solution template. Now, we can explore which startup solution templates are provided by ABP Platform.

### Single-Layer Solution Template

TODO