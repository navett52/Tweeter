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
        List<string> friendList = new List<string>();
        var user = User.GetUserFromScreenName(userName);

        // Get the first 250 friends of the user
        var friends = User.GetFriends(user);
        return friendList;
    }
}