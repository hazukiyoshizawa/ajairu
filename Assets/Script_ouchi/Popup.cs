using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Popup : MonoBehaviour
{
    static int count = 0;
    private void Start()
    {
        gameObject.SetActive(false);
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

    public void MoonMove0_0()
    {
        transform.localPosition = new Vector2(-161, -179-73*count);
        count+=1;
        Debug.Log(count);
    }

}
