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

}
