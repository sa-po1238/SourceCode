using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DangoR : MonoBehaviour, IDangoInfo
{
    private SpriteRenderer spriteRenderer;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        Sprite = spriteRenderer.sprite;
    }

    public string Name { get; set; } = "DangoR";
    public Sprite Sprite { get; set; } = null;
    public string Color { get; set; } = "Red";
    public string Attribute { get; } = "Normal";

    public int Point { get; set; } = 100;
}
