using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NextDango : MonoBehaviour
{
    //このオブジェクトのImageコンポーネントを入れる変数
    private Image nextImage;

    //DangoLotteryクラスの取得
    [SerializeField] private GameObject dangoLotteryObj;
    private DangoLottery dangoLottery;

    //SecondDangoクラスの取得
    [SerializeField] private GameObject secondDangoObj;
    private SecondDango secondDango;

    //SecondDangoから得たダンゴオブジェクトを入れる変数
    [System.NonSerialized] public GameObject nextDango;
    private SpriteRenderer nextRenderer;

    // Start is called before the first frame update
    void Start()
    {
        //コンポーネントの取得
        nextImage = this.GetComponent<Image>();
        dangoLottery = dangoLotteryObj.GetComponent<DangoLottery>();

        secondDango = secondDangoObj.GetComponent<SecondDango>();

        //ゲーム開始時にUIに表示するダンゴを決める処理
        nextDango = dangoLottery.ChooseDango();
        nextRenderer = nextDango.GetComponent<SpriteRenderer>();
        nextImage.sprite = nextRenderer.sprite;
    }

    public void ChooseNextDango()
    {
        //ダンゴが生成されるたびにUIのダンゴを入れ替える処理
        nextDango = secondDango.secondDango;

        secondDango.ChooseSecondDango();

        nextRenderer = nextDango.GetComponent<SpriteRenderer>();
        nextImage.sprite = nextRenderer.sprite;
    }

}
