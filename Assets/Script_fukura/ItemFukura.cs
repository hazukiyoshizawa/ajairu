using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemFukura : MonoBehaviour
{
    private void Start()
    {
        // gameObject.SetActive(false);
    }

    public void Appear()
    {
        gameObject.SetActive(true);

    }
        public void Disappear()
    {
        gameObject.SetActive(false);
        // GetComponent<AudioSource>().Play();
    }
}
