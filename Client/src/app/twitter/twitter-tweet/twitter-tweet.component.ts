import { Component, Input } from '@angular/core';

import { Tweet } from '../shared/tweet.model';

@Component({
  selector: 'app-twitter-tweet',
  templateUrl: './twitter-tweet.component.html',
  styleUrls: ['./twitter-tweet.component.css']
})

export class TwitterTweetComponent {
  @Input() tweet: Tweet;

  constructor() { }

}
