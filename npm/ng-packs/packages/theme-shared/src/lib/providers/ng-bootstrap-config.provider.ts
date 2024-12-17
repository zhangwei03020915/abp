import { inject, provideAppInitializer } from '@angular/core';
import { NgbInputDatepickerConfig, NgbTypeaheadConfig } from '@ng-bootstrap/ng-bootstrap';

export const NG_BOOTSTRAP_CONFIG_PROVIDERS = [
  provideAppInitializer(() => {
    const initializerFn = configureNgBootstrap(
      inject(NgbInputDatepickerConfig),
      inject(NgbTypeaheadConfig),
    );
    return initializerFn();
  }),
];

export function configureNgBootstrap(
  datepicker: NgbInputDatepickerConfig,
  typeahead: NgbTypeaheadConfig,
) {
  return () => {
    datepicker.container = 'body';
    typeahead.container = 'body';
  };
}
