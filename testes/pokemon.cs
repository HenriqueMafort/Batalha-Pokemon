using System;



public class Pokemon
{

    public string pokemon;
    public int vida_jogador;
    public int ataque_jogador;
    public int cura_jogador;
    
    public Pokemon()
    {

    }
    public Pokemon(string pokemon, int vida_jogador, int cura_jogador, int ataque_jogador)
    {
        this.ataque_jogador = ataque_jogador;
        this.pokemon = pokemon;
        this.vida_jogador = vida_jogador;
        this.cura_jogador = cura_jogador;
    }

    public string getdadospokemon()
    {
        return "nome: " + pokemon + "\r\n" + "Ataque: " + ataque_jogador + "\r\n" + "Cura: " + cura_jogador +  "\r\n";
    }

    public string getConfirmacaoPokemon()
    {
        return "Você tem certeza da sua opnião?" + "\r\n" + "Digite 'S' ou 'N'";
    }

 
}

