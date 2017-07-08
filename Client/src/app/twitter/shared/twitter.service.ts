import { Injectable } from '@angular/core';
import { Http } from '@angular/http';
import 'rxjs/add/operator/map';

@Injectable()
export class TwitterService {

  constructor(private http: Http) { }

  getRecentTweets(username: string) {
      return this.http.get('/api/timeline/' + username)
        .map(res => res.json());
    }
}
