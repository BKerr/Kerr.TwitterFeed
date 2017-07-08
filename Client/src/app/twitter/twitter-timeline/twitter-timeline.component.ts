import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Params }   from '@angular/router';
import 'rxjs/add/operator/switchMap';

import { TwitterService } from '../shared/twitter.service';
import { Tweet } from '../shared/tweet.model';

@Component({
  selector: 'app-twitter-timeline',
  templateUrl: './twitter-timeline.component.html',
  styleUrls: ['./twitter-timeline.component.css']
})
export class TwitterTimelineComponent implements OnInit {
  tweets: Tweet[];
  filteredTweets: Tweet[];

  constructor(private twitterService: TwitterService, private route: ActivatedRoute) { }

  ngOnInit() {
    this.route.params
    .switchMap((params: Params) => this.twitterService.getRecentTweets(params['id']))
    .subscribe(tweets => {
      this.tweets = tweets;
      this.filteredTweets = tweets;
      }
    );
  }

  onKey(event: any) { // without type info
    let searchTerm = event.target.value
       
    this.filteredTweets = [];

    this.tweets.forEach(tweet => {
      if (tweet['Text'].search(new RegExp(searchTerm, "i")) >= 0) this.filteredTweets.push(tweet);
    });
  }
}
