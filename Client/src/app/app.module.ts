import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { RouterModule } from '@angular/router';
import { HttpModule } from '@angular/http';

import { CoreModule } from './core/core.module';
import { TwitterModule } from './twitter/twitter.module';

import { AppComponent } from './app.component';

// Define the routes
const ROUTES = [
  { path: '', redirectTo: 'timeline', pathMatch: 'full' }
];

@NgModule({
  declarations: [
    AppComponent
  ],
  imports: [
    BrowserModule,
    CoreModule,
    TwitterModule,
    HttpModule,
    RouterModule.forRoot(ROUTES)
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
