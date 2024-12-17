import { SettingTabsService } from '@abp/ng.setting-management/config';
import { inject, provideAppInitializer } from '@angular/core';
import { eFeatureManagementTabNames } from '../enums/feature-management-tab-names';
import { FeatureManagementTabComponent } from '../components';

export const FEATURE_MANAGEMENT_SETTINGS_PROVIDERS = [
  provideAppInitializer(() => {
    const initializerFn = configureSettingTabs(inject(SettingTabsService));
    return initializerFn();
  }),
];

export function configureSettingTabs(settingtabs: SettingTabsService) {
  return () => {
    settingtabs.add([
      {
        name: eFeatureManagementTabNames.FeatureManagement,
        order: 100,
        requiredPolicy: 'FeatureManagement.ManageHostFeatures',
        component: FeatureManagementTabComponent,
      },
    ]);
  };
}
