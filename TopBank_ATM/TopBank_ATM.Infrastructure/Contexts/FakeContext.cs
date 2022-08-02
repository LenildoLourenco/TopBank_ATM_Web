using System.Collections.Generic;
using System.Linq;
using TopBank_ATM.Domain.Entities;

namespace TopBank_ATM.Infrastructure.Contexts
{
    public class FakeContext : IContext
    {
        private List<Cliente> _clientes;

        public FakeContext()
        {
            LoadData();
        }

        public void CreateCliente(Cliente cliente)
        {
            _clientes.Add(cliente);
        }

        public List<Cliente> ReadCliente()
        {
            return _clientes
                .OrderBy(p => p.ClienteId)
                .ToList();
        }

        public Cliente ReadCliente(int id)
        {
           Cliente result = _clientes
                .FirstOrDefault(p => p.Equals(id));
            return result;
        }

        public void UpdateCliente(Cliente cliente)
        {
            Cliente objPesquisa = ReadCliente(cliente.ClienteId);
            _clientes.Remove(objPesquisa);

            objPesquisa = new Cliente
            {
                ClienteId = cliente.ClienteId,
                Nome = !string.IsNullOrEmpty(cliente.Nome) ? cliente.Nome : objPesquisa.Nome,
                Cpf = !string.IsNullOrEmpty(cliente.Cpf) ? cliente.Cpf : objPesquisa.Cpf
            };
            _clientes.Add(objPesquisa);
        }

        public void DeleteCliente(int id)
        {
            Cliente cliente = ReadCliente(id);
            if(cliente != null)
                _clientes.Remove(cliente);
        }

        private void LoadData()
        {
            _clientes = new List<Cliente>();

            Cliente cliente = new Cliente
            {
                ClienteId = 1,
                Nome = "João Teste",
                Cpf = "12345678901"

            };
            _clientes.Add(cliente);

            cliente = new Cliente
            {
                ClienteId = 2,
                Nome = "José Teste",
                Cpf = "12378978901"

            };
            _clientes.Add(cliente);

            cliente = new Cliente
            {
                ClienteId = 3,
                Nome = "Maria Teste",
                Cpf = "23478978901"

            };
            _clientes.Add(cliente);

            cliente = new Cliente
            {
                ClienteId = 4,
                Nome = "Teste Teste",
                Cpf = "67878978901"

            };
            _clientes.Add(cliente);
        }
    }
}
