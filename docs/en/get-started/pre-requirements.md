# Prerequisites for Developing an ABP Project

Projects using the `ABP framework` require several common tools and environments. This document will guide you through preparing these tools and environments.

## Visual Studio

`Visual Studio` is Microsoft's IDE and is the preferred tool for developing `ABP` projects. The latest `ABP 9.0` is based on `.NET 9`, so `Visual Studio 2022` is the best choice.  
You can download `Visual Studio 2022` from the [Visual Studio official website](https://visualstudio.microsoft.com/). You can also use the [free Community version of `Visual Studio 2022`](https://visualstudio.microsoft.com/free-developer-offers/).

## JetBrains Rider

`JetBrains Rider` is a cross-platform IDE and is also a preferred tool for developing ABP projects. You can download `JetBrains Rider` from the [JetBrains official website](https://www.jetbrains.com/rider/download). It supports `Windows`, `macOS`, and `Linux`. We recommend using the latest version or `>=2024.3` to support `.NET 9.0`.

> [`JetBrains Rider` is free for non-commercial use](https://blog.jetbrains.com/blog/2024/10/24/webstorm-and-rider-are-now-free-for-non-commercial-use/)

## .NET 9.0 SDK

`ABP 9.0` is based on `.NET 9.0`, so you need to install the `.NET 9.0 SDK`. You can download the `.NET 9.0 SDK` from the [.NET official website](https://dotnet.microsoft.com/en-us/download/dotnet/9.0).

> Installing `Visual Studio 2022` or `JetBrains Rider` may automatically install the `.NET 9.0 SDK`. You can run the `dotnet --list-sdks` command to check if the `.NET 9.0 SDK` is installed.

### EF Core CLI

If you are using `Entity Framework Core`, you need to install the [EF Core CLI](https://learn.microsoft.com/en-us/ef/core/cli/dotnet). You can install it by running the following command:

```bash
dotnet tool install --global dotnet-ef --version 9.0.0
```

If you have already installed the `EF Core CLI`, you can update it by running the following command:

```bash
dotnet tool update --global dotnet-ef --version 9.0.0
```

### ABP CLI

[ABP CLI](https://abp.io/cli) is a command line tool to perform common operations for ABP based solutions. Create new solutions, upgrade existing solutions, add modules, install packages, bundle your resources and much more…

You can install `ABP CLI` by running the following command:

```bash
dotnet tool install -g Volo.Abp.Studio.Cli
```

If you have already installed the `ABP CLI`, you can update it by running the following command:

```bash
dotnet tool update -g Volo.Abp.Studio.Cli
```

## Node.js and Yarn

`ABP` projects include some frontend resource packages, so you need to install `Node.js` and `Yarn` to manage these resource packages. You can download `Node.js` from the [Node.js official website](https://nodejs.org/). We recommend installing version v20.11+.

Using `Yarn(Classic)` to manage frontend resource packages is faster and more stable than using `npm`. You can download `Yarn` from the [Yarn official website](https://classic.yarnpkg.com/en/docs/install). We recommend installing `Yarn v1.22+` (make sure to install the `Classic` version, not `v2`).

To install `Yarn` using `npm`, run the following command:

```bash
npm install --global yarn
```

## Redis

### Why Redis is Needed

For any application, if there are multiple instances, they should use `Redis(Distributed Cache)`. Otherwise, each instance will have its own internal memory cache for the same data, and there will be no way to invalidate that data.

> [Why do we need to install `Redis`? When is it used?](https://abp.io/support/questions/6344/Why-do-we-need-to-install-Redis-When-is-it-used-Why-Redis-is-needed#answer-3a0f798f-8034-8ac8-c819-2103080bec13)

### Installing Redis

#### Windows

`Redis` is not officially supported on `Windows`. However, you can refer to the [Redis documentation](https://redis.io/docs/latest/operate/oss_and_stack/install/install-redis/install-redis-on-windows/) to install `Redis` on Windows for development purposes.

> We recommend using Docker to install `Redis` on `Windows`. You can refer to the `Redis in Docker` section below.

#### macOS and Linux

Installing `Redis` on `macOS` and `Linux` is relatively simple. Please refer to:

* Install `Redis` on `macOS`: [https://redis.io/docs/latest/operate/oss_and_stack/install/install-redis/install-redis-on-mac-os/](https://redis.io/docs/latest/operate/oss_and_stack/install/install-redis/install-redis-on-mac-os/)
* Install `Redis` on `Linux`: [https://redis.io/docs/latest/operate/oss_and_stack/install/install-redis/install-redis-on-linux](https://redis.io/docs/latest/operate/oss_and_stack/install/install-redis/install-redis-on-linux)

#### Redis in Docker

We recommend using Docker to install and run your `Redis` server container, as it is the simplest way. You can run the following command to start the `Redis` container:

```bash
docker run -p 6379:6379 --name RedisServer -d redis
```

With this single command, you can start a `Redis` server locally. After that, you can access `Redis` via `localhost:6379` or `127.0.0.1:6379`.

In the following sections, we will discuss how to install `Docker Engine` or `Docker Desktop`.

#### Is Redis Free?

The way we install and use `Redis` through the above method is free. It is the `Redis Community Edition`. The `Redis Community Edition` is freely available to the `Redis` community and our customers, and developers will continue to enjoy the freedom to use `Redis` under [dual licensing](https://redis.io/blog/announcing-redis-community-edition-and-redis-stack-74/).

## Docker Engine & Docker Desktop

The `ABP` microservices project uses `Docker` to manage the infrastructure services required for various microservices. You can install `Docker Engine` or `Docker Desktop` on `Windows`, `macOS`, and `Linux`.

* Install `Docker Engine`: [https://docs.docker.com/engine/install/](https://docs.docker.com/engine/install/)
* Install `Docker Desktop` on `macOS`: [https://docs.docker.com/desktop/setup/install/mac-install/](https://docs.docker.com/desktop/setup/install/mac-install/)
* Install `Docker Desktop` on `Windows`: [https://docs.docker.com/desktop/setup/install/windows-install/](https://docs.docker.com/desktop/setup/install/windows-install/)
* Install `Docker Desktop` on `Linux`: [https://docs.docker.com/desktop/setup/install/linux/](https://docs.docker.com/desktop/setup/install/linux/)

### Is Docker Engine or Docker Desktop Free?

`Docker Engine` is an open-source containerization technology for building and containerizing your applications. [`Docker Engine` follows the Apache License 2.0](https://docs.docker.com/engine/#licensing).

`Docker Desktop` is free [for small businesses (fewer than 250 employees and less than $10 million in annual revenue), personal use, education, and non-commercial open-source projects](https://docs.docker.com/subscription/desktop-license/).

## PowerShell

ABP projects may use some PowerShell scripts (`*.ps1`) to perform certain tasks. You can refer to the [PowerShell documentation](https://learn.microsoft.com/en-us/powershell/scripting/install/installing-powershell) for guidance on how to install `PowerShell` on Windows, macOS, and Linux.

* Install `PowerShell` on `Windows`: [https://learn.microsoft.com/en-us/powershell/scripting/install/installing-powershell-on-windows](https://learn.microsoft.com/en-us/powershell/scripting/install/installing-powershell-on-windows)
* Install `PowerShell` on `macOS`: [https://learn.microsoft.com/en-us/powershell/scripting/install/installing-powershell-on-macos](https://learn.microsoft.com/en-us/powershell/scripting/install/installing-powershell-on-macos)
* Install `PowerShell` on `Linux`: [https://learn.microsoft.com/en-us/powershell/scripting/install/installing-powershell-on-linux](https://learn.microsoft.com/en-us/powershell/scripting/install/installing-powershell-on-linux)

## Summary

These are the tools and environments needed to develop `ABP` projects. You can install these tools and environments based on your needs. If you have any questions, you can seek help in the [ABP GitHub repository](https://github.com/abpframework/abp).
