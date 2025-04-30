using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RabitController : MonoBehaviour
{
    //このオブジェクトを入れる変数と移動速度の変数
    public GameObject rabit;
    public float moveSpeed;
 
    private void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.RightArrow) && transform.position.x < 5.0f)
        {
            rabit.transform.position += Vector3.right * moveSpeed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.LeftArrow) && transform.position.x > -4.0f)
        {
            rabit.transform.position += Vector3.left * moveSpeed * Time.deltaTime;
        }
    }
}
