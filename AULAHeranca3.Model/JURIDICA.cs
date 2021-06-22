using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AULAHeranca3.Model
{
   public class JURIDICA : PESSOA
    {
        public JURIDICA()
        {
        }

        public JURIDICA(int ID): base(ID)
        {

        }
        public string CNPJ { get; set; }
        public string RazaoSocial { get; set; }
        public string NomeFantasma { get; set; }
    }
}
