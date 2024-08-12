using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace TypingGameWpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private bool gameStart = false;
        private bool firstType = true;
        private string[][] alpha = [];
        private string typingProgress = "";
        private string typingQuestion = "";
        private Stopwatch stopWatch = new Stopwatch();
        private Stopwatch latencyStopWatch = new Stopwatch();
        private ObservableCollection<string> data = new ObservableCollection<string>();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            start.IsEnabled = false;
            var countDown = new System.Timers.Timer {
                Interval = 1000
            };
            var num = 3;
            countDown.Elapsed += (sender, e) =>
            {
                if (num == 0)
                {
                    this.Dispatcher.Invoke((Action)(() =>
                    {
                        this.count.Text = "GO";
                    }));
                    gameStart = true;
                    this.Dispatcher.Invoke((Action)(() =>
                    {
                        var question = Question.Ask();
                        this.typingText.Text = question.TypingText;
                        this.kanaText.Text = question.KanaText;
                        typingQuestion = question.KanaText;
                    }));
                    stopWatch.Start();
                    latencyStopWatch.Start();
                    countDown.Stop();
                }
                else
                {
                    this.Dispatcher.Invoke((Action)(() =>
                    {
                        this.count.Text = num.ToString();
                    }));
                    num--;
                }
            };
            countDown.Start();
        }
        private void Window_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            data.Add(e.Key.ToString());
            this.list.ItemsSource = data;
            if (gameStart == true)
            {
                if (firstType)
                {
                    firstType = false;
                }
                Console.WriteLine(e.Key);
                this.progress.Text += e.Key.ToString();
                Japanese.AlphaAdjustment(Japanese.ConvertToAlpha(typingQuestion).ToArray());
            }
        }
    }
}