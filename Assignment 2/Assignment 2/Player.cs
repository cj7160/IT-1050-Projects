

namespace Assignment_2
{
    class Player
    {
        public string CityName;
        public string StageName;
        public float KD;
        public Player counterpart;

        public static float SumOfKD;

        public static float totalKD()
        {
            return SumOfKD;
        }

        public void Playerinformation()
        {
            this.CityName = Questions.GetString("Team Name");
            this.StageName = Questions.GetString("Stage Name");
            this.KD = Questions.GetFloat("Player KD");

            Player.SumOfKD += this.KD;
        }

    }
}
