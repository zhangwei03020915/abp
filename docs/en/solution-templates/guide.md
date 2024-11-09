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

ABP doesn't provide a specific modular monolith application startup template. However, it is not needed. Let us explain why.

The ABP Framework and [ABP Studio](../studio/index.md) are already designed to support modular application development from their beginning. ABP framework provides all the **necessary infrastructure** for [modularity](../framework/architecture/modularity/basics.md) and all other framework features are **compatible with modular solutions**.

On the other hand, the main purpose of ABP Studio's [Solution Explorer panel](../studio/solution-explorer.md) is to **architect and build modular and complex software solutions**. You can easily create new modules, arrange dependencies between the modules and import/install these modules into a monolith application. While you can do all these manually yourself, ABP Studio make it extremely easy to do and understand it.

#### How to Build a Modular Monolith Application?

A **modular monolith** application consists of a **single host** application and **multiple sub-modules**. Typically, each module has its own .NET solution that contains the code related to that module. So, the general structure is shown in the following figure:

![example-modular-solution](images/example-modular-solution.png)

In this example, `MyCrm.Host` is an almost-empty host application that has package references to other modules. Every module consists of two-packages (implementation and contracts).

You can follow the steps below to create such a modular solution with ABP Studio:

* **Create a new application** using either [single-layer](single-layer-web-application/index.md) or [layered](layered-web-application/index.md) application startup template. That application will be the **host application** of your solution.
* **Create new modules** (right-click to the solution root, select the *Add* -> *New Module* -> ... command).
* **Import & Install** these **modules** to the host application.

> You can follow the **[Modular Monolith Application Development Tutorial](../tutorials/modular-crm/index.md)** to learn how to build a modular application step by step.

#### Which Startup Template to use for a Modular Application?

So, both of [single-layer](single-layer-web-application/index.md) and [layered](layered-web-application/index.md) application startup templates are inherently modular. Just use one of them and start your modular solution. You may wonder which one to start:

* Use the **[single-layer startup template](single-layer-web-application/index.md)** for the host application of your modular monolith if you will leave the host application as empty. It will contain some configuration code of course, but it won't contain any actual application code. **This is the suggested approach.**
* Use the **[layered application startup template](layered-web-application/index.md)** if you will write some application code into the hosting application. You may want that to write some code that makes multiple module operations that is not easily to implement in a particular module. In that case, a layered hosting application will be a better way to organize your codebase. However, this approach can quickly move your solution away from a modular system. So, take your own risk.

#### When to Build a Modular Monolith Application?

In the following conditions, you may consider to build a modular software solution:

* If your **domain is too complex** to develop and maintain in a single monolith codebase.
* If your business domain is easy to **split into sub-domains**.
* If you have **multiple teams** that will work on the solution.
* If you are considering to **migrate** your application to a **microservice system**.

While all these are also suitable for microservice solutions (will be discussed in the next section), a modular solution is more suitable than microservices for most of the projects. Especially, if you don't need to have technology diversity, deploy and scale services independently and serve too many users concurrently with a fault tolerant system, a modular monolith application would be a better choice to not deal with complexity of a microservice system.

Also, even if you are considering to build a microservice system, most of the times it is advised to [start with a monolith modular first](https://martinfowler.com/bliki/MonolithFirst.html), then migrate to microservices later once your business and module boundaries are more stable.

### Microservice Solution Template

ABP's [microservice startup template](microservice/index.md) ...