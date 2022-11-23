using System;



public class Pokemon
{
    public string pokemon;
    public int vida_jogador;
    public int ataque_jogador;
    public int cura_jogador;


    public string getdadospokemon()
    {
        return "nome " + pokemon + "\r\n" + "Ataque " + ataque_jogador + "\r\n" + "Cura " + cura_jogador +  "\r\n";
    }

    public string getConfirmacaoPokemon()
    {
        return "Você tem certeza da sua opnião?" + "\r\n" + "Digite 'S' ou 'N'";
    }
}

