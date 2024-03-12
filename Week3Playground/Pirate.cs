using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3Playground
{
    public class Pirate : Person, IPirate
    {
        public string Name { get; set; }
        private PirateCrew? Crew { get; set; }
        public List<Haki> Skills { get; set; }
        public Tuple<string, string> DevilFruit { get; set; }
        public long Bounty { get; set; } = 0;

        public Pirate(string Name, PirateCrew Crew, List<Haki> Skills, Tuple<string, string> DevilFruit, long Bounty = 0L)
        {
            this.Name = Name;
            this.Crew = Crew;
            this.Skills = Skills;
            this.DevilFruit = DevilFruit;
            this.Bounty = Bounty;
        }

        public void SetPirateCrew(PirateCrew Crew)
        {
            this.Crew = Crew;
        }
        public PirateCrew GetPirateCrew()
        {
            return Crew;
        }


        public override void SetSail()
        {
            Console.WriteLine($"{Name} of the {GetPirateCrew().CrewName} has set sail!");

        }

        public void SetSail(string Island)
        {
            Console.WriteLine($"{Name} of the {GetPirateCrew().CrewName} has set sail for {Island}!");
        }
    }
}
