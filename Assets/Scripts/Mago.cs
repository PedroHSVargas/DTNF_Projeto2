using UnityEngine;

public class Mago : Unidade
{
    public override void Ataque()
    {
        Debug.Log(this.gameObject.name + " lançou bola de fogo");
    }

}
