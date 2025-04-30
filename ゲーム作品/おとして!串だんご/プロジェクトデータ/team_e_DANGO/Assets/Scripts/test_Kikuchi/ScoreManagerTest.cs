using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using DG.Tweening;

public class ScoreManagerTest : MonoBehaviour
{
    public Image[] images;
    public Image1Replace a;
    public Image2Replace b;
    public Image3Replace c;
    private bool[] flags;

    public TMP_Text ScoreText;
    public TMP_Text TotalScoreText;
    private float score = 0;
    private float totalScore = 0;

    // Start is called before the first frame update
    void Start()
    {
        foreach (var image in images)
        {
            image.color = new Color(image.color.r, image.color.g, image.color.b, 0f);
        }

        a = GetComponentInChildren<Image1Replace>();
        b = GetComponentInChildren<Image2Replace>();
        c = GetComponentInChildren<Image3Replace>();

        flags = new bool[3] { true, true, true };
    }

    // Update is called once per frame
    void Update()
    {
        // 団子完成後初期化
        if (!flags[2])
        {
            // totalScore更新
            totalScore += score;
            TotalScoreText.text = string.Format("Score:{0}", totalScore);

            // 団子初期化
            foreach (var image in images)
            {
                image.DOFade(0.0f, 0.80f);
            }

            for (int i = 0; i < 3; i++)
            {
                flags[i] = true;
            }

            // score初期化
            score = 0;
        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        // 最初の衝突時の処理
        if (flags[0])
        {
            // image1に団子表示
            if (other.gameObject.name == "dangoG(Clone)")
            {
                ShowDangoImage(0, 0);
            }
            else if (other.gameObject.name == "dangoR(Clone)")
            {
                ShowDangoImage(0, 1);
            }
            else if (other.gameObject.name == "dangoW(Clone)")
            {
                ShowDangoImage(0, 2);
            }
            else if (other.gameObject.name == "dangoG_rabit(Clone)")
            {
                ShowDangoImage(0, 3);
            }
            else if (other.gameObject.name == "dangoR_rabit(Clone)")
            {
                ShowDangoImage(0, 4);
            }
            else if (other.gameObject.name == "dangoW_rabit(Clone)")
            {
                ShowDangoImage(0, 5);
            }

            flags[0] = false;
            ScoreText.text = string.Format("+{0}", score);
        }
        // 2回目の衝突時の処理
        else if (flags[1])
        {
            // image2に団子表示
            if (other.gameObject.name == "dangoG(Clone)")
            {
                ShowDangoImage(1, 0);
            }
            else if (other.gameObject.name == "dangoR(Clone)")
            {
                ShowDangoImage(1, 1);
            }
            else if (other.gameObject.name == "dangoW(Clone)")
            {
                ShowDangoImage(1, 2);
            }
            else if (other.gameObject.name == "dangoG_rabit(Clone)")
            {
                ShowDangoImage(1, 3);
            }
            else if (other.gameObject.name == "dangoR_rabit(Clone)")
            {
                ShowDangoImage(1, 4);
            }
            else if (other.gameObject.name == "dangoW_rabit(Clone)")
            {
                ShowDangoImage(1, 5);
            }

            flags[1] = false;
            ScoreText.text = string.Format("+{0}", score);
        }
        // 3回目の衝突時の処理
        else if (flags[2])
        {
            // image3に団子表示
            if (other.gameObject.name == "dangoG(Clone)")
            {
                ShowDangoImage(2, 0);
            }
            else if (other.gameObject.name == "dangoR(Clone)")
            {
                ShowDangoImage(2, 1);
            }
            else if (other.gameObject.name == "dangoW(Clone)")
            {
                ShowDangoImage(2, 2);
            }
            else if (other.gameObject.name == "dangoG_rabit(Clone)")
            {
                ShowDangoImage(2, 3);
            }
            else if (other.gameObject.name == "dangoR_rabit(Clone)")
            {
                ShowDangoImage(2, 4);
            }
            else if (other.gameObject.name == "dangoW_rabit(Clone)")
            {
                ShowDangoImage(2, 5);
            }

            flags[2] = false;
            ScoreText.text = string.Format("+{0}", score);
        }

        Destroy(other.gameObject);
        Debug.Log("Goal!!");
    }

    private void ShowDangoImage(int index, int imageIndex)
    {
        images[index].color = Color.white;

        switch (index)
        {
            case 0:
                a.SetImage(imageIndex);
                break;
            case 1:
                b.SetImage(imageIndex);
                break;
            case 2:
                c.SetImage(imageIndex);
                break;
        }

        switch (imageIndex)
        {
            case 0:
            case 1:
            case 2:
                score += 10;
                break;
            case 3:
            case 4:
            case 5:
                score += 50;
                break;
        }

        // 三色団子の場合はスコアを2倍にする
        if (CheckTriColorDango())
        {
            score *= 2;
        }
        // 単色団子の場合はスコアを1.5倍にする
        else if (CheckMonoColorDango())
        {
            score *= 1.5f;
        }
    }

    private bool CheckTriColorDango()
    {
        // 三色団子の場合はtrueを返す
        return (a.GetCurrentImage() != b.GetCurrentImage() && a.GetCurrentImage() != c.GetCurrentImage() && b.GetCurrentImage() != c.GetCurrentImage());
    }

    private bool CheckMonoColorDango()
    {
        // 単色団子の場合はtrueを返す
        return (a.GetCurrentImage() == b.GetCurrentImage() && a.GetCurrentImage() == c.GetCurrentImage());
    }

}