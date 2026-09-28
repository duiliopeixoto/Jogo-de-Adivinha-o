Random sorteador = new Random();

int numeroSecreto = sorteador.Next(1, 101);

int palpite;
bool palpiteCorreto = false;
int contadorPalpites = 0;

while (palpiteCorreto == false)
{
    Console.WriteLine("Digite o seu palpite.");

    bool palpiteValido = int.TryParse(Console.ReadLine(), out palpite);

    if (!palpiteValido)
    {
        Console.WriteLine("O palpite deve ser em formato númerico.");
    }
    else
    {
        if (palpite <= 0)
        {
            Console.WriteLine("O número deve ser entre 1 e 100");
            continue;
        }
        else
        {
            contadorPalpites++;
            Console.WriteLine($"{contadorPalpites}ª tentativa.");
            if (palpite < numeroSecreto)
            {
                Console.WriteLine($"O seu palpite {palpite} é menor que o número secreto.\nTente novamente!");                
                continue;
            }
            else if (palpite > numeroSecreto)
            {
                Console.WriteLine($"O seu palpite {palpite} é maior que o número secreto.\nTente novamente!");                
                continue;
            }
            else
            {                
                palpiteCorreto = true;
                break;
            }            
        }        
    }    
}

Console.WriteLine("Parabéns, você acertou!\n");
