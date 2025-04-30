using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class RaccoonAnimation : MonoBehaviour
{
    //タヌキオブジェクトの取得
    private SpriteRenderer raccoonSprite;

    //タヌキが持つダンゴのオブジェクトの取得
    [SerializeField] private GameObject dangoPositionObj;
    private SpriteRenderer positionSprite;
    //ダンゴ生成ポジションの初期状態を入れる変数
    private Transform positionInitialTransform;

    //タヌキ画像差分を入れる配列
    [SerializeField] private Sprite[] raccoonSprites;

    //親オブジェクトのDangoEliminatorクラスの取得
    DangoEliminator dangoEliminator;

    //食事中のパーティクルを入れる配列
    [SerializeField] private GameObject[] eatParticles;

    private void Start()
    {
        //タヌキオブジェクトのRendererの取得
        raccoonSprite = this.gameObject.GetComponent<SpriteRenderer>();

        //タヌキが持つダンゴオブジェクトのRenderer取得
        positionSprite = dangoPositionObj.GetComponent<SpriteRenderer>();

        positionInitialTransform = dangoPositionObj.transform;

        //親オブジェクトのDangoEliminatorクラスの取得
        dangoEliminator = transform.parent.gameObject.GetComponent<DangoEliminator>();
    }

    public void EatAnimation(Sprite dangoSprite, string dangoColor)
    {
        //タヌキの手元にぶつかってきたダンゴの画像を代入
        positionSprite.sprite = dangoSprite;
        //タヌキの画像を食事中に変更
        raccoonSprite.sprite = raccoonSprites[1];

        //タヌキの移動を一時停止
        StartCoroutine(dangoEliminator.PauseTween(1.0f));

        GameObject instantiaterParticle = null;
        
        //ダンゴの色に応じたパーティクルの生成
        switch (dangoColor)
        {
            case "Green":
                instantiaterParticle = Instantiate(eatParticles[0], dangoPositionObj.transform);
                break;

            case "Red":
                instantiaterParticle = Instantiate(eatParticles[1], dangoPositionObj.transform);
                break;

            case "White":
                instantiaterParticle = Instantiate(eatParticles[2], dangoPositionObj.transform);
                break;
        }

        //パーティクルを１秒後に破壊
        Destroy(instantiaterParticle, 1.0f);

        //ダンゴをだんだん小さくする処理
        dangoPositionObj.transform.DOScale(new Vector2(0.0f, 0.0f), 1.0f);

        Invoke("dangoSpriteReset", 1.0f);
    }

    private void dangoSpriteReset()
    {
        //手に持っているダンゴを消す
        positionSprite.sprite = null;
        //手に持つダンゴのオブジェクトのサイズを元に戻す
        dangoPositionObj.transform
            .DOScale(new Vector2(0.4268948f, 0.4268948f), 0.0f);

        raccoonSprite.sprite = raccoonSprites[0];
    }

    public void poisonEatAnimation()
    {
        raccoonSprite.sprite = raccoonSprites[2];
    }

    public void raccoonSpriteReset()
    {
        raccoonSprite.sprite = raccoonSprites[0];
    }
}
