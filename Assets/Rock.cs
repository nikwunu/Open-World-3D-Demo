using System.Collections;
using DefaultNamespace;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Rock : MonoBehaviour, IInteractable
{
    public string InteractMessage => objectInteractMessage;

    public string objectInteractMessage;

    public GameObject speechObject;

    public GameObject winObject;

    public Transform teleportLocation;

    private bool progress;
    public void Interact()
    {
        if (progress)
        {
            StartCoroutine(ExampleCoroutine(winObject));
            StartCoroutine(RestartSceneCoroutine());
            return;
        }
        StartCoroutine(ExampleCoroutine(speechObject));
        progress = true;
        transform.position = teleportLocation.position;
    }


    private IEnumerator ExampleCoroutine(GameObject gameObject)
    {
        gameObject.SetActive(true);
        yield return new WaitForSeconds(5);
        gameObject.SetActive(false);

    }

    private IEnumerator RestartSceneCoroutine()
    {
        yield return new WaitForSeconds(5);
        SceneManager.LoadScene(0);
    }
}
