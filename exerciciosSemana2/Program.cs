// See https://aka.ms/new-console-template for more information



using Celular;
using Ficha;
using somGuitarra;

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




