using UnityEngine;

public class Guerreiro : Unidade
{

    void Start()
    {
        CalculaDano.Combate(unidadeInimiga, dano);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
