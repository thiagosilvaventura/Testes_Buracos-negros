using System;

class Program
{
    // Método para calcular o raio do horizonte de eventos em quilômetros
    static double CalcularRaioHorizonteEventos(double massa)
    {
        // Constantes físicas
        double G = 6.67430e-11;  // Constante gravitacional em m^3 kg^-1 s^-2
        double c = 3.0e8;        // Velocidade da luz em m/s
        double massaSolar = 1.989e30;  // Massa solar em kg

        // Calculando o raio de Schwarzschild em metros
        double rs = 2 * G * massa * massaSolar / (c * c);

        // Convertendo para quilômetros
        double rs_km = rs / 1000;

        return rs_km;
    }

    // Método principal para interação com o usuário
    static void Main()
    {
        // Solicitar ao usuário a massa estelar em massas solares
        Console.Write("Digite a massa estelar (em massas solares): ");
        double massa;
        while (!double.TryParse(Console.ReadLine(), out massa) || massa <= 0)
        {
            Console.WriteLine("Por favor, digite um valor válido maior que zero.");
            Console.Write("Digite a massa estelar (em massas solares): ");
        }

        // Calcular o raio do horizonte de eventos
        double rs_km = CalcularRaioHorizonteEventos(massa);

        // Exibir o resultado
        Console.WriteLine($"Para uma massa estelar de {massa} massas solares, o raio do horizonte de eventos de um buraco negro seria de aproximadamente {rs_km:F2} quilômetros.");
    }
}
