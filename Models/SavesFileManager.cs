using System.Collections.Generic;
using System.IO;

namespace GAS_timer_mvvm.Models
{
    class SavesFileManager
    {
        string save;
        public SavesFileManager(string path)
        {
            save = path;
        }

        public List<string> getSave()
        {
            if (File.Exists(save))
            {
                List<string> toReturn = new List<string>();
                using (StreamReader sr = new StreamReader(save))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        toReturn.Add(line);
                    }
                }
                return toReturn;
            }
            else
            {
                System.IO.File.Create(save);
                System.Windows.MessageBox.Show("Configuration file doesn't exist, please, configurate programm by yourself.");
                return new List<string>() { "SampleTimer|0:0:0" };
            }
        }

        public void setSave(params string[] timers)
        {
            using (StreamWriter sw = new StreamWriter(save))
            {
                for (int i = 0; i < timers.Length; i++)
                {
                    sw.WriteLine(timers[i]);

                }
            }

        }

    }
}
