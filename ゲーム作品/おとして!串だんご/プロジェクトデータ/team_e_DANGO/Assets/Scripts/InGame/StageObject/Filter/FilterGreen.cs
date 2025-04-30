using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class FilterGreen : Filter
{
    //ダンゴの各クラスのSpriteプロパティに入れるための情報を入れる変数
    [SerializeField] private Sprite dangoSprite;
    [SerializeField] private Sprite dangoPoisonSprite;
    [SerializeField] private Sprite dangoRabitSprite;

    //ダンゴのインターフェースを入れる変数
    private IDangoInfo dangoInfo;
    //ダンゴの各クラスから取得したAttributeプロパティを入れる変数
    private string dangoAttribute;

    //触れてきたオブジェクトのSpriteRendererコンポーネントを入れる変数
    private SpriteRenderer collisionRenderer;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //触れてきたダンゴのスクリプトを取得
        dangoInfo = collision.gameObject.GetComponent<IDangoInfo>();
        //触れてきたダンゴのSpriteRendererを取得
        collisionRenderer = collision.gameObject.GetComponent<SpriteRenderer>();

        if (dangoInfo != null)
        {
            if (dangoInfo.Color != "Green")
            {
                //触れてきたダンゴのColorプロパティを緑に変更
                dangoInfo.Color = "Green";

                //触れてきたダンゴのAttributeプロパティを代入
                dangoAttribute = dangoInfo.Attribute;
                ChangeDangoColor();
            }
        }
    }

    protected override void ChangeDangoColor()
    {
        soundManager.seManager.PlayOneShot(soundManager.filter);

        //触れてきたダンゴの属性に応じて場合分け
        switch (dangoAttribute)
        {
            case "Normal":
                dangoInfo.Name = "dangoG";
                dangoInfo.Sprite = dangoSprite;
                collisionRenderer.sprite = dangoInfo.Sprite;
                break;

            case "Poison":
                dangoInfo.Name = "dangoG_poison";
                dangoInfo.Sprite = dangoPoisonSprite;
                collisionRenderer.sprite = dangoInfo.Sprite;
                break;

            case "Rabit":
                dangoInfo.Name = "dangoG_rabit";
                dangoInfo.Sprite = dangoRabitSprite;
                collisionRenderer.sprite = dangoInfo.Sprite;
                break;
        }
    }
}
