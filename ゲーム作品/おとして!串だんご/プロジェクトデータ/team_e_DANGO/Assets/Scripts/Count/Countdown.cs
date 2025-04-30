using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Countdown : MonoBehaviour
{
    public TextMeshProUGUI counttext;
    public SeController seController;
    public Image start;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(CountdownCoroutine());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator CountdownCoroutine()
    {
        // 0.5秒待ってからカウントダウン開始
        yield return new WaitForSeconds(0.5f);
        
        // 3秒カウントダウン
        
        counttext.text = "3";   // 3を表示
        seController.PlayCountdown();
        yield return new WaitForSeconds(1.0f);  // 1秒待つ

		counttext.text = "2";
        seController.PlayCountdown();
		yield return new WaitForSeconds(1.0f);
     
		counttext.text = "1";
        seController.PlayCountdown();
		yield return new WaitForSeconds(1.0f);
		
        counttext.text = "";
        seController.PlayStart();
        Debug.Log("カウントダウン終了");

        // カウントダウンが終わったらスタートを表示
        start.gameObject.SetActive(true);

        // 1秒待ってからシーン遷移
        yield return new WaitForSeconds(1.0f);
        SceneManager.LoadScene("InGame");

    }
}
