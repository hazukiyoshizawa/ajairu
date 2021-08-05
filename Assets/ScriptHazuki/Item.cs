using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Item : MonoBehaviour
{
    // クリックされたら、非表示になってアイテムBoxに追加される
    // タイミング：クリックされたら
    // 処理：
    // ・非表示
    // ・アイテムBoxへ追加

    static int i = 0;
    static int k = 0;


    // タイミング：クリックされたら
    public void OnThis()
    {
        // ・非表示
        gameObject.SetActive(false);
        // TODO:アイテムBoxへ追加
    }

    public void OntriggerEnterIntroduction()
    {
        Debug.Log("Introduction");
        // SceneManager.LoadScene("ClearScene");
        FadeManager.Instance.LoadScene ("Introduction", 1f);
        //フェードアウト：http://kuromikangames.com/article/475434825.html
    }

        public void OntriggerEnterTutorial()
    {
        Debug.Log("Tutorial");
        // SceneManager.LoadScene("ClearScene");
        FadeManager.Instance.LoadScene ("Tutorial", 1f);
        //フェードアウト：http://kuromikangames.com/article/475434825.html
    }

        public void OntriggerEnterSearch1()
    {
        if(k==0){
        Debug.Log("Search1");
        
        FadeManager.Instance.LoadScene ("Search1", 1f); 
        }else{
            Debug.Log("Search2");
          // SceneManager.LoadScene("ClearScene");
          FadeManager.Instance.LoadScene ("Search2", 1f);
          //フェードアウト：http://kuromikangames.com/article/475434825.html
        }
        
    }

        public void OntriggerEnterSearch2()
    {
        Debug.Log("Search2");
        // SceneManager.LoadScene("ClearScene");
        FadeManager.Instance.LoadScene ("Search2", 1f);
        //フェードアウト：http://kuromikangames.com/article/475434825.html
    }

        public void OntriggerEnterSearch3()
    {
        Debug.Log("Search3");
        // SceneManager.LoadScene("ClearScene");
        FadeManager.Instance.LoadScene ("Search3", 1f);
        //フェードアウト：http://kuromikangames.com/article/475434825.html
    }

        public void OntriggerEnterMoonIntro()
    {
        k = 1;
        Debug.Log("MoonIntro");
        // SceneManager.LoadScene("ClearScene");
        FadeManager.Instance.LoadScene ("MoonIntro", 1f);
        //フェードアウト：http://kuromikangames.com/article/475434825.html
    }

        public void OntriggerEnterTecoHint()
    {
        i = 1;
        Debug.Log("TecoHint");
        // SceneManager.LoadScene("ClearScene");
        FadeManager.Instance.LoadScene ("TecoHint", 1f);
        //フェードアウト：http://kuromikangames.com/article/475434825.html
    }

        public void OntriggerEnterTecoHint2()
    {
        i = 1;
        Debug.Log("TecoHint2");
        // SceneManager.LoadScene("ClearScene");
        FadeManager.Instance.LoadScene ("TecoHint2", 1f);
        //フェードアウト：http://kuromikangames.com/article/475434825.html
    }

        public void OntriggerEnterTecoHint3()
    {
        i = 1;
        Debug.Log("TecoHint3");
        // SceneManager.LoadScene("ClearScene");
        FadeManager.Instance.LoadScene ("TecoHint3", 1f);
        //フェードアウト：http://kuromikangames.com/article/475434825.html
    }

        public void OntriggerEnterTecoStart()
    {
        if(i==1){
        Debug.Log("TecoStart");
        // SceneManager.LoadScene("ClearScene");
        FadeManager.Instance.LoadScene ("TecoStart", 1f);
        }else{
          Debug.Log("NotTeco");
        // SceneManager.LoadScene("ClearScene");
        FadeManager.Instance.LoadScene ("NotTeco", 1f);
        //フェードアウト：http://kuromikangames.com/article/475434825.html  
        }
        
    }

        public void OntriggerEnterNotTeco()
    {
        Debug.Log("NotTeco");
        // SceneManager.LoadScene("ClearScene");
        FadeManager.Instance.LoadScene ("NotTeco", 1f);
        //フェードアウト：http://kuromikangames.com/article/475434825.html
    }

        public void OntriggerEnterEnding()
    {
        Debug.Log("Ending");
        // SceneManager.LoadScene("ClearScene");
        FadeManager.Instance.LoadScene ("Ending", 1f);
        //フェードアウト：http://kuromikangames.com/article/475434825.html
    }

        public void OntriggerEnterStart()
    {
        Debug.Log("Start");
        // SceneManager.LoadScene("ClearScene");
        FadeManager.Instance.LoadScene ("Start", 1f);
        //フェードアウト：http://kuromikangames.com/article/475434825.html
    }

        public void OntriggerEnterPractice01Lever()
    {
        Debug.Log("Practice01Lever");
        // SceneManager.LoadScene("ClearScene");
        FadeManager.Instance.LoadScene ("Practice01Lever", 1f);
        //フェードアウト：http://kuromikangames.com/article/475434825.html
    }

        public void OntriggerEnterPractice02Lever()
    {
        Debug.Log("Practice02Lever");
        // SceneManager.LoadScene("ClearScene");
        FadeManager.Instance.LoadScene ("Practice02Lever", 1f);
        //フェードアウト：http://kuromikangames.com/article/475434825.html
    }

        public void OntriggerEnterMoonQuiz()
    {
        Debug.Log("MoonQuiz");
        // SceneManager.LoadScene("ClearScene");
        FadeManager.Instance.LoadScene ("MoonQuiz", 1f);
        //フェードアウト：http://kuromikangames.com/article/475434825.html
    }

        public void OntriggerEnterTecoQuiz2()
    {
        Debug.Log("TecoQuiz2");
        // SceneManager.LoadScene("ClearScene");
        FadeManager.Instance.LoadScene ("TecoQuiz2", 1f);
        //フェードアウト：http://kuromikangames.com/article/475434825.html
    }


        public void OntriggerEnterMoonExperience()
    {
        Debug.Log("MoonExperience");
        // SceneManager.LoadScene("ClearScene");
        FadeManager.Instance.LoadScene ("MoonExperience", 1f);
        //フェードアウト：http://kuromikangames.com/article/475434825.html
    }

    public void OntriggerEnterLeverTest()
    {
        Debug.Log("LeverTest");
        // SceneManager.LoadScene("ClearScene");
        FadeManager.Instance.LoadScene("LeverTest", 1f);
        //フェードアウト：http://kuromikangames.com/article/475434825.html
    }

    public void OntriggerEnterTecoEnding()
    {
        Debug.Log("TecoEnding");
        // SceneManager.LoadScene("ClearScene");
        FadeManager.Instance.LoadScene("TecoEnding", 1f);
        //フェードアウト：http://kuromikangames.com/article/475434825.html
    }

}
