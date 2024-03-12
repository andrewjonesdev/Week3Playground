using System.Security.Cryptography;

namespace Week3Playground
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var captainKid = new Pirate("Eustass Kid", null, new List<Haki> { Haki.Armament, Haki.Conquerers, Haki.Observation }, new Tuple<string, string>("Magnet - Magnet Fruit", "Paramecia"), 3000000000L);
            var kidPirates = new PirateCrew("Kid Pirates", 2, new List<Pirate>());
            kidPirates.Members.Add(captainKid);
            captainKid.SetPirateCrew(kidPirates);
            Console.WriteLine($"{captainKid.GetPirateCrew().CrewName}");
            captainKid.SetSail();
            captainKid.SetSail("Laugh Tale");
            var mihawk = new Pirate("Dracule Mihawk", null, new List<Haki> { Haki.Armament, Haki.Conquerers, Haki.Observation }, new Tuple<string, string>("Magnet - Magnet Fruit", "Paramecia"), 3600000000L);
            var crossGuild = new PirateCrew("Cross Guild", 3, new List<Pirate>());
            mihawk.FightPirate(captainKid);
            mihawk.SayHi();
        }



    }
}
