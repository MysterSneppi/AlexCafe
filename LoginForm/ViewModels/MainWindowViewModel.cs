using Avalonia.Remote.Protocol.Viewport;
using ReactiveUI;
using System;
using System.Collections.Generic;
using System.Text;

namespace LoginForm.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        string login = "test";
        string password = "test";

        string _incorrectPLText = "";
        public string IncorrectPLText 
        {
            get {return _incorrectPLText;} 
            set => this.RaiseAndSetIfChanged(ref _incorrectPLText, value);        
        }

        bool _incorrectPL = false;

        public bool IncorrectPL 
        {
            get { return _incorrectPL; }
            set => this.RaiseAndSetIfChanged(ref _incorrectPL, value);
        }

        string _loginBox = "";
        public string LoginBox
        {
            get { return _loginBox; }
            set => this.RaiseAndSetIfChanged(ref _loginBox, value);
        }

        string _passwordBox = "";
        public string PasswordBox 
        { 
            get { return _passwordBox; } 
            set => this.RaiseAndSetIfChanged(ref _passwordBox, value);
        }

        public void Login() 
        {
            if(this.LoginBox != "" && this.PasswordBox !="" ) 
            {
                if (this.LoginBox == login && this.PasswordBox == password) 
                {
                    IncorrectPLText = "";
                    IncorrectPL = false;
                }
                else 
                {
                    IncorrectPLText = "Неправильний логін або пароль";
                    IncorrectPL = true;
                }

            }
            else 
            {
                IncorrectPLText = "Не всі поля заповнені";
                IncorrectPL = true;
            }
        }
    }
}
