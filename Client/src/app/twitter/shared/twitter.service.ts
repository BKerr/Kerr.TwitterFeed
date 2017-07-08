import { Injectable } from '@angular/core';
import { Http, Response } from '@angular/http';
import { Observable } from 'rxjs/Observable';
import 'rxjs/add/operator/map';

@Injectable()
export class TwitterService {

  constructor(private http: Http) { }

  getRecentTweets(username: string) {
      return this.http
        .get('/api/timeline/' + username)
        .map(res => res.json())
    }

  getUser(username: string) {
      return this.http
        .get('/api/user/' + username)
        .map(res => res.json())
  }

}