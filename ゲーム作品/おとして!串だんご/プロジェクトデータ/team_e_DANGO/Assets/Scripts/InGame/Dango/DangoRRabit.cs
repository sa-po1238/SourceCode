using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DangoRRabit : MonoBehaviour, IDangoInfo
{
    private SpriteRenderer spriteRenderer;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        Sprite = spriteRenderer.sprite;
    }

    public string Name { get; set; } = "DangoR_rabit";
    public Sprite Sprite { get; set; } = null;
    public string Color { get; set; } = "Red";
    public string Attribute { get; } = "Rabit";

    public int Point { get; set; } = 500;
}
