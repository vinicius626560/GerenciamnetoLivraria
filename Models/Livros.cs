public class Livro
{
	private string titulo = "";
	private string autor = "";
	public int estoque = 20;
	public int Isbn = 123321;
	
	public string GetTitulo()
	{
		string Titulo = titulo;
		return titulo;    
	}
	public void SetTitulo(string titulo)
	{
		if (Confirma()){
		this.titulo = titulo;
		Console.WriteLine("Livro alugado com sucesso!", titulo);
		}
	}
	
	public int AlugarLivro()
	{
		return ((-1)*estoque) ;
	}
		 
	public bool Confirma()
	{
		Console.WriteLine("Você deseja alugar um livro 'S/N'?");
		string r = Console.ReadLine();
		if (r == "s")
		{
			return true;
		}
		else return false;
	}
	public string GetAutor()
	{
		string Autor = autor;
		Console.WriteLine("Autor: Antoine de Saint-Exupéry");
		return autor;    
	}
	public void SetAutor(string autor)
	{
		if (Confirma()){
		this.autor = autor;
		}
	}
	public int GetEstoque()
	{
		int Estoque = estoque;
		Console.WriteLine("estoque:");
		return estoque; 
	}
	public void SetEstoque(string estoque)
	{
		if (Confirma()){
		
		}
	}
	public int GetIsbn()
	{
		int isbn = Isbn;
		Console.WriteLine("Isbn:");
		return isbn; 
		
	}
	public void SetIsbn(int isbn)
	{
		if (Confirma()){
		this.Isbn = isbn;
		
		}
	}
}


