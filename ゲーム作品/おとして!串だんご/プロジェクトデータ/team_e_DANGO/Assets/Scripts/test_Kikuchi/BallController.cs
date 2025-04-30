using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    public GameObject[] dango;
    public float fallSpeed = 5.0f;
    public float[] interval;
    private float[] timer;

    // Start is called before the first frame update
    void Start()
    {
        timer = new float[dango.Length];
    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < dango.Length; i++)
        {
            timer[i] += Time.deltaTime;

            if (timer[i] >= interval[i])
            {
                Vector3 position = new Vector3(Random.Range(-5f, 5f), 5f, 0f);
                // prefab回避用29&31
                GameObject ball = Instantiate(dango[i], position, Quaternion.identity);

                Rigidbody2D ballRigidbody = ball.GetComponent<Rigidbody2D>();
                ballRigidbody.velocity = new Vector2(0f, -fallSpeed);

                interval[i] += 6.0f;
            }
        }

    }
}