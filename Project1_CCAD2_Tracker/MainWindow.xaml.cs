using System;
using System.Collections.Generic;
using System.ComponentModel;
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
using System.Windows.Threading;

namespace Project1_CCAD2_Tracker
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        public DateTime CurrentTime { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = this;

            DispatcherTimer dayTimer = new DispatcherTimer();
            dayTimer.Interval = TimeSpan.FromMilliseconds(500);
            dayTimer.Tick += new EventHandler(dayTimer_Tick);
            dayTimer.Start();
        }

        public event PropertyChangedEventHandler PropertyChanged;

        void dayTimer_Tick(object sender, EventArgs e)
        {
            CurrentTime = DateTime.Now;
            PropertyChanged(this, new PropertyChangedEventArgs("CurrentTime"));
        }

        private void myDeckName_GotFocus(object sender, RoutedEventArgs e)
        {
            myDeckName.Text = string.Empty;
        }



        private void opDeckName_GotFocus(object sender, RoutedEventArgs e)
        {
            opDeckName.Text = string.Empty;
        }



        private void ListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void ListView_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {

        }

        private void saveButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void clearButton_Click(object sender, RoutedEventArgs e)
        {
            rank.Items.Clear();
            rotationUnlimited.Items.Clear();
            myClass.Items.Clear();
            opponentClass.Items.Clear();
            startTurn.Items.Clear();
            opDeckName.Text = string.Empty;
            myDeckName.Text = string.Empty;
            winRadioBtn.IsChecked = false;
            lostRadioBtn.IsChecked = false;
            disWinRadioBtn.IsChecked = false;
            disLossRadioBtn.IsChecked = false;
        }

        private void deleteButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void opDeckName_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {

        }
    }
}
