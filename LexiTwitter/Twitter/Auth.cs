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
            Authentication a = new Authentication(new TwitterService(AuthTokens.ConsumerKey, AuthTokens.ConsumerSecret));
            a.Service.AuthenticateWith(AuthTokens.AccessToken, AuthTokens.AccessTokenSecret);

            a.Service.SendTweet(new SendTweetOptions { Status = status });
        }

        /// <summary>
        /// Testing it should only retweet 1 tweet which is hardcoded, but will be added in dynamically next commit.
        /// </summary>
        public void RetweetTweet(long tweetid)
        {
            Authentication a = new Authentication(new TwitterService(AuthTokens.ConsumerKey, AuthTokens.ConsumerSecret));
            a.Service.AuthenticateWith(AuthTokens.AccessToken, AuthTokens.AccessTokenSecret);

            a.Service.Retweet(new RetweetOptions { Id = tweetid, TrimUser = false });
        }

    
    }

    class Authentication
    {
        Tokens AuthTokens = new Tokens();

        //public TwitterService service = new TwitterService(AuthTokens.ConsumerKey, AuthTokens.ConsumerSecret);
        //service.AuthenticateWith(AuthTokens.AccessToken, AuthTokens.AccessTokenSecret);

        public TwitterService Service { get; set; }

        public Authentication(TwitterService serv)
        {
            Service = serv;
        }
    }
}
