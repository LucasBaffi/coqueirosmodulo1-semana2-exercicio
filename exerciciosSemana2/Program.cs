﻿// See https://aka.ms/new-console-template for more information

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

using Ficha;

FichaInscricao minhaFicha = new FichaInscricao();

// atribuir valores às propriedades do objeto
minhaFicha.Id = 1;
minhaFicha.Nome = "João";
minhaFicha.DataNascimento = new DateTime(2000, 1, 1);
minhaFicha.MenorIdade = false;

// chamar o método ImprimirDados() para imprimir os dados do objeto no console
minhaFicha.ImprimirDados();

