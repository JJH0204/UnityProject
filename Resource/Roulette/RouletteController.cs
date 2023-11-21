using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RouletteController : MonoBehaviour
{
    GameObject Roulette;
    float rotSpeed = 0.0f;

    public float Deceleration = 0.0f;

    // Start is called before the first frame update
    void Start()
    {
        Roulette = this.gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        // 마우스 클릭이 감지되면 룰렛을 회전시켜라
        if (Input.GetMouseButtonDown(0))
        {
            this.rotSpeed = 10.0f;
        }

        Roulette.transform.Rotate(0, 0, this.rotSpeed);

        this.rotSpeed *= Deceleration;
    }
}
