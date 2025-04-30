using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BgmControl : MonoBehaviour
{
    private AudioSource bgmManager;
    private AudioSource seManager;

    public Slider volumeSlider_BGM;
    public Slider volumeSlider_SE;

    // Start is called before the first frame update
    void Start()
    {
        bgmManager = GameObject.Find("BgmManager").GetComponent<AudioSource>();
        seManager = GameObject.Find("SeManager").GetComponent<AudioSource>();

        // スライダーの初期値を設定
        volumeSlider_BGM.value = bgmManager.volume;
        volumeSlider_SE.value = seManager.volume;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Slider_BGMChanged()
    {
        // スライダーの値に基づいて音量を変更
        bgmManager.volume = volumeSlider_BGM.value;
        
        Debug.Log("BGMの音量を" + bgmManager.volume + "に変更しました。");
    }

    public void Slider_SEChanged()
    {
        seManager.volume = volumeSlider_SE.value;

        Debug.Log("SEの音量を" + seManager.volume + "に変更しました。");
    }
}
