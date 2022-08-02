using System.Collections.Generic;
using TopBank_ATM.Domain.Dtos;

namespace TopBank_ATM.Domain.Entities
{
    public class Cliente
    {
        public int ClienteId { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }

        public ClienteDto ConverterParaDto()
        {
            return new ClienteDto
            {
                ClienteId = this.ClienteId,
                Nome = this.Nome,
                Cpf = this.Cpf,
            };
        }

        public static List<ClienteDto> ConverterParaDto(List<Cliente> clientes)
        {
            List<ClienteDto> clientesDto = new List<ClienteDto>();

            foreach (Cliente cliente in clientes)
            {
                ClienteDto dto = cliente.ConverterParaDto();
                clientesDto.Add(dto);
            }

            return clientesDto;
        }
    }
}
