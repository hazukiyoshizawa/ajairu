using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonFukura : MonoBehaviour
{
    // Start is called before the first frame update
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
