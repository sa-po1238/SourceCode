using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class SoundManager : MonoBehaviour
{
    // シーンをまたいで使用するオブジェクト(他スクリプトで使用するためpublicで宣言)
    // →このスクリプトをアタッチしたオブジェクトの子オブジェクトにすることで，シーンをまたいでも破棄されない
    //public AudioSource bgmManager;
    public AudioSource seManager;
    // bgm音源
    //public AudioClip bgm;
    //public AudioClip bgm_ingame;
    // se音源
    public AudioClip decide;
    public AudioClip countdown;
    public AudioClip start;
    public AudioClip dustBox;
    public AudioClip eat;
    public AudioClip filter;
    public AudioClip gameOver;
    public AudioClip generateHigh;
    public AudioClip generateLow;
    public AudioClip generateMiddle;
    public AudioClip raccoon;

    private static SoundManager instance;

    private void Awake()
    {
        if (instance != null) {
            Destroy(gameObject);
            return;
        }

        instance = this;
        DontDestroyOnLoad(gameObject);
    }

    public static SoundManager Instance
    {
        get { return instance; }
    }
}
