using UnityEngine;

public static class CalculaDano
{
    public static void Combate(Unidade unidade, int dano)
    {
        // ex unidade.Ataque();
        unidade.vida = Mathf.Max(0, unidade.vida - dano);

    }





}
