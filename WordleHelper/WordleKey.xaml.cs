using System.Windows;
using System.Windows.Controls;

namespace WordleHelper
{
    /// <summary>
    /// Interaction logic for WordleKey
    /// </summary>
    public partial class WordleKey : UserControl
    {
        public static readonly DependencyProperty TextProperty =
            DependencyProperty.Register(nameof(Text), typeof(string), typeof(WordleKey), new PropertyMetadata("."));

        public string Text
        {
            get { return (string)GetValue(TextProperty); }
            set { SetValue(TextProperty, value); }
        }


        public WordleKey()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, System.Windows.RoutedEventArgs e)
        {

        }
    }
}
