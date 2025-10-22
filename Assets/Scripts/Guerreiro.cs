using UnityEngine;

public class Guerreiro : Unidade
{

    void Start()
    {
        CalculaDano.Combate(unidadeInimiga, dano);
    }

    // Update is called once per frame
    public void Ataque()
    {
        Debug.Log(this.gameObject.name + " atacou com a espada");
    }
        
}

