var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

List<Produto> produtos = new List<Produto>();
produtos.Add(new Produto("Celular", "IOS"));
produtos.Add(new Produto("Celular", "Android"));
produtos.Add(new Produto("banana", "fruta"));
produtos.Add(new Produto("carro", "BMW"));

//Funcionalidades da aplicação - EndPoints

app.MapGet("/produtos/listar", () => "Listagem de produto");


//EXERCICIO - cadastrar produtos dentro da lista
app.MapPost("/produtos/cadastro", () => "cadastro de Produto");

app.Run();

record Produto(string nome, string descricao);
