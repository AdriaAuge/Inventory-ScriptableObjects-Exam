using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inventory : MonoBehaviour
{
    public static Inventory Instance;

    [Header("SWORDS")]
    public Swords[] swords;
    public Text[] swordNameText;
    public Text[] swordDamageText;
    public Image[] swordSprite;

    [Header("GUNS")]
    public Guns[] guns;
    public Text[] gunNameText;
    public Text[] gunDamageText;
    public Image[] gunSprite;

    private void Awake()
    {
        if(Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(this);
        }
    }

    public void AddSwords(Swords item)
    {
        for(int i = 0; i < swords.Length; i++)
        {
            if(swords[i] == null)
            {
                swords[i] = item;
                swordNameText[i].text = item.swordName;
                swordDamageText[i].text = item.swordDamage;
                swordSprite[i].sprite = item.swordSprite;

                return;
            }
        }
    }

    public void AddGuns(Guns item)
    {
        for(int i = 0; i < swords.Length; i++)
        {
            if(guns[i] == null)
            {
                guns[i] = item;
                gunNameText[i].text = item.gunName;
                gunDamageText[i].text = item.gunDamage;
                gunSprite[i].sprite = item.gunSprite;

                return;
            }
        }
    }


}
