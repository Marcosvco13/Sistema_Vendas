﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Sistema_Venda_SI.Model.Models;

public partial class TipoProduto
{
    [Display(Name = "Código")]
    public int TipCodigo { get; set; }
    [Display(Name = "Descrição")]
    public string TipDescricao { get; set; }

    [Display(Name = "Desativado")]
    public bool TipDestivado { get; set; }

    public virtual ICollection<Produto> Produto { get; set; } = new List<Produto>();
}