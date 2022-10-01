using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace SystemOfWeaponts
{
    [Serializable]
    public class Answers
    {
        public List<Answer> answers { get; private set; }

        public Answers()
        {
            string json;
            FileStream fileStream = new FileStream("answers.json", FileMode.Open);
            StreamReader streamReader = new StreamReader(fileStream);
            json = streamReader.ReadToEnd();
            streamReader.Close();
            fileStream.Close();
            answers = JsonConvert.DeserializeObject<List<Answer>>(json);
        }
    }
}
