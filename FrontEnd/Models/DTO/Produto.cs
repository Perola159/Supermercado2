﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrontEnd.Models.DTO
{
    public class Produto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public double Preco { get; set;}

        public override string ToString()
        {
            Console.WriteLine("---------Produtos Listados-----------");
            return $" Id: {Id}, Nome: {Nome}, Preço: {Preco}";
            Console.WriteLine("---------------------------------------");
        }
    }
}
