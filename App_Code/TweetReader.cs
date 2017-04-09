using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web.UI.WebControls;
using Tweetinvi;
using Tweetinvi.Core.Credentials;
//using Stream = Tweetinvi.Stream;

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
        Auth.SetUserCredentials(consumerKey, consumerSecret, accessToken, accessTokenSecret);
        this.hashTag = "samuraijack";
    }
    public void StartStream(string hashtag, Label lbl)
    {
        var stream = Stream.CreateFilteredStream();
        stream.AddTrack("samuraijack#");
        stream.MatchingTweetReceived += (sender, args) =>
        {
            //Console.WriteLine("A tweet containing '#ufc210' has been found; the tweet is '" + args.Tweet + "'");
            lbl.Text += "A tweet containing '#ufc210' has been found; the tweet is '" + args.Tweet + "'";
        };
        stream.StartStreamMatchingAllConditions();
    }
    
}