import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import { TwitterTweetComponent } from './twitter-tweet/twitter-tweet.component';
import { TwitterTimelineComponent } from './twitter-timeline/twitter-timeline.component';

const routes: Routes = [
    { path: 'timeline', component: TwitterTweetComponent },
    { path: 'timeline/:id', component: TwitterTimelineComponent },
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class TwitterRoutingModule { }
