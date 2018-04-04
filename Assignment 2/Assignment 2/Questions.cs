
namespace Assignment_2
{
    class Questions
    {
        public static string GetString(string thething)
        {
            System.Console.Write(thething + ". ");
            return System.Console.ReadLine();
        }
        public static float GetFloat(string thething)
        {
            return float.Parse(GetString(thething));
        }
    }
}
