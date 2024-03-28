class Funcionario
{
    public string nome;
    public double salario;
    public int imposto;

    public double CalculaSalarioLiquido()
    {
        double desconto=salario*imposto/100;
        return salario-desconto;
    }
    public void CalculaAumentoSalario(int aumento)
    {
        double valorAumento=salario*aumento/100;
        salario+=valorAumento;
    }
    public override string ToString()
    {
        string separador=new string('-',60);
        double salarioLiquido=CalculaSalarioLiquido();
        string mensagem=$"{separador}\nNome:                                            {nome}\nSalário líquido:                                 {salarioLiquido:c}\n{separador}";
        return mensagem;
    }
}