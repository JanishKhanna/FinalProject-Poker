using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject_Poker
{
    public class MyPlayer
    {
        public string Name { get; set; }
        public List<Card> Cards { get; set; }

        public MyPlayer(string name)
        {
            Name = name;
        }
    }
}
