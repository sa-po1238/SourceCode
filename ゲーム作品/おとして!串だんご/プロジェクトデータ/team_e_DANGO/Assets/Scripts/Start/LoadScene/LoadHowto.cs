using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadHowto : MonoBehaviour
{
    public GameObject RabbitIdleGa;
    public GameObject RabbitPushGa;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ChangeScene()
    {
        RabbitIdleGa.SetActive(false);
        RabbitPushGa.SetActive(true);

        SceneManager.LoadScene("Howto");
    }
}
