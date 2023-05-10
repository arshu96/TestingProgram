using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Models.Data;
using Client.Commands;

namespace Client.ViewModels
{
    public class TestViewModel : INotifyPropertyChanged
    {
        Question[] _questions;
        Question _currentQuestion;
        Answer[] _answers;
        int _currentIndex;
        Tuple<int, RelayCommand>[] _commands;

        public int CurrentIndex
        {
            get => _currentIndex;
            set
            {
                _currentIndex = value;
                OnNotifyPropertyChanged();
                CurrentQuestion = _questions[_currentIndex - 1];
            }
        }

        public Tuple<int, RelayCommand>[] Commands
        {
            get => _commands;
            set => _commands = value;
        }

        public Question CurrentQuestion
        {
            get => _currentQuestion;
            set
            {
                _currentQuestion = value;
                OnNotifyPropertyChanged();
            }
        }

        public TestViewModel(Question[] questions)
        {
            _questions = questions;

            _commands = new Tuple<int, RelayCommand>[_questions.Length];
            for (int i = 0; i < _commands.Length; i++)
            {
                int index = i + 1;
                _commands[i] = new Tuple<int, RelayCommand>(index, 
                    new RelayCommand(obj => CurrentIndex = index));
            }

            CurrentIndex = 1;
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnNotifyPropertyChanged([CallerMemberName] string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
    }
}
