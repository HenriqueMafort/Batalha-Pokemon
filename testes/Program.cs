using System;

string pokemon, jogador_a;
int vida_mewtwo = 250, ataque_mewtwo = 40;
//vida_jogador = 250, ataque_jogador = 50, cura_jogador = 50
char certeza = 'n', opcao, opcao_turno, restart = 's';

Pokemon dadospokemon = new Pokemon();
Pokemon objpokemon = new Pokemon();
dadospokemon = objpokemon;


Console.WriteLine("fala ai, bem vindo a batalha pokemon");
Console.WriteLine("-------------------------------------");

Console.WriteLine("Qual é seu nome? ");
jogador_a = Console.ReadLine();
Console.WriteLine("-------------------------------------");
Console.Clear();


while (restart == 's' || restart == 'S')
{


    while (certeza == 'n' || certeza == 'N')
    {
        Console.WriteLine(jogador_a + " escolha seu pokemon");
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
                objpokemon.pokemon = "Charizard";
                objpokemon.ataque_jogador = 45;
                objpokemon.vida_jogador = 190;
                objpokemon.cura_jogador = 50;


                Console.WriteLine(objpokemon.getdadospokemon() + objpokemon.getConfirmacaoPokemon());
                certeza = char.Parse(Console.ReadLine());

                break;
            case 'B':
            case 'b':
                objpokemon.pokemon = "Squirtle";
                objpokemon.vida_jogador = 170;
                objpokemon.cura_jogador = 70;
                objpokemon.ataque_jogador = 35;

                Console.WriteLine(objpokemon.getdadospokemon() + objpokemon.getConfirmacaoPokemon());
                certeza = char.Parse(Console.ReadLine());
                break;

            case 'C':
            case 'c':

                objpokemon.pokemon = "Pikachu";
                objpokemon.vida_jogador = 120;
                objpokemon.ataque_jogador = 90;
                objpokemon.cura_jogador = 50;

                Console.WriteLine(objpokemon.getdadospokemon() + objpokemon.getConfirmacaoPokemon());
                certeza = char.Parse(Console.ReadLine());
                break;
        }
    }


    Console.WriteLine("Boa, agora é hora de batalhar : ");
    Console.WriteLine("MeWtwo");
    Console.WriteLine("Vida " + vida_mewtwo);
    Console.WriteLine("Ataque " + ataque_mewtwo);

    Console.Clear();

    while (dadospokemon.vida_jogador > 0 && vida_mewtwo > 0)
    {

        Console.WriteLine("você possui " + dadospokemon.vida_jogador + " de vida");
        Console.WriteLine("oque você deseja fazer ? ");
        Console.WriteLine("A - Atacar");
        Console.WriteLine("B - Curar");
        opcao_turno = char.Parse(Console.ReadLine());

        switch (opcao_turno)
        {
            case 'a':
            case 'A':
                vida_mewtwo = vida_mewtwo - dadospokemon.ataque_jogador;
                Console.WriteLine("Agora atacou o MeWtwo e causou " + dadospokemon.ataque_jogador + " de dano");
                Console.WriteLine("MeWtwo está com " + vida_mewtwo + " de vida: ");
                break;

            case 'b':
            case 'B':
                dadospokemon.vida_jogador = dadospokemon.vida_jogador + dadospokemon.cura_jogador;
                Console.WriteLine("Seu pokemon se curou e está com " + dadospokemon.vida_jogador + " de vida");
                break;
        }

        Console.Clear();


        if (vida_mewtwo >= 0)
        {
            dadospokemon.vida_jogador = dadospokemon.vida_jogador - ataque_mewtwo;
            Console.WriteLine("Mewtwo te atacou e causou " + ataque_mewtwo + " de dano");


        }
        if (dadospokemon.vida_jogador <= 0)
        {
            Console.Clear();
            Console.WriteLine("acabou o jogo");
        }
        else if (dadospokemon.vida_jogador > vida_mewtwo)
        {
            Console.WriteLine("parabens você ganhou");
        }
    }

}