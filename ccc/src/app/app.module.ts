import { BrowserModule } from '@angular/platform-browser';
import { NgModule, InjectionToken } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { FlexLayoutModule } from '@angular/flex-layout';
import {
  ErrorsModule,
  EventEffects,
  HttpModule,
  HttpEffects,
  LookupModule,
  RouterModule,
  RouterEffects,
  StorageModule,
  StorageEffects,
  StoreModule,
  apiBaseUrlSelector,
  authTokenSelector,
  MessagesEffects
} from '@caiu/library';
import { EffectsModule } from '@ngrx/effects';
import { ActionReducerMap } from '@ngrx/store';
import 'hammerjs';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { ReducersService } from './reducers.service';
import { SharedModule } from './shared/shared.module';
import { SummerLeagueEffects } from './summer-league/summer-league.effects';

export const REDUCER_TOKEN = new InjectionToken<ActionReducerMap<any>>(
  'Registered Reducers'
);

export function getReducers(reducersService: ReducersService) {
  return reducersService.getReducers();
}

@NgModule({
  declarations: [AppComponent],
  imports: [
    AppRoutingModule,
    BrowserAnimationsModule,
    BrowserModule,
    EffectsModule.forRoot([
      EventEffects,
      HttpEffects,
      MessagesEffects,
      RouterEffects,
      StorageEffects,
      SummerLeagueEffects
    ]),
    ErrorsModule.forRoot(),
    FlexLayoutModule,
    FormsModule,
    HttpClientModule,
    HttpModule.forRoot(apiBaseUrlSelector, authTokenSelector),
    LookupModule.forRootWithPath('Lookup'),
    RouterModule.forRoot(),
    SharedModule.forRoot(),
    StorageModule.forRoot('CCC_STORE'),
    StoreModule.forRoot(REDUCER_TOKEN, {
    })
  ],
  providers: [
    {
      provide: REDUCER_TOKEN,
      deps: [ReducersService],
      useFactory: getReducers
    }
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
