using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SecondDango : MonoBehaviour
{
    //このオブジェクトのImageコンポーネントを入れる変数
    private Image secondImage;

    //DangoLotteryクラスの取得
    [SerializeField] private GameObject dangoLotteryObj;
    private DangoLottery dangoLottery;

    //ThirdDangoクラスの取得
    [SerializeField] private GameObject thirdDangoObj;
    private ThirdDango thirdDango;

    //ThirdDangoから得たダンゴオブジェクトを入れる変数
    [System.NonSerialized] public GameObject secondDango;
    private SpriteRenderer secondRenderer;

    // Start is called before the first frame update
    void Start()
    {
        //コンポーネントの取得
        secondImage = this.GetComponent<Image>();
        dangoLottery = dangoLotteryObj.GetComponent<DangoLottery>();

        thirdDango = thirdDangoObj.GetComponent<ThirdDango>();

        //ゲーム開始時にUIに表示するダンゴを決める処理
        secondDango = dangoLottery.ChooseDango();
        secondRenderer = secondDango.GetComponent<SpriteRenderer>();
        secondImage.sprite = secondRenderer.sprite;
    }

    public void ChooseSecondDango()
    {
        //ダンゴが生成されるたびにUIのダンゴを入れ替える処理
        secondDango = thirdDango.thirdDango;

        thirdDango.ChooseThirdDango();

        secondRenderer = secondDango.GetComponent<SpriteRenderer>();
        secondImage.sprite = secondRenderer.sprite;
    }

}
