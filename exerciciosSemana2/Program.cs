// See https://aka.ms/new-console-template for more information



using Celular;
using Ficha;
using somGuitarra;
using cobranca;
using filmes;
using animacao;
using pessoaIdade;



FichaInscricao minhaFicha = new FichaInscricao();

// atribuir valores às propriedades do objeto
minhaFicha.Id = 1;
minhaFicha.Nome = "Lucas";
minhaFicha.DataNascimento = new DateTime(1993, 07, 11);
minhaFicha.MenorIdade = false;

// chamar o método ImprimirDados() para imprimir os dados do objeto no console
minhaFicha.ImprimirDados();


//mensagem celular-------------------------------------------------
MensagemCelular mensagem = new MensagemCelular();
mensagem.Telefone = 123456789;
mensagem.Mensagem = "Olá, mundo!";
mensagem.Executar();


//Gitarra-----------------------------
guitarra som = new guitarra();
som.Tocar();
som.Tocar("dó");


//cobrar----------------------

Cobrar valorMulta = new Cobrar(20.55m, 22.36m);
valorMulta.Calcular();

//filme---------------------------------

Filme filme = new Filme("Pulp Fiction", "Crime, Drama");

Console.WriteLine(filme.InformacoesFilme());

//animacao----------------------------


Animacao.Animação();
Animacao.Animação("Toy Story");


//pessoa-----------------------------
Pessoa pessoa = new Pessoa("Lucas", new DateTime(1993, 11, 7));





