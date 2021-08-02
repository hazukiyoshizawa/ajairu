using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MoonQuizSceneManager : MonoBehaviour
{
    public void ChangeScene()
    {
        SceneManager.LoadScene("MoonTest");
    }
}
