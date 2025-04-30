using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndGame : MonoBehaviour
{
    public GameObject RabbitIdleEn;
    public GameObject RabbitPushEn;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void EndGameScene()
    {
        RabbitIdleEn.SetActive(false);
        RabbitPushEn.SetActive(true);

        #if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;    // UnityEditorの実行を停止する処理
        #else
            Application.Quit(); // ゲームを終了する処理
        #endif
    }
}
