using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DangoG : MonoBehaviour, IDangoInfo
{
    private SpriteRenderer spriteRenderer;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        Sprite = spriteRenderer.sprite;
    }

    public string Name { get; set; } = "DangoG";
    public Sprite Sprite { get; set; } = null;
    public string Color { get; set; } = "Green";
    public string Attribute { get; } = "Normal";

    public int Point { get; set; } = 100;
}
