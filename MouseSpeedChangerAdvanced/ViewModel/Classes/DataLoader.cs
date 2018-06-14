
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace MouseSpeedChangerAdvanced
{
    public class DataLoader
    {
        public ObservableCollection<ProfileData> LoadData()
        {
            ObservableCollection<ProfileData> allData = new ObservableCollection<ProfileData>();
            string data = File.ReadAllText("Profiles.txt");
            allData = JsonConvert.DeserializeObject<ObservableCollection<ProfileData>>(data);
            return allData;
        }
        public void SaveData(ObservableCollection<ProfileData> _data)
        {
            using (StreamWriter file = File.CreateText("Profiles.txt"))
            {
                JsonSerializer serializer = new JsonSerializer();
                serializer.Serialize(file, _data);
            }
        }
    }
}