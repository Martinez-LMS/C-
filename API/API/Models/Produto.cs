namespace API.Models;

public class Produto
{
    //Construtor
    public Produto()
    {

    }
    public Produto(string nome, string descricao, double valor)
    {

        Nome = nome;
        Descricao = descricao;
        Valor = valor;
    }



    //ATRIBUTOS(JAVA) || PROPRIEDADES(C#) = CARACTERISTICAS DE UM OBJETO.
    public string? Nome { get; set; }

    public string? Descricao { get; set; } // digita prop + TAB cria o comando

    public double Valor { get; set; }



    //private string nome;
    //public void setNome(string nome){ 
    //this.nome = nome;
    //}
    //public string getNome(){
    //return this.nome;
    // }

}

