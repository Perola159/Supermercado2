using FrontEnd;
using System.Text.Json;
HttpClient cliente = new HttpClient
{
    BaseAddress = new Uri("https://localhost:7096/") //base igual para facilitar
};


Sistema sistema = new Sistema(cliente);  
sistema.IniciarSistema();

//string apiURL = "https://localhost:7096/Usuario/listar-usuario";

//using HttpClient cliente = new HttpClient();
//HttpResponseMessage response = await cliente.GetAsync(apiURL);
//string resposta = await response.Content.ReadAsStringAsync();
//List<Usuario> usu = JsonSerializer.Deserialize<List<Usuario>>(resposta);
//Console.ReadLine();