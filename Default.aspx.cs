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
    List<string> readTweets = new List<string>();
    System.Timers.Timer aTimer = new System.Timers.Timer();
    // creating the object of SpeechSynthesizer class  
    SpeechSynthesizer sp = new SpeechSynthesizer();

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            //aTimer.Elapsed += new ElapsedEventHandler(btnVoice_Click);
            
            //aTimer.Enabled = true;
        }
    }

    protected void btnVoice_Click(object sender, EventArgs e)
    {
        //aTimer.Enabled = false;
        
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

        //aTimer.Enabled = true;
        //aTimer.Interval = 10000;
        //aTimer.Start();

        /*
        for (int i = 0; i < tweets.Count; i++)
        {
            if (readTweets.Count != 0)
            {
                for (int j = 0; j < readTweets.Count; j++)
                {
                    if (readTweets[j] != tweets[i])
                    {
                        if (tweets[i].Contains(txtHashTag.Text))
                        {
                            //setting volume   
                            sp.Volume = 100;
                            //ing text box text to SpeakAsync method   
                            sp.SpeakAsync(tweets[i]);
                            readTweets.Add(tweets[i]);
                        }
                    }
                }
            }
            else
            {
                if (tweets[i].Contains(txtHashTag.Text))
                {
                    //setting volume   
                    sp.Volume = 100;
                    //ing text box text to SpeakAsync method   
                    sp.SpeakAsync(tweets[i]);
                    readTweets.Add(tweets[i]);
                }
            }
        }*/
    }

    protected void btnLogin_Click(object sender, EventArgs e)
    {
        //EvansAuthTest test = new EvansAuthTest();
        //test.getTweets("samuraijack");
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
        int tweetCount = tweets.Count - readTweets.Count;
        for (int i = 0; i < tweetCount; i++)
        {
            //setting volume   
            sp.Volume = 100;
            //ing text box text to SpeakAsync method   
            sp.SpeakAsync(tweets[i]);
            readTweets.Add(tweets[i]);
        }
    }

}