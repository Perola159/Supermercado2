using AutoMapper;
using Core._03_Entidades;
using Microsoft.AspNetCore.Mvc;
using TrabalhoFinal._01_Services;

namespace API.Controllers;

[ApiController]
[Route("[controller]")]
public class EnderecoController : ControllerBase
{
    private readonly EnderecoService _service;
    private readonly IMapper _mapper;
    public EnderecoController(IConfiguration config, IMapper mapper)
    {
        string _config = config.GetConnectionString("DefaultConnection");
        _service = new EnderecoService(_config);
        _mapper = mapper;
    }
    [HttpPost("adicionar-Endereco")]
    public void AdicionarAluno(Endereco EnderecoDTO)
    {
        Endereco endereco = _mapper.Map<Endereco>(EnderecoDTO);
        _service.Adicionar(EnderecoDTO);
    }
    [HttpGet("listar-Endereco-Usuario")]
    public List<Endereco> ListarAluno()
    {
        return _service.Listar();
    }
    [HttpPut("editar-Endereco-Usuario")]
    public void EditarEndereco(Endereco end)
    {
        _service.Editar(end);
    }
    [HttpDelete("deletar-produto")]
    public void DeletarEndereco(int id)
    {
        _service.Remover(id);
    }
}
