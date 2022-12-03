using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrentAccountManager.Titular
{
    public class Client
    {
        private string Name;
        private string Cpf;
        private string Profisao;
        
        public string getName()
        {
            
            return Name;
        }
        public void setName(string name)
        {
            this.Name = name;
            
        }


        public string getCpf()
        {

            return this.Cpf;
        }
        public void  setCpf(string cpf)
        {
            this.Cpf = cpf;
            
        }

        public string getProfissao()
        {
            return this.Profisao;

        }

        public void setProfissao(string profissao)
        {
            this.Profisao= profissao;

        }

    }
}
