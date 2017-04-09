using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Tweetinvi;
using Tweetinvi.Models;

/// <summary>
/// Summary description for EvansAuthTest
/// </summary>
public class EvansAuthTest
{

    string consumerKey = "rjDDIP0kaevQqXlMFoEVsQyMP";
    string consumerSecret = "bYUJv72a9i8c1HzMpjq98xcDduAufw77dsceN9YBchvk4Y9WS4";
    string accessToken = "850829466905530369-wC0Zsz4R9nme5gHupsUSllajIUEtOca";
    string accessTokenSecret = "u4LUvF9WzzwxyUAGb8qaUysdj4g9Q7DiqfOQOPLxCJs49";

    public EvansAuthTest()
    {
        //
        // TODO: Add constructor logic here
        //
    }

    public List<String> getTweets(string hashtag)
    {
        AuthFlow_CreateFromRedirectedCallbackURL_StepByStep(consumerKey, consumerSecret);
        return null;
    }

    // Get credentials with callbackURL system
    public static ITwitterCredentials AuthFlow_CreateFromRedirectedCallbackURL_StepByStep(string consumerKey, string consumerSecret)
    {
        var applicationCredentials = new ConsumerCredentials(consumerKey, consumerSecret);
        var authenticationContext = AuthFlow.InitAuthentication(applicationCredentials, "http://localhost:64430/Default.aspx");
        Console.WriteLine("Go on : {0}", authenticationContext);
        Console.WriteLine("When redirected to your website copy and paste the URL: ");

        // Enter a value like: https://tweeetinvi.codeplex.com?oauth_token={tokenValue}&oauth_verifier={verifierValue}

        var callbackURL = Console.ReadLine();

        // Here we provide the entire URL where the user has been redirected
        var newCredentials = AuthFlow.CreateCredentialsFromCallbackURL(callbackURL, authenticationContext);
        Console.WriteLine("Access Token = {0}", newCredentials.AccessToken);
        Console.WriteLine("Access Token Secret = {0}", newCredentials.AccessTokenSecret);

        return newCredentials;
    }

    public static ITwitterCredentials AuthFlow_CreateFromRedirectedVerifierCode_StepByStep(string consumerKey, string consumerSecret)
    {
        var applicationCredentials = new ConsumerCredentials(consumerKey, consumerSecret);
        var authenticationContext = AuthFlow.InitAuthentication(applicationCredentials, "https://tweetinvi.codeplex.com");
        Console.WriteLine("Go on : {0}", authenticationContext);
        Console.WriteLine("When redirected to your website copy and paste the value of the oauth_verifier : ");

        // For the following redirection https://tweetinvi.codeplex.com?oauth_token=UR3eTEwDXFNhkMnjqz0oFbRauvAm4YhnF67KE6hO8Q&oauth_verifier=woXaKhpDtX6vhDVPl7TU6955qdQeH3cgz6xDvRZRA4A
        // Enter the value : woXaKhpDtX6vhDVPl7TU6955qdQeH3cgz6xDvRZRA4A

        var verifierCode = Console.ReadLine();

        // Here we only provide the verifier code
        var newCredentials = AuthFlow.CreateCredentialsFromVerifierCode(verifierCode, authenticationContext);
        Console.WriteLine("Access Token = {0}", newCredentials.AccessToken);
        Console.WriteLine("Access Token Secret = {0}", newCredentials.AccessTokenSecret);

        return newCredentials;
    }

}