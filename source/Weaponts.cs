using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace SystemOfWeaponts
{
    [Serializable]
    public class Weaponts
    {
        public List<Weapont> weaps { get; private set; }

        public Weaponts()
        {
            string json;
            FileStream fileStream = new FileStream("weaponts.json", FileMode.Open);
            StreamReader streamReader = new StreamReader(fileStream);
            json = streamReader.ReadToEnd();
            streamReader.Close();
            fileStream.Close();
            weaps  = JsonConvert.DeserializeObject<List<Weapont>>(json);
        }
    }
}
