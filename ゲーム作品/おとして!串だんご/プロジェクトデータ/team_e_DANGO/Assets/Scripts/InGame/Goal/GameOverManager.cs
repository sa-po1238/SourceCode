using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using Unity.VisualScripting;

public class GameOverManager : MonoBehaviour
{
    [System.NonSerialized] public bool hasPoison = false;

    [SerializeField] private Image firstLife;
    [SerializeField] private Image secondLife;
    [SerializeField] private Image thirdLife;

    [SerializeField] private Sprite emptyHeart;

    [SerializeField] private GameObject gameOverCanvas;
    [SerializeField] private GameObject rabit;

    private SoundManager soundManager;

    private GameObject bgmControllerObj;
    private BgmController bgmController;

    public static bool isGameOver;

    public void PoisonChecker()
    {
        if(firstLife.sprite != emptyHeart)
        {
            firstLife.sprite = emptyHeart;
        }
        else if(secondLife.sprite != emptyHeart) 
        {
            secondLife.sprite = emptyHeart;
        }
        else if (thirdLife.sprite != emptyHeart)
        {
            thirdLife.sprite = emptyHeart;
            GameOver();
        }
    }

    private void GameOver()
    {
        bgmControllerObj = GameObject.Find("BgmManager");
        bgmController = bgmControllerObj.GetComponent<BgmController>();
        bgmController.bgmManager.Stop();

        soundManager = SoundManager.Instance;
        soundManager.seManager.PlayOneShot(soundManager.gameOver);

        //GameOverCanvasのアクティブ化
        gameOverCanvas.SetActive(true);

        //ウサギの動きの無効化
        RabitController rabitController = rabit.GetComponent<RabitController>();
        rabitController.enabled = false;
        DangoGenerator dangoGenerator = rabit.GetComponent<DangoGenerator>();
        dangoGenerator.enabled = false;

        isGameOver = true;
        FeverTimerController.isFever = false;

    }

    private void Update()
    {
        if (gameOverCanvas.activeSelf == true)
        {
            if (Input.GetMouseButtonDown(0))
            {
                isGameOver = false;
                SceneManager.LoadScene("Result");
            }
        }        
    }
}
