using FrontEnd.Models.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace FrontEnd.UseCases
{
    public class ProdutoUC
    {
        private readonly HttpClient _client;
        public ProdutoUC(HttpClient cliente)
        {
            _client = cliente;
        }
        public List<Produto> ListarProduto()
        {
            return _client.GetFromJsonAsync<List<Produto>>("Produto/listar-Produto").Result;
        }

        public void CadastrarProdutos(Produto produto)
        {
            HttpResponseMessage response = _client.PostAsJsonAsync("Produto/adicionar-Produto", produto).Result;
        }
    }
}
