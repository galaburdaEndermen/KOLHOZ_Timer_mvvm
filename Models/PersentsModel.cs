using System.Windows.Media;

namespace GAS_timer_mvvm.Models
{
    class PersentsModel
    {
        public PersentsModel(int persents, string name)
        {
            this.persents = persents;
            this.name = name;
        }


        private int persents;
        public int Persents
        {
            get { return persents * 2; }
            set { persents = value; }
        }

        private string name;
        public string Name
        {
            get { return name; }
        }

        public LinearGradientBrush Color { get; set; }
    }
}
