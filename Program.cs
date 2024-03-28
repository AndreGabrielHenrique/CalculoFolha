string separador=new string('-',60);
Console.WriteLine(separador);
Console.WriteLine("Informe o nome do funcionário");
string nome=Console.ReadLine();
Console.WriteLine("Informe o salário inicial");
double salario=double.Parse(Console.ReadLine());
Console.WriteLine("Informe a taxa de imposto cobrado (%)");
int imposto=int.Parse(Console.ReadLine());
double salarioLiquido=CalculaSalarioLiquido();
Console.WriteLine(separador);
System.Console.WriteLine($"Nome:                                            {nome}");
System.Console.WriteLine($"Salário líquido:                                 {salarioLiquido:c}");
Console.WriteLine(separador);
Console.WriteLine("Informe qual a porcentagem do aumento");
int aumento=int.Parse(Console.ReadLine());
CalculaAumentoSalario(aumento);
salarioLiquido=CalculaSalarioLiquido();
Console.WriteLine(separador);
System.Console.WriteLine($"Nome:                                            {nome}");
System.Console.WriteLine($"Salário líquido:                                 {salarioLiquido:c}");
Console.WriteLine(separador);
double CalculaSalarioLiquido()
{
    double desconto=salario*imposto/100;
    return salario-desconto;
}
void CalculaAumentoSalario(int aumento)
{
    double valorAumento=salario*aumento/100;
    salario+=valorAumento;
}