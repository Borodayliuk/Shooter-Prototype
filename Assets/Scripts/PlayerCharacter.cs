using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerCharacter : MonoBehaviour
{
    public UnityEvent deathEvent;
    [SerializeField] private HeartsManager _heartsManager;
    private int _health;
    
    void Start()
    {
        _health = 5;
    }
    public void Hurt(int denage)
    {
        if (_health > 0)
        {
            _health -= denage;
            _heartsManager.Minus(denage);
        }
        else
        {
            deathEvent.Invoke();
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
