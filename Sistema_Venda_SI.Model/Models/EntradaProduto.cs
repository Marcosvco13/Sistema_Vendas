﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Sistema_Venda_SI.Model.Models;

public partial class EntradaProduto
{
    public int EnpCodigoProduto { get; set; }

    public int EnpCodigoEntrada { get; set; }

    public decimal EnpValorCusto { get; set; }

    public decimal EnpValorVenda { get; set; }

    public int EnpQuantidade { get; set; }

    public virtual Entrada EnpCodigoEntradaNavigation { get; set; }

    public virtual Produto EnpCodigoProdutoNavigation { get; set; }
}