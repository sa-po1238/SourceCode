using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class GoalManager : MonoBehaviour
{
    private ScoreManager scoreManager;
    private GoalSpriteManager goalSpriteManager;
    private GameOverManager gameOverManager;

    private void Start()
    {
        scoreManager = this.gameObject.GetComponent<ScoreManager>();
        goalSpriteManager = this.gameObject.GetComponent<GoalSpriteManager>();
        gameOverManager = this.gameObject.GetComponent<GameOverManager>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        //インターフェースとして用意したクラスのインスタンス化
        if (collision.gameObject.TryGetComponent<IDangoInfo>(out var dangoInfo))
        {
            //毒ダンゴだったときに、ライフを減らすための変数をtrueに変更
            if (dangoInfo.Attribute == "Poison")
            {
                gameOverManager.hasPoison = true;
            }

            //ScoreManagerクラスのスコア計算メソッドにスコアを渡す
            scoreManager.PointCalculator(dangoInfo.Point);

            //SpriteManagerクラスのスプライト変換メソッドにスコアを渡す
            goalSpriteManager.SpriteChanger(dangoInfo.Sprite, dangoInfo.Color);
                        
            Destroy(collision.gameObject);
        }

    }

}
