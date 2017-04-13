// Jake, Justin and Evan
using System;
using System.Collections.Generic;
using System.Linq;
using System.Speech.Synthesis;
using System.Timers;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Tweetinvi;
using Tweetinvi.Models;
using Tweetinvi.Parameters;

public partial class _Default : System.Web.UI.Page
{
    List<string> tweets = new List<string>();
    static List<string> readTweets = new List<string>();
    // fancy voice stuff
    SpeechSynthesizer sp = new SpeechSynthesizer();

    protected void Page_Load(object sender, EventArgs e)
    {
        // nothing here
    }


    protected void btnVoice_Click(object sender, EventArgs e)
    {
        string user = "@PimPucket";
        GetUsersFriends getFriends = new GetUsersFriends();
        List<string> friends = new List<string>();
        friends = getFriends.getUserFriends(user);
        var rawTweets = Timeline.GetHomeTimeline();
        for (int i = 0; i < rawTweets.Count(); i++)
        {
            if (!tweets.Contains(rawTweets.ElementAt(i).ToString()))
            {
                tweets.Add(rawTweets.ElementAt(i).ToString());
            }
        }

        if (newPosts())
        {
            chirp();
        }
    }

    protected void btnLogin_Click(object sender, EventArgs e)
    {
        readTweets.Clear();
        tweets.Clear();
    }

    protected bool newPosts()
    {
        if (tweets.Count > readTweets.Count)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    protected void chirp()
    {
        List<string> tweetsToRead = new List<string>();
        int tweetsWithHashCount = 0;
        for (int i = 0; i < tweets.Count; i++)
        {
            if (tweets[i].Contains(txtHashTag.Text))
            { tweetsToRead.Add(tweets[i]); }
        }
        int tweetCount = tweetsWithHashCount - readTweets.Count;
        for (int i = 0; i < tweetsToRead.Count; i++)
        {
            //setting volume   
            sp.Volume = 100;
            //ing text box text to SpeakAsync method   
            sp.SpeakAsync(tweetsToRead[i].ToString());
            readTweets.Add(tweetsToRead[i].ToString());
        }
    }


    protected void btnLatestTweet_Click(object sender, EventArgs e)
    {
        string user = "@PimPucket";
        GetUsersFriends getFriends = new GetUsersFriends();
        List<string> friends = new List<string>();
        friends = getFriends.getUserFriends(user);
        var rawTweets = Timeline.GetHomeTimeline();
        string latestTweet = "";
        for (int i = 0; i < rawTweets.Count(); i++)
        {
            if (!tweets.Contains(rawTweets.ElementAt(i).ToString()))
            {
                tweets.Add(rawTweets.ElementAt(i).ToString());

            }
        }
        for(int i = 0; i < tweets.Count; i ++)
        {
            if (tweets[i].Contains(txtHashTag.Text))
            {
                latestTweet = tweets[i].ToString();
                break;
            }
        }
        sp.SpeakAsync(latestTweet.ToString());
        readTweets.Add(latestTweet.ToString());
    }
}