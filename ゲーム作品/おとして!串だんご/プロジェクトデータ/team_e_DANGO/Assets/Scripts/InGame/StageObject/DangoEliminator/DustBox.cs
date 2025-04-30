using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DustBox : MonoBehaviour
{
    private SoundManager soundManager;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        soundManager = SoundManager.Instance;
        soundManager.seManager.PlayOneShot(soundManager.dustBox);

        //ぶつかってきたオブジェクトを破壊
        Destroy(collision.gameObject);
    }
}
