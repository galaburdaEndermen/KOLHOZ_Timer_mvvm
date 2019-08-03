using GAS_timer_mvvm.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace GAS_timer_mvvm.VievModels
{
    class MainVievModel
    {
        public MainVievModel()
        {
            manager = new SavesFileManager(@"MyTest.txt");
            ObservableCollection<TimerModel> temp = new ObservableCollection<TimerModel>();
            List<string> save = manager.getSave();
            foreach (var str in save)
            {
                string[] parts = str.Split('|');
                temp.Add(new TimerModel(parts[0], parts[1]));
            }

            Timers = new ObservableCollection<TimerModel>(temp.Distinct(new TimerModel.NameComparrer()));
            
            stats = new Command(startupStats);
            settings = new Command(startupSettings);

            if ((Timers.Count == 1) && (Timers[0].ToString() == "SampleTimer|0:0:0"))
            {
                startupSettings(new object());
            }
        }

        SavesFileManager manager;
        public ObservableCollection<TimerModel> Timers { get; set; }

        private Command stats;
        private Command settings;

        public Command Stats_start { get { return stats; } }
        public Command Settings_starts { get { return settings; } }


        Settings setWindow;
        void startupSettings(object obj)
        {
            if (setWindow == null)
            {
                setWindow = new Settings
                {
                    DataContext = new SettingsVievModel(Timers)
                };
                setWindow.ShowDialog();
                setWindow = null;
                GC.Collect();
            }
        }

        Stats statsWindow;
        void startupStats(object obj)
        {
            statsWindow = new Stats
            {
                DataContext = new StatsVievModel(Timers.ToArray()),
                Width = Timers.Count * 140 + 200
            };
            statsWindow.ShowDialog();
            statsWindow = null;
            GC.Collect();
        }
        ~MainVievModel()
        {
            string[] toSave = new string[Timers.Count];
            for (int i = 0; i < Timers.Count; i++)
            {
                toSave[i] = Timers[i].ToString();
            }
            manager.setSave(toSave);
        }
    }
}
