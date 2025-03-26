using ATIVIDADE_AVALIATIVA2;

class Program
{
    private static void Main(string[] args)
    {
        Pilha pilha = new Pilha(100);
        string entrada;

        Console.WriteLine("Calculadora com Pilha - Digite números ou operadores (+, -, *, /). Pressione Enter para sair.");

        while (true)
        {
            Console.Write("Entrada: ");
            entrada = Console.ReadLine();

            if (string.IsNullOrEmpty(entrada))
                break;

            if (int.TryParse(entrada, out int numero))
            {
                pilha.empilhar(numero);
            }
            else if (entrada == "+" || entrada == "-" || entrada == "*" || entrada == "/")
            {
                int? b = pilha.desempilhar();
                int? a = pilha.desempilhar();

                if (a == null || b == null)
                {
                    Console.WriteLine("Erro: Operação inválida. Faltam números na pilha.");
                    continue;
                }

                int resultado = 0;
                if (entrada == "+")
                    resultado = a.Value + b.Value;
                else if (entrada == "-")
                    resultado = a.Value - b.Value;
                else if (entrada == "*")
                    resultado = a.Value * b.Value;
                else if (entrada == "/")
                {
                    if (b.Value == 0)
                    {
                        Console.WriteLine("Erro: Divisão por zero não permitida.");
                        pilha.empilhar(a.Value);
                        pilha.empilhar(b.Value);
                        continue;
                    }
                    resultado = a.Value / b.Value;
                }

                pilha.empilhar(resultado);
                Console.WriteLine("Resultado: " + resultado);
            }
            else
            {
                Console.WriteLine("Entrada inválida. Digite um número ou um operador matemático.");
            }
        }

    }
}
