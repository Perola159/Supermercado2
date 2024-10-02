using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrontEnd.Models.DTO.dtos
{
    public class ReadCarrinhoDTO
    {
        public int Id { get; set; }
        public Usuario Usuario { get; set; }
        public Produto Produto { get; set; }

        public override string ToString()
        {
            return $"Usuario {Usuario.Nome} - Produto : {Produto.Nome} - Preço: {Produto.Preco}";
        }

    }
}
