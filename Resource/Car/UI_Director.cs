using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// UnityEngine.UI 클래스를 추가하지 않으면 UI를 컨트롤 할 수 없다.
using UnityEngine.UI;

public class UI_Director : MonoBehaviour
{
    GameObject car;
    GameObject flag;
    GameObject distance;

    // Start is called before the first frame update
    void Start()
    {
        this.car = GameObject.Find("car");
        this.flag = GameObject.Find("flag");
        this.distance = GameObject.Find("Distance");
    }

    // Update is called once per frame
    void Update()
    {
        float length = this.flag.transform.position.x - this.car.transform.position.x;
        if(length >= 0)
        {
            this.distance.GetComponent<Text>().text = "목표 지점까지 " + length.ToString("F2") + "m";
            // 텍스트 컴포넌트를 찾을 수 없다고 한다 <- UnityEngine.UI를 추가하지 않아서 발생하는 문
        }
        else
        {
            this.distance.GetComponent<Text>().text = "Game Over";
        }


    }
}
