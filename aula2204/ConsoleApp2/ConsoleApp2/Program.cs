using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Cadastro { 
        ArrayList clientes = new ArrayList();
        ArrayList fornecedores = new ArrayList(); 
        public void relacionarClientes(PessoaFisica pessoa) { 
            pessoa.MostrarDescricao(); 
        } public void relacionarFornecedores(PessoaJuridica fornecedor) { 
            fornecedor.MostrarDescricao(); } 
        public void AdicionarCliente(PessoaFisica pessoa) { 
            clientes.Add(pessoa); 
        } 
        public void RemoverCliente(PessoaFisica pessoa) { 
            clientes.Remove(pessoa);
        } 
        public void AdicionarFornecedor(PessoaJuridica fornecedor) { 
            fornecedores.Add(fornecedor); 
        } public void RemoverFornecedor(PessoaJuridica fornecedor) { 
            fornecedores.Add(fornecedor); 
        } 
    }
}
