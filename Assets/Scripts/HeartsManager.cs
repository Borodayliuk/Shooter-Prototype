using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeartsManager : MonoBehaviour
{
    public List<Heart> hearts = new List<Heart>();
    public void Pluss(int count)
    {
        foreach (Heart heart in hearts)
        {
            if (heart.status == Heart.Status.empty)
            {
                heart.Full();
                break;
            }
        }
    }
    public void Minus(int count)
    {
        for (int i = 0; i < hearts.Count; i++)
        {
            if (i < hearts.Count - 1)
            {
                if (hearts[i + 1].status == Heart.Status.empty)
                {
                    hearts[i].Empty();
                    break;
                }
            }
            else
            {
                hearts[i].Empty();
                break;
            }
        }
    }

    
}
