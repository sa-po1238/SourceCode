using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ThirdDango : MonoBehaviour
{
    //このオブジェクトのImageコンポーネントを入れる変数
    private Image thirdImage;

    //DangoLotteryクラスを入れる変数
    [SerializeField] private GameObject dangoLotteryObj;
    private DangoLottery dangoLottery;

    //抽選結果のダンゴオブジェクトを入れる変数
    [System.NonSerialized] public GameObject thirdDango;
    private SpriteRenderer thirdRenderer;
    
    // Start is called before the first frame update
    void Start()
    {
        //コンポーネントの取得
        thirdImage = this.GetComponent<Image>();
        dangoLottery = dangoLotteryObj.GetComponent<DangoLottery>();

        //ゲーム開始時にUIに表示するダンゴを決める処理
        thirdDango = dangoLottery.ChooseDango();
        thirdRenderer = thirdDango.GetComponent<SpriteRenderer>();
        thirdImage.sprite = thirdRenderer.sprite;
    }

    public void ChooseThirdDango()
    {
        //ダンゴが生成されるたびにUIのダンゴを入れ替える処理
        thirdDango = dangoLottery.ChooseDango();
        thirdRenderer = thirdDango.GetComponent<SpriteRenderer>();
        thirdImage.sprite = thirdRenderer.sprite;
    }

}
