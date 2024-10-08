﻿using System.Net.Http.Json;

namespace FrontEnd.UseCases
{
    public class UsuarioUC
    {
        private readonly HttpClient _client;
        public UsuarioUC(HttpClient cliente)
        {
            _client = cliente;
        }

        public List<Usuario> ListarUsuarios()
        {
            return _client.GetFromJsonAsync<List<Usuario>>("Usuario/listar-usuario").Result;
        }
            public  void CadastrarUsuario(Usuario usuario)
        {
            HttpResponseMessage response = _client.PostAsJsonAsync("/Usuario/adicionar-usuario", usuario).Result;
        }

        public Usuario FazerLogin(UsuariologinDTO usulogin)
        {
            HttpResponseMessage response = _client.PostAsJsonAsync("Usuario/Fazer-Login", usulogin).Result;
            Usuario usuario = response.Content.ReadFromJsonAsync<Usuario>().Result;
            return usuario;
        }
    } 
}
