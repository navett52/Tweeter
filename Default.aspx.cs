using Quartz;
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
    //System.Timers.Timer aTimer = new System.Timers.Timer();
    // creating the object of SpeechSynthesizer class  
    SpeechSynthesizer sp = new SpeechSynthesizer();    

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            //aTimer.Elapsed += new ElapsedEventHandler(btnVoice_Click);            
            //aTimer.Enabled = false;
            //tmrLiveUpdate.Enabled = false;
        }
        //IJobDetail job = JobBuilder.Create<HelloJob>()
        //.WithIdentity("myJob", "group1") // name "myJob", group "group1"
        //.Build();

        //// Trigger the job to run now, and then every 40 seconds
        //ITrigger trigger = TriggerBuilder.Create()
        //    .WithIdentity("myTrigger", "group1")
        //    .StartNow()
        //    .WithSimpleSchedule(x => x
        //        .WithIntervalInSeconds(40)
        //        .RepeatForever())
        //    .Build();

        //// Tell quartz to schedule the job using our trigger
        //sched.scheduleJob(job, trigger);=

    }


    protected void btnVoice_Click(object sender, EventArgs e)
    {
        // aTimer.Enabled = false;
        //tmrLiveUpdate.Enabled = false;
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
        //tmrLiveUpdate.Enabled = true;
        //tmrLiveUpdate.Interval = 60000;
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
        readTweets.Clear();
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
        int tweetsWithHashCount = 0;
        for (int i = 0; i < tweets.Count; i++)
        {
            if (tweets[i].Contains(txtHashTag.Text))
            { tweetsWithHashCount++; }
        }
        int tweetCount = tweetsWithHashCount - readTweets.Count;
        if (tweetCount != 0)
        {
            for (int i = 0; i < tweetCount; i++)
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

    protected void btnLatestTweet_Click(object sender, EventArgs e)
    {
        var rawTweets = Timeline.GetHomeTimeline();      
        sp.SpeakAsync(rawTweets.ElementAt(0).Text);
    }
}