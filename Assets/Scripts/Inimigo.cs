using UnityEngine;

public class Inimigo : MonoBehaviour
{

    public int _vida;

    public int vida
    {
        get { return _vida; }
        set
        {
            Debug.Log(this.name + " tomou " + (_vida - value) + " de dano e ficou com " + _vida);
            _vida = value;
            if (_vida > 0)
                CalculaDano.Combate(ref jogador.vida, ref dano);
            else
                Debug.Log(this.gameObject + " morreu.");
        }
    }
    public int dano;
    public Jogador jogador;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
   
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
