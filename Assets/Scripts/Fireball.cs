using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fireball : MonoBehaviour
{
    [SerializeField] private float _speed = 10;
    public int demage = 1;

    private void Update()
    {
        transform.Translate(0, 0, _speed * Time.deltaTime);
    }
  
    private void OnCollisionEnter(Collision collision)
    {
        PlayerCharacter character = collision.gameObject.GetComponent<PlayerCharacter>();
        if (character != null)
        {
            character.Hurt(demage);
        }
        Destroy(gameObject);
    }

}
