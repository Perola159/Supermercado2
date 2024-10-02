using FrontEnd.Models.DTO;
using FrontEnd.Models.DTO.dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace FrontEnd.UseCases
{
    public class CarrinhoUC
    {


        private readonly HttpClient _client;
        public CarrinhoUC(HttpClient cliente)
        {
            _client = cliente;
        }
        public void CadastrarCarrinho(Carrinho carrinho)
        {
            HttpResponseMessage response = _client.PostAsJsonAsync("Carrinho/adicionar-carrinho", carrinho).Result;
        }
        public List<ReadCarrinhoDTO> ListarCarrinhoUsuarioLogado(int usuarioId)
        {
            return _client.GetFromJsonAsync<List<ReadCarrinhoDTO>>("Carrinho/listar-carrinho-usuario?" + usuarioId).Result;
        }
    }
}
