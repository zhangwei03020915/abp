# Solution Templates: A Guide to Select the Right One For You

ABP provides several [startup templates](index.md) to you. It is important to start with the right startup template that is suitable for your **project** and **team**. This guide aims to lead you to select the most proper startup template for your requirements.

The following **architectures** will be discussed based on ABP startup templates:

* **Single-Layer** (non-layered) application
* **N-Layered** application
* **Modular** application
* **Microservice** solution

## What is a Startup Template?

Before going further, it is important to understand what is a startup solution template and **what it provides** for you.

### Pre-Architected Solution Structure

A startup solution template is a **pre-architected** structure for a purpose. For example, the [layered startup template](layered-web-application/index.md) is a great starting point if you want to build a layered application codebase based on [Domain-Driven Design](../framework/architecture/domain-driven-design/index.md) principles and patterns.

However, starting with any startup template **doesn't limit you**. After creating a solution, you can add or remove projects, layers, integration packages, create other applications and services. You can start by a [single-layer application template]() and convert it to a microservice solution by doing these. However, if your purpose is to build a microservice solution, it is best to start with the [microservice startup template](microservice/index.md).

So, it is **best to start with the most suitable startup template** for your purpose and then modify the solution to fit your custom requirements.

### Well-Structured Code Organization

Beside the overall solution structure, internals of each project in a solution template is well-structured. It is clear where will you place your [entities](../framework/architecture/domain-driven-design/entities.md), [repositories](../framework/architecture/domain-driven-design/repositories.md), [data access code](../framework/data/index.md), [application services](../framework/architecture/domain-driven-design/application-services.md), [API controllers](../framework/api-development/index.md), [UI elements](../framework/ui/index.md), etc. You don't spend your time to think about how to **organize your codebase** in every new project. Tests projects are also included and pre-configured if you prefer to build automated tests for your application.

### Library Integrations & Configurations

When you use ABP startup solution templates to create a new solution, some **fundamental library installations** (Serilog, Autofac, AutoMapper, Swagger, HealthCheck, etc..) and their fine-tuned configurations are already prepared for you. Also, required **[ABP packages](https://abp.io/packages)** are just installed (based on your preferences) and configured for **development and production environments**.

### Development Ready

When you create a new solution, or when a new teammate starts to work on your existing solution, it is pretty **easy to understand** the solution structure, design decisions and the development flow by the help of [solution structure documents](index.md) and [development tutorials](../tutorials/index.md).

### Production Ready

ABP's startup templates are ready for production. You can just create a new solution and **deploy it** to your production environment. It is not only about **technical readiness**, but also about **functional readiness**.

When you create a new ABP solution, **fundamental modules are already installed**. Your application have a robust [account module](../modules/account.md) (user registration, login, social logins, 2-factor authentication, user lockout, password complexity control...), an advanced [identity module](../modules/identity.md) (user, role and permission management), and many other production-ready [pre-built application modules](../modules/index.md) are just working as a part your application in the first day.

## The Startup Solution Templates

If you've understood what is a startup solution template, we can **explore** the startup solution templates are provided by the ABP Platform to understand **which one is best for you**.

### Single-Layer Application Solution Template

The [single-layer solution template](single-layer-web-application/index.md) is the most simple one. It provides a **minimal solution architecture** while starting a new project. Your .NET solution typically contains a **single, or a few .NET projects** depending on your UI and other preferences while creating your solution.

The following figure shows a single-project web application that has [MVC (Razor Pages) UI](../framework/ui/mvc-razor-pages/overall.md) and [Entity Framework Core](../framework/data/entity-framework-core/index.md) database provider with the default configuration:

![single-layer-abp-solution](images/single-layer-abp-solution.png)

As you see in the preceding figure, all the application code (entities, data access, services, UI pages, etc.) are located in a **single .NET project**.

#### When to use the Single-Layer Solution Template?

In the following conditions, you may consider to use the single-layer solution template:

* If **your project is small** and you don't expect that it will grow by the time. But remember that many projects are thought as small in the beginning.
* If your project is a **temporary project** and it will be thrown away in a short time. It can be a POC project or a temporary application for a short-term advertisement campaign.
* If you are a **single developer** or there are only 2-3 developers working on your solution, and these developer(s) are not experienced and are not willing to understand the structure and benefits of a layered application.

If the preceding conditions are meet with your case, you can consider to start with this solution template. However, be noticed that your solution can quickly become a **[big ball of mud](https://thedomaindrivendesign.io/big-ball-of-mud/)**. We think that only a **very small portion of applications** are suitable for that kind of solution structure.

> **Can I use the Single-Layer Solution Template for Modular Applications?**
>
> If you want to [build a modular application](../tutorials/modular-crm/index.md) and want to use that single-layer application as only the host application, then **it can be a good decision** to get started with this solution template. In that case, you can use that single-layer application just for referencing to other modules' .NET projects and configuring them to run as a monolith application. In that case, **do not add any application functionality to the host application**. Even if you need to make multi-module functionalities, just create another module that consumes these modules you want to work on.
>

### Layered Solution Template

The [layered application startup template](layered-web-application/index.md) is a .NET solution that consists of many projects. Each project represents a layer of the application or has a specific functionality for the solution.

Exact project count in your solution depends on the options you've selected. The following figure shows a solution with [MVC (Razor Pages) UI](../framework/ui/mvc-razor-pages/overall.md) and [Entity Framework Core](../framework/data/entity-framework-core/index.md) database provider with the default configuration:

![layered-abp-application](D:\Github\abp\docs\en\solution-templates\images\layered-abp-application.png)

The solution is layered based on Domain-Driven Design principles and extended based on real-world business application requirements. It includes test projects for each layer. Layering the solution has great benefits:

* It makes your business code (domain & application layers) independent from infrastructure (UI and database) that makes it more **maintainable and long-living**.
* Different developers can **focus on different layers**. It is valuable when multiple developers (with different roles) touching to the same solution.
* It **separate concerns**, so you can focus on a single concern at a time. You can optimize your data access code without touching other layers, you can change your UI code without breaking your business logic.
* It provides **maximum code reusability**. If you have multiple applications (e.g. one back office application, one end-user application, and a mobile application), it is easy to separate these application's codebases (simply create new application & UI layers for each application type) while they can share the same domain and data access layers.
* Separating **UI layer** gives an opportunity to **replace/modify** it in the future without affecting other parts of your solution. You know, UI is the fastest changing technology in software industry.

While it may seem a little complicated at the beginning, once you **complete the [Book Store tutorial](../tutorials/book-store/index.md)**, you will easily understand the purpose and usage of each project.

#### When to use the Layered Solution Template?

In the following conditions, you may consider to use the layered solution template:

* If your project **codebase** is relatively **larger**.
* If your project is a **long-term** project and you want to design it as **maintainable** for long years.
* If you are **a team of developers** working on your solution.
* If your solution will have **multiple** web, mobile or other type of **applications** that need to **share** the same business logic.

> **Can I use the Single-Layer Solution Template for Modular Applications?**
>
> If you want to [build a modular application](../tutorials/modular-crm/index.md), you may want to use that layered application as a host application. After creating your solution, you can add modules and import these modules to the host application. You can also use the application's .NET solution as a unification layer in some cases you need to write code that utilizes multiple modules. However, if you don't consider to write any application code into the host application (which can be considered as a good practice), you can use the single-layer startup solution template as your host application as explained before.

### Modular Monolith Applications

TODO

### Microservice Solution Template

TODO