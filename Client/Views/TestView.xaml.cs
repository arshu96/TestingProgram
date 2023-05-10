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
using System.Windows.Shapes;
using Models.Data;
using Client.ViewModels;

namespace Client.Views
{
    /// <summary>
    /// Interaction logic for TestView.xaml
    /// </summary>
    public partial class TestView : Window
    {

        public TestView()
        {
            InitializeComponent();

            this.DataContext = new TestViewModel(new Question[]
            {
                new Question()
                {
                    Id = 1,
                    QuestionText = "qadghjh",
                },
                new Question()
                {
                    Id = 2,
                    QuestionText = "asdfg",
                },
            });
        }
    }
}
