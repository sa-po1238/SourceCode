using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IntervalSetter : MonoBehaviour
{
    private float timer;
    private float totalTimer;

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        totalTimer += Time.deltaTime;

        //intarval‚ð2•b‚©‚ç1•b‚Ü‚Å’Z‚­‚·‚éˆ—
        if (timer > 10.0f && DangoGenerator.dangoInterval >= 1.0f)
        {
            DangoGenerator.dangoInterval -= 0.1f;
            timer = 0;
        }
        
        //interval‚ð1•b‚©‚ç0.5•b‚Ü‚Å’Z‚­‚·‚éˆ—
        if (totalTimer > 180.0f && timer > 10.0f && DangoGenerator.dangoInterval >= 0.5f)
        {
            DangoGenerator.dangoInterval -= 0.1f;
            timer = 0;
        }
    }
}
