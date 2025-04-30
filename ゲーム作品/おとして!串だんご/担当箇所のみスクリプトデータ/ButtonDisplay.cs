using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonDisplay : MonoBehaviour
{
    public GameObject buttonRetry;
    public GameObject buttonEnd;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public IEnumerator ShowButtons()
    {
        // デバックログ
        Debug.Log("ShowButtons");
        // 1秒待つ
        yield return new WaitForSeconds(1.0f);

        buttonRetry.SetActive(true);
        buttonEnd.SetActive(true);
    }
}
