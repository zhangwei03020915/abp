# OpenIddict 5.x to 6.x Migration Guide

The 6.0 release of OpenIddict is a major release that introduces breaking changes.

Check this blog [OpenIddict 6.0 general availability](https://kevinchalet.com/2024/12/17/openiddict-6-0-general-availability/) for the new features introduced in OpenIddict 6.0. and the [Migrate to OpenIddict 6.0](https://documentation.openiddict.com/guides/migration/50-to-60) for more information about the changes.

In this guide, we will explain the changes you need to make to your ABP application.

## Constant changes

The following constants have been renamed:

| Old Constant Name                                             | New Constant Name                                               |
|---------------------------------------------------------------|-----------------------------------------------------------------|
| `OpenIddictConstants.Permissions.Endpoints.Logout`            | `OpenIddictConstants.Permissions.Endpoints.EndSession`          |
| `OpenIddictConstants.Permissions.Endpoints.Device`            | `OpenIddictConstants.Permissions.Endpoints.DeviceAuthorization` |

That's all, It's a simple migration. If you have advanced usage of OpenIddict, Please check the [official migration guide](https://documentation.openiddict.com/guides/migration/50-to-60) for more information.
