using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using DG.Tweening;

public class ScoreDisplay : MonoBehaviour
{
    
    public GameObject scoreText;
    public float scaleDuration = 0.5f;
    public ButtonDisplay buttonDisplay; // ボタン表示用のスクリプト

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ShowScore (float Score)
    {
        Debug.Log("ShowScore");
        TextMeshProUGUI scoreText = this.scoreText.GetComponent<TextMeshProUGUI>();
        scoreText.text = "スコア: " + Score.ToString();

        StartCoroutine(buttonDisplay.ShowButtons());
    }
}
