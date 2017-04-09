using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Tweetinvi;

/// <summary>
/// Summary description for GetUsersFriends
/// </summary>
public class GetUsersFriends
{
    public List<string> getUserFriends(string userName)
    {
        string consumerKey = "rjDDIP0kaevQqXlMFoEVsQyMP";
        string consumerSecret = "bYUJv72a9i8c1HzMpjq98xcDduAufw77dsceN9YBchvk4Y9WS4";
        string accessToken = "850829466905530369-wC0Zsz4R9nme5gHupsUSllajIUEtOca";
        string accessTokenSecret = "u4LUvF9WzzwxyUAGb8qaUysdj4g9Q7DiqfOQOPLxCJs49";
        List<string> friendList = new List<string>(16);
        Auth.SetUserCredentials(consumerKey, consumerSecret, accessToken, accessTokenSecret);
        var user = User.GetUserFromScreenName(userName);

        // Get the first 250 friends of the user
        var friends = User.GetFriends(user);
        for(int i = 0; i < friends.Count(); i++)
        {

            friendList.Add(friends.ElementAt(i).ToString());
        }
        return friendList;
    }
}