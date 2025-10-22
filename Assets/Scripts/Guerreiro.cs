using UnityEngine;

public class Guerreiro : Unidade
{

    void Start()
    {
        CalculaDano.Combate(unidadeInimiga, dano);
    }
    public override void Ataque()
    {
        base.Ataque();
        Debug.Log(this.gameObject.name + " atacou novamente com a espada");
    }
        
}

