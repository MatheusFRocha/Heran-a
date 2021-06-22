using NUnit.Framework;
using AULAHeranca3.Model;
using System;

namespace AulaHeranca.Teste
{
    public class Teste_Heranca
    {
        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void Pessoa()
        {
            try
            {

                PESSOA obj = new PESSOA();
                obj.Id = 1;
                obj.Logradouro = "Rua XXXX";
                obj.Numero = "12345";
                obj.Cidade = "Resende";
                obj.Bairro = "Centro";
                obj.CEP = "27525-000";
                Assert.Pass();
            }

            catch (Exception ex)
            {
                if (ex.GetType().ToString().Contains("SuccessException"))

                {

                }
                else
                {
                    Assert.Fail("o teste de classe pessoa falhou: " + ex.Message);
                }

            }

        }


        [Test]
        public void Fisica()
        {
            FISICA oPF = new FISICA(1);

            oPF.Logradouro = "Rua XXXX";
            oPF.Numero = "12345";
            oPF.Cidade = "Resende";
            oPF.Bairro = "Centro";
            oPF.CEP = "27525-000";

            oPF.Nome = "Matheus";
            oPF.CPF = "00000000";
            Assert.IsTrue(oPF.Id == 1, "Valor diferente do passado no costrutor");
        }


        [Test]
        public void Juridica()
        {
            JURIDICA oPJ = new JURIDICA(2);
            oPJ.Logradouro = "Rua XXXX";
            oPJ.Numero = "12345";
            oPJ.Cidade = "Resende";
            oPJ.Bairro = "Centro";
            oPJ.CEP = "27525-000";

            oPJ.RazaoSocial = "Vendedor de couves";
            oPJ.NomeFantasma = "Super Couve";
            oPJ.CNPJ = "123123123";
            Assert.IsTrue(oPJ.Id == 2, "Valor diferente do passado no costrutor");

        }
    }
}