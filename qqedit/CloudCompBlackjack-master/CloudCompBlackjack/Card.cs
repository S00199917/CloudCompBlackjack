using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudCompBlackjack
{
    public class Card
    {
        public string CardName { get; set; }
        public string Suit { get; set; }

        public override string ToString()
        {
            return string.Format("{0} of {1}", CardName, Suit);
        }
    }
}
