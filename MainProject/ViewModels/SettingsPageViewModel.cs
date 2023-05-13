using MainProject.Models;
using Newtonsoft.Json;
using System.IO;

namespace MainProject.ViewModels
{
    public class SettingsPageViewModel : BaseViewModel
    {
        public static string filePath = "C:\\Git\\Vivaldi\\MainProject\\SettingsApp.json";
        public static string json_settings = File.ReadAllText(filePath);
        public static Settings settings = JsonConvert.DeserializeObject<Settings>(json_settings);

        public SettingsPageViewModel()
        {
            Authodownload = settings.Authodownload;
            Messages = settings.Messages;
            Specialset1 = settings.Specialset1;
            Specialset2 = settings.Specialset2;
        }

        public void SaveSettings()
        {
            Settings settings = new Settings()
            {
                Authodownload = Authodownload,
                Messages = Messages,
                Specialset1 = Specialset1,
                Specialset2 = Specialset2
            };

            var json = System.Text.Json.JsonSerializer.Serialize(settings);
            File.WriteAllText(filePath, json);
        }

        private bool _authodownload;
        public bool Authodownload
        {
            get { return _authodownload; }
            set { _authodownload = value; OnPropertyChanged(); SaveSettings(); }
        }

        private bool _messages;
        public bool Messages
        {
            get { return _messages; }
            set { _messages = value; OnPropertyChanged(); SaveSettings(); }
        }

        private bool _specialset1;
        public bool Specialset1
        {
            get { return _specialset1; }
            set { _specialset1 = value; OnPropertyChanged(); SaveSettings(); }
        }

        private bool _specialset2;
        public bool Specialset2
        {
            get { return _specialset2; }
            set { _specialset2 = value; OnPropertyChanged(); SaveSettings(); }
        }
    }
}
