import { NavItemsService } from '@abp/ng.theme.shared';
import { inject, provideAppInitializer } from '@angular/core';
import { CurrentUserComponent } from '../components/nav-items/current-user.component';
import { LanguagesComponent } from '../components/nav-items/languages.component';
import { eThemeBasicComponents } from '../enums/components';

export const BASIC_THEME_NAV_ITEM_PROVIDERS = [
  provideAppInitializer(() => {
    const initializerFn = configureNavItems(inject(NavItemsService));
    return initializerFn();
  }),
];

export function configureNavItems(navItems: NavItemsService) {
  return () => {
    navItems.addItems([
      {
        id: eThemeBasicComponents.Languages,
        order: 100,
        component: LanguagesComponent,
      },
      {
        id: eThemeBasicComponents.CurrentUser,
        order: 100,
        component: CurrentUserComponent,
      },
    ]);
  };
}
