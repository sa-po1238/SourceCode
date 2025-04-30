using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    private float score;
    [System.NonSerialized] public static float totalScore;

    [SerializeField] private TMP_Text scoreText;

    private GoalSpriteManager goalSpriteManager;
    private GameOverManager gameOverManager;

    // Start is called before the first frame update
    void Start()
    {
        goalSpriteManager = GetComponent<GoalSpriteManager>();
        gameOverManager = GetComponent<GameOverManager>();

        scoreText.text = "Score: " + totalScore.ToString();
    }

    //É_ÉìÉSÇ…äiî[Ç≥ÇÍÇƒÇ¢ÇÈÉXÉRÉAèÓïÒÇéÊìæÇµÇƒâ¡éZÇ∑ÇÈèàóù
    public void PointCalculator(int Point)
    {
        score += Point;
    }

    public IEnumerator ScoreCalculator()
    {
        if (gameOverManager.hasPoison == true)
        {
            totalScore += score * 0;
        }
        else if (goalSpriteManager.rightColor == goalSpriteManager.centerColor &&
            goalSpriteManager.centerColor == goalSpriteManager.leftColor)
        {
            totalScore += score * 1.5f;
        }
        else if (goalSpriteManager.rightColor != goalSpriteManager.centerColor &&
            goalSpriteManager.centerColor != goalSpriteManager.leftColor &&
            goalSpriteManager.leftColor != goalSpriteManager.rightColor)
        {
            totalScore += score * 2.0f;
        }
        else
        {
            totalScore += score;            
        }

        yield return new WaitForSeconds(0.8f);

        scoreText.text = "Score: " + totalScore.ToString();

        score = 0;

        gameOverManager.hasPoison = false;
    }

}
