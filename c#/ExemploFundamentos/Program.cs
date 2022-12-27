using ExemploFundamentos.Models;
//Nome da Classe, Atributos e Métodos começa com Maiuscula, variavel com minuscula

Calculadora calc = new Calculadora();

// calc.Somar(10, 30);
// calc.Subtrair(10, 50);
// calc.Multiplicar(15, 45);
// calc.Dividir(2, 2);
// calc.Potencia(3, 3);
calc.Seno(30);
calc.Cosseno(30);
calc.Tangente(30);

// bool choveu = false;
// bool estaTarde = false;
// 
// if (!choveu && !estaTarde)
// {
    // Console.WriteLine("vou pedalar");
// }
// else
// {
    // Console.WriteLine("vou pedalar outro dia");
// }

// bool possulPresencaMinima = true;
// double media = 8.5;
// 
// if (possulPresencaMinima && media >= 7)
// {
    // Console.WriteLine("Aprovado!");
// }
// else
// {
    // Console.WriteLine("Reprovado!");
// }

// bool ehMaiorDeIdade = false;
// bool possuiAutorizacaoDoResponsavel = false;
// 
// if (ehMaiorDeIdade || possuiAutorizacaoDoResponsavel)
// {
    // Console.WriteLine("Entrada Liberada!");
// }
// else
// {
    // Console.WriteLine("Entrada não liberada");
// }

// Console.WriteLine("Digite uma letra");
// string letra = Console.ReadLine();
// 
// switch(letra)
// {
    // case "a":
    // case "e":
    // case "i":
    // case "o":
    // case "u":
        // Console.WriteLine("vogal");
        // break;
    // default:
        // Console.WriteLine("Não é vogal");
        // break;
// }


// if(letra == "a" ||
//    letra == "e" ||
//    letra == "i" ||
//    letra == "o" ||
//    letra == "u")
// {
    // Console.WriteLine("vogal");
// }
// else
// {
    // Console.WriteLine("Não é uma vogal");
// }


// if (letra == "a")
// {
    // Console.WriteLine("vogal");
// }
// else if (letra == "e")
// {
    // Console.WriteLine("vogal");
// }
// else if (letra == "i")
// {
    // Console.WriteLine("vogal");
// }
// else if (letra == "o")
// {
    // Console.WriteLine("vogal");
// }
// else if (letra == "u")
// {
    // Console.WriteLine("vogal");
// }
// else
// {
    // Console.WriteLine("Não é vogal");
// }




// int quantidadeEmEstoque = 3;
// int quantidadeCompra = 0;
// bool possivelVenda = quantidadeCompra > 0 && quantidadeEmEstoque >= quantidadeCompra;
// 
// Console.WriteLine($"Quantidade em estoque: {quantidadeEmEstoque}");
// Console.WriteLine($"Quantidade compra: {quantidadeCompra}");
// Console.WriteLine($"É possível realizar a venda? {possivelVenda}");
// 
// if(quantidadeCompra == 0)
// {
    // Console.WriteLine("Venda inválida");
// }
// else if(possivelVenda)
// {
    // Console.WriteLine("Venda realizada.");
// }
// else
// {
    // Console.WriteLine("Desculpe. Não temos a quantidade desejada em estoque.");
// }


// string a ="15-";
//int b = 0;
// int.TryParse(a, out int b);
// Console.WriteLine(b);

//cast implicito
// int a = 5;
// double b = a;
// int a = 5;
// long b = a;
// Console.WriteLine(b);

// cast string
// int inteiro = 5;
// string a = inteiro.ToString();
// Console.WriteLine(a);


// Cast - Casting
//int a = Convert.ToInt32(null);
//int a = int.Parse("5");

//Console.WriteLine(a);


// int a = 10;
// int b = 20;

// int c = a + b;

//c = c + 5;

//c += 5;

//c -= 5;

//c *= 5;

// Console.WriteLine(c);


// DateTime dataAtual = DateTime.Now.AddDays(5);
// Console.WriteLine(dataAtual.ToString("dd/MM/yyyy HH:mm"));



// string apresentacao = "Olá, seja bem vindo";

// int quantidade = 1;
// Console.WriteLine("Valor da variável quantidade: " + quantidade);

// quantidade = 10;
// Console.WriteLine("Valor da variável quantidade: " + quantidade);


// double altura = 1.80;

// decimal preco = 1.80M;

// bool condicao = true;

// Console.WriteLine(apresentacao);
// Console.WriteLine("Valor da variável quantidade: " + quantidade);
// Console.WriteLine("Valor da variável altura: " + altura.ToString("0.00"));
// Console.WriteLine("Valor da variável preco: " + preco);
// Console.WriteLine("Valor da variável condicao: " + condicao);


// Pessoa pessoa1 = new Pessoa();

// pessoa1.Nome = "Buta";
// pessoa1.Idade = 26;
// pessoa1.Apresentar();

// Pessoa pessoaFisicaRepresentacao = new Pessoa();