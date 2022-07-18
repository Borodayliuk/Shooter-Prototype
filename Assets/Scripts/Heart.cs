using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Heart : MonoBehaviour
{
    [SerializeField] private Sprite _full;
    [SerializeField] private Sprite _empty;
    public Status status;
    public enum Status
    {
        full = 1,
        empty = 0,
    }
    public void Full()
    {
        GetComponent<Image>().sprite = _full;
        status = Status.full;
    }
    public void Empty()
    {
        GetComponent <Image>().sprite = _empty;
        status = Status.empty;
        print("-");
    }
}
