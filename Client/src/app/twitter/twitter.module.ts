import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { TwitterRoutingModule } from './twitter-routing.module';
import { TwitterTimelineComponent } from './twitter-timeline/twitter-timeline.component';
import { TwitterTweetComponent } from './twitter-tweet/twitter-tweet.component';
import { TwitterService } from './shared/twitter.service';

@NgModule({
  imports: [
    CommonModule,
    TwitterRoutingModule
  ],
  declarations: [TwitterTimelineComponent, TwitterTweetComponent],
  exports: [TwitterTimelineComponent, TwitterTweetComponent],
  providers: [TwitterService]
})
export class TwitterModule { }
