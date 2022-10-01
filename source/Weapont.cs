using System;

namespace SystemOfWeaponts
{
    [Serializable]
    public class Weapont
    {
        public int ID { get; private set; }
        public string Name { get; private set; }
        public double Probability { get; private set; }

        public Weapont(int id, string name, double probability)
        {
            ID = id;
            Name = name;

            if (probability < 0 || probability > 1)
                throw new Exception("Probability is invalide (001)");

            Probability = probability;
        }

        public void ChangeProbability(double delta)
        {
            if(delta < -1 || delta > 1)
                throw new Exception("Change of Probability is invalid (002)");

            Probability += delta;

            if (Probability > 1)
                Probability = 1;
            if(Probability < 0)
                Probability = 0;
        }

        public override string ToString()
        {
            return Name + " - " + Probability * 100 + "%";
        }
    }
}
