using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TicTacToe_BackEnd.Entities
{
    public class Player
    {
        public int id { get; set; }
        public string pnr { get; set; }
        public string name { get; set; }
        public string email { get; set; }

        public int fkAdress { set; get; }
        public Address address { get; set; }
    }
}
