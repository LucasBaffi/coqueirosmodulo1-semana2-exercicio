// See https://aka.ms/new-console-template for more information

// Criar uma classe chamada FichaInscricao
// Detalhes da classe

// Modificador de acesso publico
// Propriedades
// Id tipo inteiro (int)
// Nome tipo texto (string)
// DataNascimento tipo DataHora (datetime)
// MenorIdade tipo boleano (bool)
// Criar um método que escreva no console o texto com os campos da Classe
// Exemplo. Código {Id}, Nome {Nome}, Data Nascimento {DataNascimento}
// Instanciar a classe no console conforme mostrado em aula
// criar um objeto da classe FichaInscricao

using Celular;
using Ficha;

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




