using exemploFundamentos.Common.models;

// Pessoa p = new Pessoa();

// p.Nome = "Breno";
// p.Idade = 40;
// p.Apresentar();

// string a = "15";
// int b = 0;

// int.TryParse(a,  out b);


// Console.WriteLine(b);
// Console.WriteLine("Conversão realizada com sucesso!!!");

// int quantidadeEmEstoque = 10;
// int quantidadeCompra = 4;
// bool possivelVenda = quantidadeEmEstoque >= quantidadeCompra;

// Console.WriteLine("Quantidade em Estoque: " + quantidadeEmEstoque);
// Console.WriteLine("Quantidade compra: " + quantidadeCompra);
// Console.WriteLine("É possível realizar a venda?: " + possivelVenda);

// if(possivelVenda) {
//     Console.WriteLine("Venda realizada com sucesso!");
// } else {
//     Console.WriteLine("Desculpe. Não temos quantidade desejada em estoque.");
// }

// Calculadora calc = new Calculadora();

// calc.somar(2, 3);
// calc.subtrair(2, 3);
// calc.multiplicar(2, 3);
// calc.dividir(18, 3);
// calc.potencia(2, 2);
// calc.potencia(3, 3);
// calc.Seno(30);
// calc.Coseno(30);
// calc.Tangente(30);
// calc.RaizQuadrada(9);

//  string opcao;
//  bool exibirMenu = true;

//  while(exibirMenu)
//  {
//      Console.Clear();
//      Console.WriteLine("Digite a sua opção:");
//      Console.WriteLine("1 - Cadastrar cliente");
//      Console.WriteLine("2 - Buscar cliente");
//      Console.WriteLine("3 - Apagar cliente");
//      Console.WriteLine("4 - Encerrar");

//      opcao = Console.ReadLine();

//      switch(opcao)
//      {
//          case "1":
//          Console.WriteLine("Cadastro de cliente");
//          break;

//          case "2":
//          Console.WriteLine("Busca de cliente");
//          break;
        
//          case "3":
//          Console.WriteLine("Apagar cliente");
//          break;
        
//          case "4":
//          Console.WriteLine("Encerrar");
//          exibirMenu = false;
//          //Environment.Exit(0);        
//          break;

//          default:
//              Console.WriteLine("Opção inválida");
//              break;
//      }
//  }
//  // Esta linha só será executada se declarada a variável boolean no case 4, de outra forma é encerrado na escolha do case 4
//  Console.WriteLine("O Programa foi finalizado");

int[] arrayInteiros = new int[4];

arrayInteiros[0] = 44;
arrayInteiros[1] = 56;
arrayInteiros[2] = 98;
arrayInteiros[3] = 1;

Console.WriteLine("Percorrendo o Array com o FOR");
for(int i = 0; i < arrayInteiros.Length; i++) {
    Console.WriteLine($"Posição Nº {i} - {arrayInteiros[i]}");
}

int contador = 0;
Console.WriteLine("Percorrendo o Array com o FORREACH");
foreach(int valor in arrayInteiros) {
    Console.WriteLine("Posição Nº " + contador + " - " + valor);
    contador++;
}