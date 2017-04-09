using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Tweetinvi;
using Tweetinvi.Models;
using System.Data;
using ASPSnippets.TwitterAPI;

/// <summary>
/// Summary description for EvansAuthTest
/// </summary>
public class EvansAuthTest
{

    string consumerKey = "rjDDIP0kaevQqXlMFoEVsQyMP";
    string consumerSecret = "bYUJv72a9i8c1HzMpjq98xcDduAufw77dsceN9YBchvk4Y9WS4";
    string accessToken = "850829466905530369-wC0Zsz4R9nme5gHupsUSllajIUEtOca";
    string accessTokenSecret = "u4LUvF9WzzwxyUAGb8qaUysdj4g9Q7DiqfOQOPLxCJs49";

    ITwitterCredentials credentials = Auth.SetUserCredentials("rjDDIP0kaevQqXlMFoEVsQyMP", "bYUJv72a9i8c1HzMpjq98xcDduAufw77dsceN9YBchvk4Y9WS4", "850829466905530369-wC0Zsz4R9nme5gHupsUSllajIUEtOca", "u4LUvF9WzzwxyUAGb8qaUysdj4g9Q7DiqfOQOPLxCJs49");

    public EvansAuthTest()
    {
        
    }

}