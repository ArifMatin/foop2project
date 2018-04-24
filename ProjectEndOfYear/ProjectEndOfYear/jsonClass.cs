using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;
using System.Collections.ObjectModel;

namespace ProjectEndOfYear
{
    class jsonClass
    {
        private void SavePerson()
        {
            JsonSerializerSettings settings = new JsonSerializerSettings
            {
                TypeNameHandling = TypeNameHandling.All
            };

            //write to file
            using (StreamWriter sw = new StreamWriter(@"../../vehicleFile.json"))
            {
                //string json = JsonConvert.SerializeObject(vehicleCollection, settings);
                //sw.Write(json);
            }

        }

        private void LoadPerson()
        {
            JsonSerializerSettings settings = new JsonSerializerSettings
            {
                TypeNameHandling = TypeNameHandling.All
            };

            using (StreamReader r = new StreamReader(@"../../vehicleFile.json"))
            {

                string json = r.ReadToEnd();
                //ObservableCollection<Vehicle> items = JsonConvert.DeserializeObject<ObservableCollection<Vehicle>>(json, settings);

            }
        }
    }
}
