using System.Collections.Generic;
using TopBank_ATM.Domain.Entities;

namespace TopBank_ATM.Infrastructure.Contexts
{
    public interface IContext
    {
        public void CreateCliente(Cliente cliente);
        public List<Cliente> ReadCliente();
        public Cliente ReadCliente(int id);
        public void UpdateCliente(Cliente cliente);
        public void DeleteCliente(int id);
    }
}
