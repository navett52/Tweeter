using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using Tweetinvi.Core.Credentials;

/// <summary>
/// Summary description for TweetReader
/// </summary>
public class TweetReader
{
    string hashTag; // The hashtag to read results from
    string consumerKey = "rjDDIP0kaevQqXlMFoEVsQyMP";
    string consumerSecret = "bYUJv72a9i8c1HzMpjq98xcDduAufw77dsceN9YBchvk4Y9WS4";
    string accessToken = "850829466905530369-wC0Zsz4R9nme5gHupsUSllajIUEtOca";
    string accessTokenSecret = "u4LUvF9WzzwxyUAGb8qaUysdj4g9Q7DiqfOQOPLxCJs49";

    public TweetReader(string hashTag)
    {
        
        this.hashTag = hashTag;
    }

    
}