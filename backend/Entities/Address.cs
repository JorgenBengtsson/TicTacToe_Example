using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TicTacToe_BackEnd.Entities
{
    public class Address
    {
        public int id { get; set; }
        public string street { set; get; }

        
        public Player player { set; get; }
    }
}
