 using System;

namespace AULAHeranca3.Model
{
    public class PESSOA
    {

        public PESSOA(int pId, string pLogradouro, string pNumero, string pBairro, string pCidade, string pCEP)
        {
            Id = pId;
            Logradouro = pLogradouro;
            Numero = pNumero;
            Bairro = pBairro;
            Cidade = pCidade;
            CEP = pCEP;
        }
        public PESSOA(){}
           

     public PESSOA(int ID)
        {
            Id = ID;
        }
        public int Id { get; set; }
        public string Logradouro { get; set; }
        public string Numero { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string CEP { get; set; }
        
    }
}
