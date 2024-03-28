using API.Models;

internal class Program
{
    private static void Main(string[] args)
    {
        
        var builder = WebApplication.CreateBuilder(args);
        var app = builder.Build();
        
        Produto produto = new Produto();

        List<Produto> produtos = new List<Produto>();
        produtos.Add(new Produto("Celular", "IOS", 2000));
        produtos.Add(new Produto("Celular", "Android", 8.000));
        produtos.Add(new Produto("banana", "fruta", 23));
        produtos.Add(new Produto("carro", "BMW", 320.000));

        //Funcionalidades da aplicação - EndPoints

        //GET: http://localhost:5138/
        app.MapGet("/", () => "API de Produtos");

        // GET http://localhost:5138/produtos/listar
        app.MapGet("/produtos/listar", () => produtos);

        // GET http://localhost:5138/produtos/buscar/nomedoproduto
        app.MapGet("/produtos/buscar/{nome}", (string nome) =>
        {
            for (int i = 0; i < produtos.Count; i++)
            {
                if (produtos[i].Nome == nome)
                {

                    //retorna o produto encontrado

                    return Results.Ok(produtos[i]);
                }
            }
            return Results.NotFound("Produto não encontrado!");
        });


        // GET http://localhost:5138/produtos/cadastro
        app.MapPost("/produtos/cadastro/nome/cadastrar", (string nome, string cadastrar) => "cadastro de Produto");

        app.Run();
    }


}


