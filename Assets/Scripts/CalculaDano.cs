using UnityEngine;

public static class CalculaDano
{
    public static void Combate(Unidade unidade, int dano)
    {
        if(unidade.GetType()== typeof(Guerreiro))
        {
            Guerreiro guerreiro;
            guerreiro = (Guerreiro)unidade;
            guerreiro.Ataque();
        }else if(unidade.GetType()==typeof(Mago)){
            Mago mago;
            mago = (Mago)unidade;
            mago.Ataque();
        }           
        






        unidade.vida = Mathf.Max(0, unidade.vida - dano);
    }





}
