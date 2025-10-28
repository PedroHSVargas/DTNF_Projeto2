using UnityEngine;

public class Guerreiro : Unidade
{

    public override void Ataque()
    {
        base.Ataque();
        Debug.Log(this.gameObject.name + " atacou novamente com a espada");
    }
        
}

