using System.Collections;
using UnityEngine;

public class CombateAutomatizado : MonoBehaviour
{
    public static CombateAutomatizado instance;
    public Unidade unidade1;
    public Unidade unidade2;
    public bool start;
    public bool combateFinalizado;
    void Start()
    {
        instance = this;
    }

    void Update()
    {
        if (start)
        {
            start = false;
            StartCoroutine(Combate());
        }
    }

    IEnumerator Combate()
    {
        while (!combateFinalizado)
        {
            CalculaDano.Combate(unidade1, unidade2);
            Unidade temp = unidade1;
            unidade1 = unidade2;
            unidade2 = temp;
            yield return new WaitForSeconds(1f);
        }
    }
}
