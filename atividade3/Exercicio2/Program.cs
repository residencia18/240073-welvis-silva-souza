enum Tipo
{
    Comida,
    Bebida,
    Higiene,
    Limpeza
}

class ItemMercado
{
    public string Nome { get; set; }
    public Tipo Tipo { get; set; }
    public double Preco { get; set; }
}

class Program
{
    static void Main(string[] args)
    {
        List<ItemMercado> listaItens = new List<ItemMercado>
        {
            new ItemMercado { Nome = "Arroz", Tipo = Tipo.Comida, Preco = 3.90 },
            new ItemMercado { Nome = "Azeite", Tipo = Tipo.Comida, Preco = 2.50 },
            new ItemMercado { Nome = "Macarrão", Tipo = Tipo.Comida, Preco = 3.90 },
            new ItemMercado { Nome = "Cerveja", Tipo = Tipo.Bebida, Preco = 22.90 },
            new ItemMercado { Nome = "Refrigerante", Tipo = Tipo.Bebida, Preco = 5.50 },
            new ItemMercado { Nome = "Shampoo", Tipo = Tipo.Higiene, Preco = 7.00 },
            new ItemMercado { Nome = "Sabonete", Tipo = Tipo.Higiene, Preco = 2.40 },
            new ItemMercado { Nome = "Cotonete", Tipo = Tipo.Higiene, Preco = 5.70 },
            new ItemMercado { Nome = "Sabão em pó", Tipo = Tipo.Limpeza, Preco = 8.20 },
            new ItemMercado { Nome = "Detergente", Tipo = Tipo.Limpeza, Preco = 2.60 },
            new ItemMercado { Nome = "Amaciante", Tipo = Tipo.Limpeza, Preco = 6.40 }
        };

        var itensHigiene = listaItens.Where(item => item.Tipo == Tipo.Higiene).OrderByDescending(item => item.Preco).ToList();

        var itensPrecoMaiorIgual5 = listaItens.Where(item => item.Preco >= 5.00).OrderBy(item => item.Preco).ToList();

        var itensComidaBebida = listaItens.Where(item => item.Tipo == Tipo.Comida || item.Tipo == Tipo.Bebida).OrderBy(item => item.Nome).ToList();

        var quantidadePorTipo = listaItens.GroupBy(item => item.Tipo).Select(group => new { Tipo = group.Key, Quantidade = group.Count() }).ToList();

        var estatisticasPorTipo = listaItens.GroupBy(item => item.Tipo).Select(group => new
        {
            Tipo = group.Key,
            PrecoMaximo = group.Max(item => item.Preco),
            PrecoMinimo = group.Min(item => item.Preco),
            PrecoMedia = group.Average(item => item.Preco)
        }).ToList();
    }
}
