namespace HowToInitializeObjects;
public class HowToIndexInitializer
{
    public class BaseballTeam
    {
        private string[] players = new string[9];
        private readonly List<string> positionAbreviations = new List<string>()
        {
            "P", "C", "1B", "2B", "3B", "SS", "LF", "CF", "RF"
        };

        public string this[int position]
        {
            // Baseball positions are 1 - 9.
            get { return players[position -1]; }
            set { players[position - 1] = value; }
        }

        public string this[string position]
        {
            get { return players[positionAbreviations.IndexOf(position)]; }
            set { players[positionAbreviations.IndexOf(position)] = value; }
        }        
    }
    public static void Run()
    {
        var team = new BaseballTeam()
        {
            ["RF"] = "Mookie Betts",
            [4] = "Jose Altuve",
            ["CF"] = "Mike Trout"
        };
        team[1] = "Duc Tran";

        for(int i = 0; i < 9; i++)
        {
            try
            {
                Console.WriteLine(team[i]);
            }
            catch {
                Console.WriteLine("HAHA");
            }
        }
    }
}
