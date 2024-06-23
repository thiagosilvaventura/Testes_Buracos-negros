
# Função para calcular o raio do horizonte de eventos em quilômetros
def calcular_raio_horizonte_eventos(massa):
    # Constantes físicas
    G = 6.67430e-11  # Constante gravitacional em m^3 kg^-1 s^-2
    c = 3.0e8        # Velocidade da luz em m/s
    massa_solar = 1.989e30  # Massa solar em kg

    # Calculando o raio de Schwarzschild em metros
    rs = 2 * G * massa * massa_solar / (c ** 2)

    # Convertendo para quilômetros
    rs_km = rs / 1000

    return rs_km

# Função principal para interação com o usuário
def main():
    # Solicitar ao usuário a massa estelar em massas solares
    massa = float(input("Digite a massa estelar (em massas solares): "))

    # Calcular o raio do horizonte de eventos
    rs_km = calcular_raio_horizonte_eventos(massa)

    # Exibir o resultado
    print(f"Para uma massa estelar de {massa} massas solares, o raio do horizonte de eventos de um buraco negro seria de aproximadamente {rs_km:.2f} quilômetros.")

# Executar a função principal
if __name__ == "__main__":
    main()

