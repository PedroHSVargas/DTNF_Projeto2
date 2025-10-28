using UnityEngine;

public class BolaDeFogo : MonoBehaviour, ISkill
{
    public double poderBase;
    public int custoMana;
    public void Play(Unidade user, Unidade target)
    {
        if (user.stats.mana - custoMana < 0)
        {
            Debug.Log("Skill falhou, mana insuficiente");
        }
        else
        {
            user.stats.mana -= custoMana;
            target.stats.vida -= (int)poderBase * (user.stats.ataqueMagico);
        }
    }
}
