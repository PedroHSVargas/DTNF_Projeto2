using UnityEngine;

public class Unidade : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public Stats stats = new Stats();
    public Unidade unidadeInimiga;

    public virtual void Ataque()
    {
        Debug.Log(this.gameObject.name + " atacou com a espada");
    }
          
    
}
