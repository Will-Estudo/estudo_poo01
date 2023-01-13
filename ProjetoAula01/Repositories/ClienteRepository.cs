using ProjetoAula01.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAula01.Repositories
{
    public class ClienteRepository
    {
        public void ExportarDados(Cliente cliente)
        {
            using (var streamWriter = new StreamWriter($"C:\\Willian\\Clientes\\cliente_{cliente.Id}.txt"))
            {
                streamWriter.WriteLine($"ID do cliente..: {cliente.Id}");
                streamWriter.WriteLine($"Nome...........: {cliente.Nome}");
                streamWriter.WriteLine($"Telefone.......: {cliente.Telefone}");
                streamWriter.WriteLine($"Email..........: {cliente.Email}");
                streamWriter.WriteLine($"CPF............: {cliente.Cpf}");
            }
        }
    }
}
