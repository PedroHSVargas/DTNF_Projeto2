using UnityEngine;

public static class CalculaDano
{
    public static void Combate(Unidade unidade, int dano)
    {
        unidade.vida = Mathf.Max(0, unidade.vida - dano);
    }


    public static void Combate(ref int vida, int dano)
    {
        vida = Mathf.Max(0, vida - dano);
    }

    // Player atacks enemy
    public static void Combate(Jogador jogador, Inimigo inimigo)
    {
        inimigo.vida = Mathf.Max(0, inimigo.vida - jogador.dano);
    }

    // Enemy atacks player
    public static void Combate(Inimigo inimigo, Jogador jogador)
    {
        jogador.vida = Mathf.Max(0, jogador.vida - inimigo.dano);
    }
}
