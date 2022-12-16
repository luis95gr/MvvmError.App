using CommunityToolkit.Maui.Alerts;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MvvmError.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvvmError.ViewModels
{
    public partial class LoginPageViewModel : ObservableObject
    {
        [ObservableProperty]
        private MessagesMessages messageSelected;

        [ObservableProperty]
        private bool visible;

        public ObservableCollection<MessagesMessages> Messages { get; } = new();

        public LoginPageViewModel()
        {
            Visible = true;
            GetMessages();
        }


        [RelayCommand]
        async void MessageSelectedCommand()
        {
            var snackbar = Snackbar.Make("Hola");

            await snackbar.Show();
        }

        private void GetMessages()
        {
            Messages.Add(new MessagesMessages
            {
                Asunto = "Hola"
            });
            Messages.Add(new MessagesMessages
            {
                Asunto = "Hola1"
            });
            Messages.Add(new MessagesMessages
            {
                Asunto = "Hola2"
            });
            Messages.Add(new MessagesMessages
            {
                Asunto = "Hola3"
            });
        }

    }
}
