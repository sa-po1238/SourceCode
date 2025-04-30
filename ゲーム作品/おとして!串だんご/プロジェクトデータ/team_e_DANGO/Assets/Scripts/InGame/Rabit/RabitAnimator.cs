using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RabitAnimator : MonoBehaviour
{
    //アニメーションに関する変数
    [System.NonSerialized] public SpriteRenderer rabitSprite;
    public Sprite idleSprite;
    public Sprite shotSprite;

    // Start is called before the first frame update
    void Start()
    {
        rabitSprite = GetComponent<SpriteRenderer>();
    }

    //ウサギの画像をもとに戻す関数
    public void SpriteResetter()
    {
        rabitSprite.sprite = idleSprite;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
