using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

//Filter３種の親クラス
public class Filter : MonoBehaviour
{
    //親オブジェクトのTransformを入れる変数
    private Transform parentTransform;

    public SoundManager soundManager;

    // Start is called before the first frame update
    void Start()
    {
        //親オブジェクトのTransformを取得
        parentTransform = transform.parent.GetComponent<Transform>();
        //親オブジェクトと線対象の位置を代入
        //オブジェクトのスタート位置が右端と左端のどちらでも同じ動きをさせるため
        float moveDistination = -parentTransform.position.x;
        //移動速度をランダムに決定
        float moveSpeed = Random.Range(2.0f, 4.0f);

        //親オブジェクトの移動を制御
        parentTransform.DOLocalMoveX(moveDistination, moveSpeed)
           .SetEase(Ease.InOutQuad)
           .SetLoops(-1, LoopType.Yoyo);

        soundManager = SoundManager.Instance;
    }

    //Filter３種に入れる抽象メソッド
    //ダンゴの色を変えるためのメソッド
    protected virtual void ChangeDangoColor()
    {
        //バグ防止用の実行されない処理
        Debug.Log("オーバーライドが実行されていません");
    }

}
