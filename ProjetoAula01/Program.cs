using ProjetoAula01.Entities;
using ProjetoAula01.Repositories;

namespace ProjetoAula01
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("\n *** Controle de Clientes *** \n");

            var cliente = new Cliente();

            cliente.Id = Guid.NewGuid();

            Console.Write("Entre com o nome do cliente....: ");
            cliente.Nome = Console.ReadLine();

            Console.Write("Entre com o telefone do cliente....: ");
            cliente.Telefone = Console.ReadLine();

            Console.Write("Entre com o email do cliente....: ");
            cliente.Email = Console.ReadLine();

            Console.Write("Entre com o CPF do cliente....: ");
            cliente.Cpf = Console.ReadLine();

            Console.WriteLine("\nDados do Cliente:");
            Console.WriteLine($"\tID...........: {cliente.Id}");
            Console.WriteLine($"\tNome.........: {cliente.Nome}");
            Console.WriteLine($"\tTelefone.....: {cliente.Telefone}");
            Console.WriteLine($"\tEmail........: {cliente.Email}");
            Console.WriteLine($"\tCPF..........: {cliente.Cpf}");

            try
            {
                var clienteRepository = new ClienteRepository();
                clienteRepository.ExportarDados(cliente);
                Console.WriteLine("\nDados gravados com sucesso!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("\nErro ao cadastrar cliente!");
            }

            Console.ReadKey();
        }
    }
}