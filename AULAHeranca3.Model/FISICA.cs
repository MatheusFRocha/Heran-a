using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AULAHeranca3.Model
{
    public class FISICA : PESSOA

    {
        public FISICA(int ID) : base(ID)
        {
       
        }
        public FISICA(string pNOME, string pCPF)
        {
            Nome = pNOME;
            CPF = pCPF;
        }
        public FISICA()
        {

        }
        
        public string Nome{ get; set; }
        public string CPF { get; set; }
       
    }
}
