import { Component, Input } from '@angular/core';

@Component({
  selector: 'app-twitter-tweet',
  templateUrl: './twitter-tweet.component.html',
  styleUrls: ['./twitter-tweet.component.css']
})

export class TwitterTweetComponent {
  @Input() tweet: any;

  constructor() { }

}
