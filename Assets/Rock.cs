using System.Collections;
using DefaultNamespace;
using TMPro;
using UnityEngine;

public class Rock : MonoBehaviour, IInteractable
{
    public string InteractMessage => objectInteractMessage;

    public string objectInteractMessage;

    public GameObject speechObject;

    public GameObject winObject;

    public Transform TeleportLocation;

    private bool progress;
    public void Interact()
    {
        if (progress)
        {
            winObject.SetActive(true);
            return;
        }
        Debug.Log(1);
        progress = true;
        StartCoroutine(ExampleCoroutine());
    }


    IEnumerator ExampleCoroutine()
    {
        transform.position = TeleportLocation.position;
        speechObject.SetActive(true);
        yield return new WaitForSeconds(5);
        speechObject.SetActive(false);
    }
}
