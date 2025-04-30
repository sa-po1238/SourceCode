using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IDangoInfo
{
    string Name { get; set; }
    Sprite Sprite { get; set; }
    string Color { get; set; }
    string Attribute { get; }


    int Point { get; set; }
}
