using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using System.IO;

namespace CritterWorld
{
    public class Leaderboard
    {
        public class LeaderInfo
        {
            public LeaderInfo() { }

            public LeaderInfo(string critterName, string creator, TimeSpan timeToGoal)
            {
                CritterName = critterName;
                Creator = creator;
                TotalTimeToGoal = timeToGoal.Ticks;
                Finishes = 1;
            }

            public string CritterName
            {
                get;
                set;
            }

            public string Creator
            {
                get;
                set;
            }

            public int Finishes
            {
                get;
                set;
            }

            public long TotalTimeToGoal
            {
                get;
                set;
            }

            internal TimeSpan AverageTimeToGoal
            {
                get
                {
                    return new TimeSpan(TotalTimeToGoal / Finishes);
                }
            }

            public string AverageTimeToGoalDisplay
            {
                get
                {
                    return AverageTimeToGoal.ToString(CritterWrapper.TimeToGoalDisplayFormat);
                }
            }
        }

        string fileName;
        BindingList<LeaderInfo> highscores;

        public Leaderboard(string fileName)
        {
            this.fileName = fileName;
            highscores = new BindingList<LeaderInfo>();
            lock (highscores)
            {
                LoadFinishers();
                SortFinishers();
            }
        }

        private void LoadFinishers() 
        {
            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(BindingList<LeaderInfo>));
                TextReader reader = new StreamReader(fileName);
                highscores = (BindingList<LeaderInfo>)serializer.Deserialize(reader);
                reader.Close();
            }
            catch (FileNotFoundException)
            {
                Logger.OutputToLog("High scores file not found. It will be created automatically.", Logger.LogLevel.Message);
            }
            catch (Exception exception)
            {
                Logger.OutputToLog("Unable to load high scores: " + exception, Logger.LogLevel.Error);
            }
        }

        private void SaveFinishers()
        {
            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(BindingList<LeaderInfo>));
                TextWriter writer = new StreamWriter(fileName);
                serializer.Serialize(writer, highscores);
                writer.Close();
            }
            catch (Exception exception)
            {
                Logger.OutputToLog("Unable to save high scores: " + exception, Logger.LogLevel.Error);
            }
        }

        private void AddFinisherToHighscores(string critterName, string creator, TimeSpan timeToGoal)
        {
            foreach (LeaderInfo info in highscores)
            {
                if (critterName.ToUpper() == info.CritterName.ToUpper() && creator.ToUpper() == info.Creator.ToUpper())
                {
                    info.Finishes++;
                    info.TotalTimeToGoal += timeToGoal.Ticks;
                    return;
                }
            }
            highscores.Add(new LeaderInfo(critterName, creator, timeToGoal));
        }

        private void SortFinishers()
        {
            // Kludge to sort list.  Replace this later.
            IEnumerable<LeaderInfo> list = highscores.OrderBy(order => order.AverageTimeToGoal).ToList();
            highscores.Clear();
            foreach (LeaderInfo info in list)
            {
                highscores.Add(info);
            }
        }

        public void AddFinisher(string critterName, string creator, TimeSpan timeToGoal)
        {
            lock (highscores)
            {
                AddFinisherToHighscores(critterName, creator, timeToGoal);
                SortFinishers();
                SaveFinishers();
            }
        }

        public BindingList<Leaderboard.LeaderInfo> Highscores
        {
            get
            {
                return highscores;
            }
        }

    }
}
