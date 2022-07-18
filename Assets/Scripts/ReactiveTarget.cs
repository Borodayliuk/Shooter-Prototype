using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReactiveTarget : MonoBehaviour
{
    // Start is called before the first frame update
    public void ReactToHit()
    {
        StartCoroutine(Die());
    }
    private IEnumerator Die()
    {
        GetComponent<WanderingAI>().SetAlive(false);
        this.transform.Rotate(-75, 0, 0);
        yield return new WaitForSeconds(2);
        Destroy(gameObject);
    }
}
