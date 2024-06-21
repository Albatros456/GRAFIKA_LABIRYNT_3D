using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jumpscare : MonoBehaviour
{
    public GameObject Image;
    public AudioSource audioSource;


    void Start()
    {
        Image.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        {
            Image.SetActive(true);
            audioSource.Play();
            StartCoroutine(DisableImg());
        }
    }

    IEnumerator DisableImg()
    {
        yield return new WaitForSeconds(2);
        Image.SetActive(false);
    }
}