using UnityEngine;

public class Jogador : MonoBehaviour
{
    public int vida;
    public int dano;

    public Inimigo inimigo;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        CalculaDano.Combate(ref inimigo._vida, ref dano);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
