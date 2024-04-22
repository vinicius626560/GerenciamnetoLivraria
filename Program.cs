namespace livraria;

class Program
{
	static void Main(string[] args)
	{
		Livro PequenoPrincipe = new Livro();
	 
		PequenoPrincipe.SetTitulo("Titulo: Pequeno Principe");
		
		Console.WriteLine(PequenoPrincipe.GetTitulo());
		Console.WriteLine(PequenoPrincipe.GetAutor());
		Console.WriteLine(PequenoPrincipe.GetEstoque());
		Console.WriteLine(PequenoPrincipe.GetIsbn());
	}
}

