using System;

string pokemon, jogador_a;
int vida_mewtwo = 250, ataque_mewtwo = 40;
char certeza = 'n', opcao, opcao_turno, restart = 's';

Pokemon dadospokemon = new Pokemon();
Pokemon objpokemon = new Pokemon();
Pokemon objescolhaPokemon = new Pokemon();
dadospokemon = objpokemon;


Console.WriteLine("fala ai, bem vindo a batalha pokemon");
Console.WriteLine("-------------------------------------");

Console.WriteLine("Qual é seu nome? ");
jogador_a = Console.ReadLine();
Console.WriteLine("-------------------------------------");
Console.Clear();


while (restart == 's' || restart == 'S')
{




    Console.WriteLine(jogador_a + " escolha seu pokemon");
    do
    {
        Console.WriteLine("A - Charizard");
        Console.WriteLine("B - Squirtle");
        Console.WriteLine("C - Pikachu");
        opcao = char.Parse(Console.ReadLine());
        Console.WriteLine("Digite corretamente os valores: ");
        Console.Clear();

            switch (opcao)
            {
                case 'A':
                case 'a':
                    objpokemon = new Pokemon("Charizard", 190, 45, 50);
                    Console.WriteLine(objpokemon.getdadospokemon());
                    certeza = char.Parse(Console.ReadLine());
                    Console.Clear();
                    if (certeza != 's' || certeza != 'S')
                    {
                        Console.WriteLine("A opção " + certeza + " não é valida, Digite uma opção valida: ");
                    }
                    break;
                    break;
                case 'B':
                case 'b':

                    objpokemon = new Pokemon("Squirtle", 170, 70, 35);
                    Console.WriteLine(objpokemon.getdadospokemon());
                    certeza = char.Parse(Console.ReadLine());
                    Console.Clear();
                    if (certeza != 's' || certeza != 'S')
                    {
                        Console.WriteLine("A opção " + certeza + " não é valida, Digite uma opção valida: ");
                    }
                    break;
                    break;

                case 'C':
                case 'c':
                    objpokemon = new Pokemon("Pikachu", 120, 90, 50);
                    Console.WriteLine(objpokemon.getdadospokemon());
                    certeza = char.Parse(Console.ReadLine());
                    Console.Clear();
                    if (certeza != 's' || certeza != 'S')
                    {
                        Console.WriteLine("A opção " + certeza + " não é valida, Digite uma opção valida: ");
                    }
                    break;
            }
        } while (certeza != 's' || certeza == 'S');

        Console.WriteLine("Boa, agora é hora de batalhar : ");
        Console.WriteLine("MeWtwo");
        Console.WriteLine("Vida " + vida_mewtwo);
        Console.WriteLine("Ataque " + ataque_mewtwo);
        Console.Clear();

        while (objpokemon.vida_jogador > 0 && vida_mewtwo > 0)
        {

            Console.WriteLine("você possui " + objpokemon.vida_jogador + " de vida");
            Console.WriteLine("oque você deseja fazer ? ");
            Console.WriteLine("A - Atacar");
            Console.WriteLine("B - Curar");
            opcao_turno = char.Parse(Console.ReadLine());

            switch (opcao_turno)
            {
                case 'a':
                case 'A':
                    vida_mewtwo = vida_mewtwo - objpokemon.ataque_jogador;
                    Console.WriteLine("Agora atacou o MeWtwo e causou " + objpokemon.ataque_jogador + " de dano");
                    Console.WriteLine("MeWtwo está com " + vida_mewtwo + " de vida: ");
                    break;

                case 'b':
                case 'B':
                    objpokemon.vida_jogador = objpokemon.vida_jogador + objpokemon.cura_jogador;
                    Console.WriteLine("Seu pokemon se curou e está com " + objpokemon.vida_jogador + " de vida");
                    break;
            }

            Console.Clear();

            if (vida_mewtwo >= 0)
            {
                objpokemon.vida_jogador = objpokemon.vida_jogador - ataque_mewtwo;
                Console.WriteLine("Mewtwo te atacou e causou " + ataque_mewtwo + " de dano");
                Console.WriteLine("A vida do Mewtwo é de " + vida_mewtwo);
            }

            if (objpokemon.vida_jogador <= 0)
            {
                Console.Clear();
                Console.WriteLine("Você perdeu: " + "\n\r" + "acabou o jogo");
            }
            else if (objpokemon.vida_jogador > 0 && vida_mewtwo <= 0)
            {
                Console.WriteLine("parabens você ganhou");
            }
        }
        Console.WriteLine("Deseja jogar novamente ? ");
        restart = char.Parse(Console.ReadLine());
    }
