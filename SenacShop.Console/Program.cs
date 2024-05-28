using SenacShop.DAL;
using SenacShop.DAL.DTO;

int opcao;
do
{
    Console.WriteLine("Escolha uma opção: ");
    Console.WriteLine("1 - Cadastrar Produto");
    Console.WriteLine("2 - Listar Produtos");
    Console.WriteLine("9 - Sair ");
    opcao = Convert.ToInt32(Console.ReadLine());

    if (opcao == 1)
    {
        Console.Write("Digite o nome do produto: ");
        string nome = Console.ReadLine();

        Console.Write("Digite a descrição do produto: ");
        string descricao = Console.ReadLine();

        Console.Write("Digite o preço: ");
        decimal preco = Convert.ToDecimal(Console.ReadLine());

        Console.Write("Digite a quantidade em estoque: ");
        int estoque = Convert.ToInt32(Console.ReadLine());

        Console.Write("Digite o código da categoria: ");
        //carregar as categorias
        CategoriaDal operacoesCategoria = new CategoriaDal();
        List<CategoriaDto> categorias = operacoesCategoria.Listar();
        foreach (CategoriaDto item in categorias)
        {
            Console.WriteLine($"{item.id} - {item.nome}");
        }
        int categoria = Convert.ToInt32(Console.ReadLine());


        ProdutoDto produto = new ProdutoDto();
        produto.nome = nome;
        produto.descricao = descricao;
        produto.preco = preco;
        produto.estoque = estoque;
        produto.idCategoria = categoria;

        ProdutoDal operacoesProduto = new ProdutoDal();
        operacoesProduto.Cadastrar(produto);
        Console.WriteLine("Produto cadastrado com sucesso !");
    }

    if (opcao == 2)
    {
        //carregar os produtos
        ProdutoDal operacoesProduto = new ProdutoDal();

        List<ProdutoDto> produtos = operacoesProduto.Listar();
        foreach (ProdutoDto item in produtos)
        {
            Console.WriteLine("---------------");
            Console.WriteLine($"Código: {item.idProduto}");
            Console.WriteLine($"Nome: {item.nome}");
            Console.WriteLine($"Descição: {item.descricao}");
            Console.WriteLine($"Preço: {item.preco}");
            Console.WriteLine($"Estoque: {item.estoque}");
        }
    }
}
while (opcao != 9);
