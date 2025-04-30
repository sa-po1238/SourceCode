using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DangoWPoison : MonoBehaviour, IDangoInfo
{
    private SpriteRenderer spriteRenderer;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        Sprite = spriteRenderer.sprite;
    }

    public string Name { get; set; } = "DangoW_poison";
    public Sprite Sprite { get; set; } = null;
    public string Color { get; set; } = "White";
    public string Attribute { get; } = "Poison";

    public int Point { get; set; } = 0;
}
