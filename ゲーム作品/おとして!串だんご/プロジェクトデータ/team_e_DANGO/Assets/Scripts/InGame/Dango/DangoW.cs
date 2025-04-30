using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DangoW : MonoBehaviour, IDangoInfo
{
    private SpriteRenderer spriteRenderer;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        Sprite = spriteRenderer.sprite;
    }

    public string Name { get; set; } = "DangoW";
    public Sprite Sprite { get; set; } = null;
    public string Color { get; set; } = "White";
    public string Attribute { get; } = "Normal";

    public int Point { get; set; } = 100;
}
