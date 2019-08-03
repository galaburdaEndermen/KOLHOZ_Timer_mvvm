using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Media;

namespace GAS_timer_mvvm.Models
{
    class TimerModel : INotifyPropertyChanged
    {

        public class NameComparrer : IEqualityComparer<TimerModel>
        {
            public bool Equals(TimerModel x, TimerModel y)
            {
                return x.Name == y.Name;
            }

            public int GetHashCode(TimerModel obj)
            {
                return obj.name.GetHashCode();
            }
        }

        public TimerModel(string name, string time)
        {
            Timer = new System.Windows.Threading.DispatcherTimer();
            Timer.Tick += new EventHandler(Tick);
            Timer.Interval = new TimeSpan(0, 0, 1);
            Timer.Stop();

            simpleCommand = new Command(Toggle);
            IsTicking = false;
            CurrentColor = new SolidColorBrush((Color.FromRgb(221, 35, 35))); // чевО?
            this.name = name;
            this.ticks = fromTime(time);
            CurrentColor = new SolidColorBrush((Color.FromRgb(48, 147, 60))); // чевО?
        }

        private System.Windows.Threading.DispatcherTimer Timer;
        private void Tick(object sender, EventArgs e)
        {
            Time = toTime(fromTime(Time) + 1);
        }

        string name;
        public string Name
        {
            get { return name; }
            set { name = value; RaisePropertyChanged("Name"); }
        }


        private int ticks;
        public string Time
        {
            get { return toTime(ticks); }
            set { ticks = fromTime(value); RaisePropertyChanged("Time"); }
        }
        private string toTime(int sec)
        {
            int seconds, minutes, hours;

            seconds = sec;

            minutes = seconds / 60;
            seconds = seconds % 60;

            hours = seconds / 3600;
            seconds = seconds % 3600;

            return hours.ToString() + ":" + minutes.ToString() + ":" + seconds.ToString();
        }
        private int fromTime(string time)
        {
            string[] parts = time.Split(new char[] { ':' });

            return (int.Parse(parts[0]) * 3600) + (int.Parse(parts[1]) * 60) + (int.Parse(parts[2]));
        }


        SolidColorBrush color;
        public SolidColorBrush CurrentColor
        {
            get { return color; }
            set { color = value; RaisePropertyChanged("CurrentColor"); }
        }


        bool isTicking;
        public bool IsTicking
        {
            get { return isTicking; }
            set
            {
                if (isTicking != value)
                {
                    //можна скоротить
                    if ((isTicking == false) && (value == true))
                    {
                        Timer.Start();
                        //CurrentColor = new SolidColorBrush((Color.FromRgb(48, 147, 60)));
                        CurrentColor = new SolidColorBrush((Color.FromRgb(221, 35, 35)));
                        isTicking = value;
                    }
                    if ((isTicking == true) && (value == false))
                    {
                        Timer.Stop();
                        //CurrentColor = new SolidColorBrush((Color.FromRgb(221, 35, 35)));
                        CurrentColor = new SolidColorBrush((Color.FromRgb(48, 147, 60)));
                        isTicking = value;
                    }
                }
            }
        }

        private Command simpleCommand;
        public Command ChangeState
        {
            get { return simpleCommand; }
        }

        void Toggle(object obj)
        {
            IsTicking = !IsTicking;
        }


        public event PropertyChangedEventHandler PropertyChanged;
        protected void RaisePropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        public override string ToString()
        {
            return Name + "|" + Time;
        }

        public override bool Equals(object obj)
        {
            if (obj is TimerModel)
            {
                return (this.Name == (obj as TimerModel).Name);
            }
            else
            {
                return false;
            }
        }

        public override int GetHashCode()
        {
            return ticks.GetHashCode();
        }

    }
}
