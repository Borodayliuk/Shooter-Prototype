using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GManager : MonoBehaviour
{
    [SerializeField] private PlayerCharacter _character;
    [SerializeField] private GameObject _textLouse;

    private void Start()
    {
        _textLouse.active = false;
        _character.deathEvent.AddListener(Death);
    }

    private void Death()
    {
        _textLouse.active = true;
        StartCoroutine(Restart());
    }
    IEnumerator Restart()
    {
        yield return new WaitForSeconds(5f);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 0);
    }

}
