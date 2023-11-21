using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameDirector : MonoBehaviour
{
    GameObject HpGage;
    // Start is called before the first frame update
    void Start()
    {
        this.HpGage = GameObject.Find("HpGage");
    }

    public void DecreaseHp()
    {
        this.HpGage.GetComponent<Image>().fillAmount -= 0.1f;
    }
}
