using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RunDog : MonoBehaviour
{
    //犬オブジェクトの開始時座標
    Vector3 startPosition;
    //犬オブジェクトの移動先座標
    Vector3 targetPosition;
    //てこのオブジェクト
    GameObject lever;
    //シーン開始時に取得しているオブジェクトへの参照用変数
    public SceneStart sceneStart;
    //画面遷移済みフラグ
    bool isFaded;
    //
    AudioSource audioSource;
    
    private void Start()
    {   
        //犬の開始時座標
        startPosition = GameObject.Find("Dog").transform.position;
        //犬の移動先座標
        targetPosition = GameObject.Find("DogGoal").transform.position;
        //てこのオブジェクトを取得
        lever = GameObject.Find("Lever");
        //画面遷移済みフラグをfalseに設定
        isFaded = false;
        //シーン開始時に取得したオブジェクト一覧を取得
        sceneStart = GameObject.Find("Canvas").GetComponent<SceneStart>();
        //このオブジェクトに設定されているAudioを取得
        audioSource = GetComponent<AudioSource>();
    }

    void Update()
    {
        //てこのz方向角度が水平なら犬を移動させる(オイラー角取得時に誤差があるため、-1~1の間の角度を水平とする)
        if(-1 <= lever.transform.localEulerAngles.z && lever.transform.localEulerAngles.z <= 1){
            if (!audioSource.isPlaying && !isFaded)
            {
                audioSource.Play();
            }
            transform.position = 
            Vector3.MoveTowards(transform.position, targetPosition, Time.deltaTime * 40);
        } else{
            if (audioSource.isPlaying)
            {
                audioSource.Stop();
            }
            //水平でない場合
            if(transform.position != targetPosition){
                //左側に渡りきっていなければ戻す
                transform.position = startPosition;
                // audioSource.Stop();
            }
        }

        //まだ画面遷移していない
        if(!isFaded){
            //犬がゴール地点に到達した
            if(transform.position == targetPosition){
                isFaded = true;
                if (audioSource.isPlaying)
                {
                    audioSource.Stop();
                }
                Debug.Log(sceneStart);
                sceneStart.mainParts.SetActive(false);
                sceneStart.clearParts.SetActive(true);
            }
        }
    }
}
