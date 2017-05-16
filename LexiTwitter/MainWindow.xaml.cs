using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using LexiTwitter.Twitter;

namespace LexiTwitter
{

    public class TweetData
    {
        public long ID { get; set; }
        public string Author { get; set; }
        public string Tweet { get; set; }
    }


    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Auth a = new Auth();
        public MainWindow()
        {
            InitializeComponent();
            a.Authenticate(this);

            foreach (var item in a.GetHashtaggedTweet("#emberofdreamsgaming"))
            {
                TweetData data = new TweetData();

                data.ID = item.Id;
                data.Author = item.Author.ScreenName;
                data.Tweet = item.Text;

                viewtweets.Items.Add(data);
            }
        }

        private void ButtonSendTweet_Click(object sender, RoutedEventArgs e)
        {
            a.SendTweet(TextBoxNewTweet.Text);
        }

        private void ButtonReTweet_Click(object sender, RoutedEventArgs e)
        {
            long tweetid = (long)viewtweets.SelectedItems[0];

            a.RetweetTweet(tweetid);
        }
    }
}
