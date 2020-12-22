﻿using System;
using POO_Interfaces.Classes;

namespace POO_Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Carrinho carrinho = new Carrinho();

            Produto p1 = new Produto();
            p1.Codigo = 123;
            p1.Nome = "Playstation 5";
            p1.Preco = 10000;

            Produto p2 = new Produto();
            p2.Codigo = 124;
            p2.Nome = "X Box Series X";
            p2.Preco = 5000;

            Produto p3 = new Produto();
            p3.Codigo = 125;
            p3.Nome = "Nintendo Switch";
            p3.Preco = 3000;

            carrinho.Cadastrar(p1);
            carrinho.Listar();
            carrinho.Cadastrar(p2);

            carrinho.Alterar(p1.Codigo , p3);
            carrinho.Listar();
        }
    }
}