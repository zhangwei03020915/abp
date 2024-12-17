import { RoutesService } from '@abp/ng.core';
import { inject, provideAppInitializer } from '@angular/core';
import { eThemeSharedRouteNames } from '../enums/route-names';

export const THEME_SHARED_ROUTE_PROVIDERS = [
  provideAppInitializer(() => {
    const initializerFn = configureRoutes(inject(RoutesService));
    return initializerFn();
  }),
];

export function configureRoutes(routesService: RoutesService) {
  return () => {
    routesService.add([
      {
        path: undefined,
        name: eThemeSharedRouteNames.Administration,
        iconClass: 'fa fa-wrench',
        order: 100,
      },
    ]);
  };
}
