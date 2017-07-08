import { Component, OnInit, OnDestroy } from '@angular/core';
import { ActivatedRoute, Params }   from '@angular/router';
import { Observable } from 'rxjs/Rx';
import { Subject } from 'rxjs/Subject';
import 'rxjs/add/operator/switchMap';
import 'rxjs/add/operator/takeUntil';

import { TwitterService } from '../shared/twitter.service';

@Component({
  selector: 'app-twitter-timeline',
  templateUrl: './twitter-timeline.component.html',
  styleUrls: ['./twitter-timeline.component.css']
})
export class TwitterTimelineComponent implements OnInit, OnDestroy {
  private ngUnsubscribe: Subject<void> = new Subject<void>();

  user: any;
  tweets: any[];
  filteredTweets: any[];
  searchTerm: string;

  constructor(private twitterService: TwitterService, private route: ActivatedRoute) { }

  ngOnInit() {
    this.user = '{}';
    this.getUser();
    this.updateTweets()
    
    Observable
      .interval(60000)
      .takeUntil(this.ngUnsubscribe)
      .subscribe(x => {
        this.updateTweets();
      });
  }

  updateTweets() {
    this.route.params
        .switchMap((params: Params) => this.twitterService.getRecentTweets(params['id']))
        .subscribe(tweets => {
          this.tweets = tweets;
          this.filterTweetsOn(this.searchTerm);
          }
        );
  }

  getUser() {
    this.route.params
        .switchMap((params: Params) => this.twitterService.getUser(params['id']))
        .takeUntil(this.ngUnsubscribe)
        .subscribe(user => this.user = user);
  }

  filterTweetsOn(searchTerm: string) {      
    this.searchTerm = searchTerm;
    this.filteredTweets = [];

    this.tweets.forEach(tweet => {
      if (tweet['Text'].search(new RegExp(this.searchTerm, "i")) >= 0) this.filteredTweets.push(tweet);
    });
  }

  ngOnDestroy() {
        this.ngUnsubscribe.next();
        this.ngUnsubscribe.complete();
    }
}
