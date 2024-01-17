using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tic_Tac_Toe
{
    public class GameCell
    {
        private int _value;
        private int _x;
        private int _y;
        public int Value { get => _value; set => _value = value; }
        public int X { get => _x; set => _x = value; }
        public int Y { get => _y; set => _y = value; }
    }
}
