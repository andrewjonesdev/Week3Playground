using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Week3Playground
{
    public interface IPirate
    {
        public void SetPirateCrew(PirateCrew Crew);
        public PirateCrew GetPirateCrew();
        public void SetSail();
        public void SetSail(string Island);
    }
}
