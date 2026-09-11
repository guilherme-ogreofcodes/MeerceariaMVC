using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MerceariaMVC.Models;

namespace MerceariaMVCTests;

public class ClienteTests
{
    [Fact]
    public void Verificar_Idade_Menor_Dezoito_Invalido()
    {
        var cliente = new Cliente
        {
            Nome = "",
            Email = "joao@email.com",
            Idade = 17,
            Ativo = true
        };
        var resultado = cliente.Validar();

        Assert.False(resultado);
    }
    [Fact]
    public void Verificar_Email_Invalido()
    {
        var cliente = new Cliente
        {
            Nome = "Joao",
            Email = "joao",
            Idade = 17,
            Ativo = true
        };
        var resultado = cliente.Validar();

        Assert.False(resultado);
    }
    [Fact]
    public void Verificar_Nome_Vazio_Invalido()
    {
        var cliente = new Cliente
        {
            Nome = "",
            Email = "joao@email.com",
            Idade = 17,
            Ativo = true
        };
        var resultado = cliente.Validar();

        Assert.False(resultado);
    }
    [Fact]
    public void Cliente_Inativo_Nao_Pode_Comprar()
    {
        var cliente = new Cliente
        {
            Nome = "Joao",
            Email = "joao@email.com",
            Idade = 17,
            Ativo = false
        };
        var resultado = cliente.PodeComprar();

        Assert.False(resultado);
    }
    [Fact]
    public void Cliente_Ativo_Maior_De_Idade_Pode_Comprar()
    {
        var cliente = new Cliente
        {
            Nome = "Joao",
            Email = "joao@email.com",
            Idade = 19,
            Ativo = true
        };
        var resultado = cliente.PodeComprar();

        Assert.False(resultado);
    }
    [Fact]
    public void Cliente_Sem_Email_E_Invalido()
    {
        var cliente = new Cliente
        {
            Nome = "Joao",
            Email = "",
            Idade = 17,
            Ativo = true
        };
        var resultado = cliente.Validar();

        Assert.False(resultado);
    }
    [Fact]
    public void Cliente_Com_Idade_Negativa_E_Invalida()
    {
        var cliente = new Cliente
        {
            Nome = "",
            Email = "joao@email.com",
            Idade = 17,
            Ativo = true
        };
        var resultado = cliente.Validar();

        Assert.False(resultado);
    }
}
