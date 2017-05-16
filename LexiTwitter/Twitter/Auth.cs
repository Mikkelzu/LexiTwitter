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
        public void Authenticate(MainWindow win)
        {
            var service = new TwitterService(Tokens.KEY, Tokens.SECRET);
            service.AuthenticateWith(Tokens.TOKEN, Tokens.TOKEN_SECRET);
        }

        public void SendTweet(string status)
        {
            Authentication a = new Authentication(new TwitterService(Tokens.KEY, Tokens.SECRET));
            a.Service.AuthenticateWith(Tokens.TOKEN, Tokens.TOKEN_SECRET);

            a.Service.SendTweet(new SendTweetOptions { Status = status });
        }

        /// <summary>
        /// Testing it should only retweet 1 tweet which is hardcoded, but will be added in dynamically next commit.
        /// </summary>
        public void RetweetTweet(long tweetid)
        {
            Authentication a = new Authentication(new TwitterService(Tokens.KEY, Tokens.SECRET));
            a.Service.AuthenticateWith(Tokens.TOKEN, Tokens.TOKEN_SECRET);

            a.Service.Retweet(new RetweetOptions { Id = tweetid, TrimUser = false });
        }

        /// <summary>
        /// returns a IEnumerable<> list of tweets with the Hashtag we "filter" with.
        /// </summary>
        /// <param name="hash"></param>
        /// <returns></returns>
        public IEnumerable<TwitterStatus> GetHashtaggedTweet(string hash)
        {
            Authentication a = new Authentication(new TwitterService(Tokens.KEY, Tokens.SECRET));

            a.Service.AuthenticateWith(Tokens.TOKEN, Tokens.TOKEN_SECRET);

            TwitterSearchResult tweets = a.Service.Search(new SearchOptions { Q = hash, SinceId = 29999});

            IEnumerable<TwitterStatus> status = tweets.Statuses;

            return status;
        }
    }

    class Authentication
    {
        Tokens AuthTokens = new Tokens();

        //public TwitterService service = new TwitterService(Tokens.KEY, Tokens.SECRET);
        //service.AuthenticateWith(Tokens.TOKEN, Tokens.TOKEN_SECRET);

        public TwitterService Service { get; set; }

        public Authentication(TwitterService serv)
        {
            Service = serv;
        }
    }
}
