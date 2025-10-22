using UnityEngine;

public class Mago : Unidade
{
    public void Ataque()
    {
        Debug.Log(this.gameObject.name + " lançou bola de fogo");
    }

}
