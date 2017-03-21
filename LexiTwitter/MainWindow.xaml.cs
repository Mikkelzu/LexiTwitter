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
        }

        private void ButtonSendTweet_Click(object sender, RoutedEventArgs e)
        {
            a.SendTweet(TextBoxNewTweet.Text);
        }

        private void ButtonReTweet_Click(object sender, RoutedEventArgs e)
        {
            a.RetweetTweet(844307660354850816); //this id 844307660354850816 links to a tweet made by the bot. 
        }
    }
}
