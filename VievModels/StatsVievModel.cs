using GAS_timer_mvvm.Models;
using System.Collections.ObjectModel;
using System.Windows.Media;
namespace GAS_timer_mvvm.VievModels
{
    class StatsVievModel
    {
        public StatsVievModel(TimerModel[] arr)
        {

            PersentsColection = new ObservableCollection<PersentsModel>();
            PersentsColection.CollectionChanged += PersentsColection_CollectionChanged; // можна і поправить
            myColors = new LinearGradientBrush[4];
            initializeColors();

            sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += toTicks(arr[i].Time);
            }
            if (sum != 0)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    PersentsColection.Add(new PersentsModel(toTicks(arr[i].Time) * 100 / sum, arr[i].Name.ToString()));
                }
            }

        }

        private void PersentsColection_CollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            for (int i = 0; i < PersentsColection.Count; i++)
            {
                PersentsColection[i].Color = myColors[i % 4];
            }
        }

        private LinearGradientBrush[] myColors { get; set; }
        public ObservableCollection<PersentsModel> PersentsColection { get; set; }


        private int sum;

        private int toTicks(string time)
        {
            string[] parts = time.Split(new char[] { ':' });

            return (int.Parse(parts[0]) * 3600) + (int.Parse(parts[1]) * 60) + (int.Parse(parts[2]));
        }

        private void initializeColors()
        {
            {
                GradientStopCollection gsc = new GradientStopCollection();
                gsc.Add(new GradientStop()
                {
                    Color = Colors.White,
                    Offset = 0
                });
                gsc.Add(new GradientStop()
                {
                    Color = Colors.Orange,
                    Offset = 1.0
                });
                myColors[0] = new LinearGradientBrush(gsc, 90);
            }
            {
                GradientStopCollection gsc = new GradientStopCollection();
                gsc.Add(new GradientStop()
                {
                    Color = Colors.White,
                    Offset = 0
                });
                gsc.Add(new GradientStop()
                {
                    Color = Colors.Green,
                    Offset = 1.0
                });
                myColors[1] = new LinearGradientBrush(gsc, 90);
            }
            {
                GradientStopCollection gsc = new GradientStopCollection();
                gsc.Add(new GradientStop()
                {
                    Color = Colors.White,
                    Offset = 0
                });
                gsc.Add(new GradientStop()
                {
                    Color = Colors.Blue,
                    Offset = 1.0
                });
                myColors[2] = new LinearGradientBrush(gsc, 90);
            }
            {
                GradientStopCollection gsc = new GradientStopCollection();
                gsc.Add(new GradientStop()
                {
                    Color = Colors.White,
                    Offset = 0
                });
                gsc.Add(new GradientStop()
                {
                    Color = Colors.Red,
                    Offset = 1.0
                });
                myColors[3] = new LinearGradientBrush(gsc, 90);
            }
        }
    }
}
