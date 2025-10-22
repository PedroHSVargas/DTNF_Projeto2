using UnityEngine;

public class Unidade : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public int _vida;

    public int vida
    {
        get { return _vida; }
        set
        {
            Debug.Log(this.name + " tomou " + (_vida - value) + " de dano e ficou com " + _vida);
            _vida = value;
            if (_vida > 0)
                CalculaDano.Combate(unidadeInimiga, dano);
            else
                Debug.Log(this.gameObject + " morreu.");
        }
    }
    public int dano;
    public Unidade unidadeInimiga;
}
