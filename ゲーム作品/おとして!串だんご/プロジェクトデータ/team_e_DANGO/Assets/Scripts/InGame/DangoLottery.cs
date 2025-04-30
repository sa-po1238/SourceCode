using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DangoLottery : MonoBehaviour
{
    private Dictionary<GameObject, float> probability;
    public GameObject[] dangos;

    private void Awake()
    {
        InitializeDictionary();
    }

    public GameObject ChooseDango()
    {
        // 確率の合計値を格納
        float total = 0;

        // 敵ドロップ用の辞書からドロップ率を合計する
        foreach (KeyValuePair<GameObject, float> elem in probability)
        {
            total += elem.Value;
        }

        // Random.valueでは0から1までのfloat値を返すので
        // そこにドロップ率の合計を掛ける
        float randomPoint = Random.value * total;

        // randomPointの位置に該当するキーを返す
        foreach (KeyValuePair<GameObject, float> elem in probability)
        {
            if (randomPoint < elem.Value)
            {
                return elem.Key;
            }
            else
            {
                randomPoint -= elem.Value;
            }
        }
        return null;
    }

    //通常状態の発生確率を辞書に定義
    public void InitializeDictionary()
    {
        probability = new Dictionary<GameObject, float>();
        probability.Add(dangos[0], 23.33f);
        probability.Add(dangos[1], 1.66f);
        probability.Add(dangos[2], 8.33f);

        probability.Add(dangos[3], 23.33f);
        probability.Add(dangos[4], 1.66f);
        probability.Add(dangos[5], 8.33f);

        probability.Add(dangos[6], 23.33f);
        probability.Add(dangos[7], 1.66f);
        probability.Add(dangos[8], 8.33f);
    }

    //フィーバー状態の発生確率を辞書に定義
    public void FeverDictionary()
    {
        probability = new Dictionary<GameObject, float>();
        probability.Add(dangos[0], 0.0f);
        probability.Add(dangos[1], 0.0f);
        probability.Add(dangos[2], 33.3f);

        probability.Add(dangos[3], 0.0f);
        probability.Add(dangos[4], 0.0f);
        probability.Add(dangos[5], 33.3f);
            
        probability.Add(dangos[6], 0.0f);
        probability.Add(dangos[7], 0.0f);
        probability.Add(dangos[8], 33.3f);
    }
}