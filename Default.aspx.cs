using System;
using System.Collections.Generic;
using System.Linq;
using System.Speech.Synthesis;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Tweetinvi;
using Tweetinvi.Models;
using Tweetinvi.Parameters;

public partial class _Default : System.Web.UI.Page
{
    List<string> tweets = new List<string>();
    // creating the object of SpeechSynthesizer class  
    SpeechSynthesizer sp = new SpeechSynthesizer();

    protected void Page_Load(object sender, EventArgs e)
    {
        //setting volume   
        //sp.Volume = 100;
        //TweetReader reader = new TweetReader("bob");
        //reader.StartStream("#ufc210", lblTest);
    }

    protected void btnVoice_Click(object sender, EventArgs e)
    {
        //tweets = //Justin's code here;
        string user = "@PimPucket";
        GetUsersFriends getFriends = new GetUsersFriends();
        List<string> friends = new List<string>();
        friends = getFriends.getUserFriends(user);
        //foreach(string friend in friends)
        //{
        //    var userTimelineParam = new UserTimelineParameters
        //    {
        //        MaximumNumberOfTweetsToRetrieve = 100,
        //        IncludeRTS = true
        //    };
        //    List<ITweet> tweets2 = new List<ITweet>();
        //    tweets2 = Timeline.GetUserTimeline(user, userTimelineParam).ToList();
        //}
        var tweets = Timeline.GetHomeTimeline();
        for(int i = 0; i < tweets.Count(); i++)
        {
            if (tweets.ElementAt(i).Text.Contains(txtHashTag.Text))
            {
                //setting volume   
                sp.Volume = 100;
                //ing text box text to SpeakAsync method   
                sp.SpeakAsync(tweets.ElementAt(i).Text);
            }
        }
    }

    protected void btnLogin_Click(object sender, EventArgs e)
    {
        //EvansAuthTest test = new EvansAuthTest();
        //test.getTweets("samuraijack");
    }

}