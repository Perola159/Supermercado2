﻿using Core.Entidades;
using FrontEnd.Models.DTO.dtos;
using TrabalhoFinal._02_Repository;

namespace TrabalhoFinal._01_Services;

public class CarrinhoService
{
    public CarrinhoRepository repository { get; set; }
    public CarrinhoService(string _config)
    {
        repository = new CarrinhoRepository(_config);
    }
    public void Adicionar(Carrinho carrinho)
    {
        repository.Adicionar(carrinho);
    }

    public void Remover(int id)
    {
        repository.Remover(id);
    }

    public List<Carrinho> Listar()
    {
        return repository.Listar();
    }
    public Carrinho BuscarTimePorId(int id)
    {
        return repository.BuscarPorId(id);
    }

    public List<ReadCarrinhoDTO> ListarCarrinhoDoUsuario(int usuarioId)
    {
        return repository.Listar();
    }
    public void Editar(Carrinho editPessoa)
    {
        repository.Editar(editPessoa);
    }
}
