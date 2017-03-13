using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TweetSharp;

namespace LexiTwitter.Twitter
{
    public class Auth
    {
        Tokens AuthTokens = new Tokens();
        public void Authenticate(MainWindow win)
        {
            var service = new TwitterService(AuthTokens.ConsumerKey, AuthTokens.ConsumerSecret);
            service.AuthenticateWith(AuthTokens.AccessToken, AuthTokens.AccessTokenSecret);

            var tweets = service.ListTweetsOnHomeTimeline(new ListTweetsOnHomeTimelineOptions());
            foreach (var tweet in tweets)
            {
                win.textboxforusers.AppendText(tweet.User.ScreenName + "\n");
            }
        }

        public void SendTweet(string status)
        {

            var service = new TwitterService(AuthTokens.ConsumerKey, AuthTokens.ConsumerSecret);
            service.AuthenticateWith(AuthTokens.AccessToken, AuthTokens.AccessTokenSecret);

            service.SendTweet(new SendTweetOptions { Status = status });
        }
    }
}
