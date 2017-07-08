# Twitter Feed

### Steps to run

##### WebAPI server
- Start debugging the Kerr.TwitterFeed project
- Should bind to port 2110 by default, take note if it does not

##### Angular client 
- If the WebAPI is not bound to port 2110, update line 3 of Client/proxy.conf.json to the appropriate port
- Launch angular app via command line:

```
$ cd %Repo%/Client
$ npm start
```

- Open modern browser to http://localhost:4200
  
### Twitter Timeline
- Try various twitter usernames:
-- http://localhost:4200/timeline/salesforce (default)
-- http://localhost:4200/timeline/dreamforce
-- http://localhost:4200/timeline/google

### Auto-Refresh
- The application will ping the WebAPI every 60 seconds and display the latest 10 tweets.
-- The webpage does not refresh to perform this operation