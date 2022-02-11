using Prism.Mvvm;
using System.Collections.Generic;
using System.Linq;

namespace WordleHelper.ViewModels
{
    public class MainWindowViewModel : BindableBase
    {
        private string _title = "Wordle Helper";
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        private string[] fivewords = null;

        public MainWindowViewModel()
        {
            var words = System.IO.File.ReadLines(@"words_alpha.txt");
            this.fivewords = words.Where(x => x.Length == 5).ToArray();
        }
    }
}
