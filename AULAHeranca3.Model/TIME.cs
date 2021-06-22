using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AULAHeranca3.Model
{
    public class TIME : PESSOA
    {
        public TIME(string pNome, string pTime)
        {
            Nome = pNome;
            Time = pTime;
        }
        public TIME(int ID)
        {

        }

        public TIME()
        {
        }

        public string Nome { get; set; }
        public string Time { get; set; }
    }
}
