using UnityEngine;

public class Jogador : Unidade
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
