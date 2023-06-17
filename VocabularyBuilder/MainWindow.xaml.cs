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
using VocabularyBuilder.Pages;
namespace VocabularyBuilder
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void btnMaximize_Click(object sender, RoutedEventArgs e)
        {
            if(this.WindowState == WindowState.Maximized)
            {
                this.WindowState = WindowState.Normal;
            }
            else
            {
                this.WindowState = WindowState.Maximized;
            }
        }

        private void btnMinimize_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void brDragable_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        private void rbTopic1_Click(object sender, RoutedEventArgs e)
        {
            TopicPage1 topicPage1 = new TopicPage1();
            PageNavigator.Content = topicPage1;
        }

        private void rbTopic2_Click(object sender, RoutedEventArgs e)
        {
            TopicPage2 topicPage2 = new TopicPage2();
            PageNavigator.Content = topicPage2;
        }

        private void rbTopic3_Click(object sender, RoutedEventArgs e)
        {
            TopicPage3 topicPage3 = new TopicPage3();
            PageNavigator.Content = topicPage3;
        }

        private void rbTopic4_Click(object sender, RoutedEventArgs e)
        {
            TopicPage4 topicPage4 = new TopicPage4();
            PageNavigator.Content = topicPage4;
        }
    }
}
