﻿string separador=new string('-',60);
//Dados funcionario
Funcionario funcionario=new Funcionario();
Console.WriteLine(separador);
Console.WriteLine("Informe o nome do funcionário");
funcionario.nome=Console.ReadLine();
Console.WriteLine("Informe o salário inicial");
funcionario.salario=double.Parse(Console.ReadLine());
Console.WriteLine("Informe a taxa de imposto cobrado (%)");
funcionario.imposto=int.Parse(Console.ReadLine());
Console.WriteLine(funcionario);
Console.WriteLine("Informe qual a porcentagem do aumento");
int aumento=int.Parse(Console.ReadLine());
funcionario.CalculaAumentoSalario(aumento);
Console.WriteLine(funcionario.ToString());