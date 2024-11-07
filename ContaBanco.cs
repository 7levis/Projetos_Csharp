using System;

namespace ContaBancaria
{
    public class ContaBanco
    {
        public  int NumConta{get; set; }
        public string Tipo{get; set; }
        public string Titular{get; set; }
        private int Saldo;
        public bool Status {get; private set; }
    

        public ContaBanco(int numConta, string tipo, string titular)
        {
                NumConta = numConta;
                Tipo = tipo;
                Titular = titular;
                 
        }
        public void abrirConta()
        {

        }
        public void fecharConta()
        {

        }
        public void depositar()
        {
        
        }
        public void sacar()
        {

        }
        public void pagarMensal()
        {
            
        }
    }
}
