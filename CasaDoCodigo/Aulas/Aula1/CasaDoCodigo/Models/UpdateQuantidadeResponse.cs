﻿using CasaDoCodigo.Models.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CasaDoCodigo.Models
{
    public class UpdateQuantidadeResponse
    {
        public UpdateQuantidadeResponse(ItemPedido itemPedido, CarrinhoViewModel carrinhoViewModel)
        {
            ItemPedido = itemPedido;
            this.carrinhoViewModel = carrinhoViewModel;
        }

        public ItemPedido ItemPedido { get; }
        public CarrinhoViewModel carrinhoViewModel { get; }
    }
}
