using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace livecsharp.classes
{
    public class Aluno
    {
        //método construtor
        public Aluno(int id = 0, string nome = null, string email = null, string telefone = null, string senha = null, bool ativo = false)
        {
            Id = id;
            Nome = nome;
            this.email = email;
            this.telefone = telefone;
            this.senha = senha;
            this.ativo = ativo;
        }
        

        //propriedades

        public  int Id { get; set; }
        public string Nome { get; set; }
        public string email { get; set; }
        public string telefone { get; set; } 
        public string senha { get; set; }
        public bool ativo { get; set; }

        public void Inserir() 
        {
            var cmd = Banco.abrir();
        }
    }
   
}
