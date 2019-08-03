using GAS_timer_mvvm.Models;
using System.Collections.ObjectModel;

namespace GAS_timer_mvvm.VievModels
{
    class SettingsVievModel
    {
        public SettingsVievModel(ObservableCollection<TimerModel> Timers)
        {
            this.toSave = Timers;
            this.Timers = new ObservableCollection<TimerModel>();
            for (int i = 0; i < Timers.Count; i++)
            {
                this.Timers.Add(Timers[i]);
            }
            moveUp = new Command(moveSaveUp);
            moveDown = new Command(moveSaveDown);
            addSave = new Command(addSaveTimer);
            delete = new Command(deleteSave);
            saveAll = new Command(saveAllSaves);
        }

        private Command moveUp;
        private Command moveDown;
        private Command addSave;
        private Command delete;
        private Command saveAll;


        public Command MoveUp { get { return moveUp; } }
        public Command MoveDown { get { return moveDown; } }
        public Command Delete { get { return delete; } }
        public Command AddSave { get { return addSave; } }
        public Command SaveAll { get { return saveAll; } }


        private void moveSaveUp(object parameter)
        {
            string parName = parameter as string;
            if (parName != null)
            {
                for (int i = 0; i < Timers.Count; i++)
                {
                    if ((Timers[i].Name == parName) && (i > 0))
                    {
                        TimerModel tmp = Timers[i];
                        Timers[i] = Timers[i - 1];
                        Timers[i - 1] = tmp;
                    }
                }
            }
        }
        private void moveSaveDown(object parameter)
        {

            string parName = parameter as string;
            if (parName != null)
            {
                for (int i = 0; i < Timers.Count; i++)
                {
                    if ((Timers[i].Name == parName) && (i < Timers.Count - 1))
                    {
                        TimerModel tmp = Timers[i];
                        Timers[i] = Timers[i + 1];
                        Timers[i + 1] = tmp;
                    }
                }
            }
        }
        private void deleteSave(object parameter)
        {
            string parName = parameter as string;
            if (parName != null)
            {
                for (int i = 0; i < Timers.Count; i++)
                {
                    if (Timers[i].Name == parName)
                    {
                        Timers.RemoveAt(i);
                    }
                }
            }

        }

        private void addSaveTimer(object obj)
        {
            TimerModel newT = new TimerModel("NEW", "0:0:0");
            Timers.Add(newT);

            //ех, реалізацію би
        }

        private void saveAllSaves(object obj)
        {
            toSave.Clear();
            for (int i = 0; i < this.Timers.Count; i++)
            {
                this.toSave.Add(Timers[i]);
            }
            //закрить окно?
        }


        public ObservableCollection<TimerModel> Timers { get; set; }
        public ObservableCollection<TimerModel> toSave;
    }
}
