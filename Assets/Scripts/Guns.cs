using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Items/Guns", fileName = "New Gun")]
public class Guns : ScriptableObject
{
    public string gunName;
    public Sprite gunSprite;
    public string gunDamage;
}
