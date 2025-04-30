using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class FeverTimerController : MonoBehaviour
{
    [SerializeField] private GameObject feverTimeCanvas;
    [SerializeField] private TMP_Text feverTimerText;

    public static bool isFever;
    private float feverTimer = 30.0f;

    // Update is called once per frame
    void Update()
    {
        if (isFever)
        {
            feverTimeCanvas.SetActive(true);
            feverTimer -= Time.deltaTime;
            feverTimerText.text = "Fever: " + feverTimer.ToString("f1");
        }

        if (feverTimer <= 0)
        {
            feverTimeCanvas.SetActive(false);
            feverTimer = 30.0f;
            isFever = false;
        }
    }
}
