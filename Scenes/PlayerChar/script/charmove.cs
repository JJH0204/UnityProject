using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class charmove : MonoBehaviour
{
    public float speed = 0.0f;
    public Vector2 vec = new Vector2(0.0f, 0.0f);

    private void Start()
    {
        if (speed < 0.0f)
        {
            Debug.Log("Error : 속도(speed) 값은 0 이상 실수 값으로 입력해 주십시.");
            speed *= -1.0f;
        }
            
    }

    void Update()
    {
        InputHorizontal();
    }

    // 수평 이동 키 감지 (수평 이동 : 키보드 'a'좌측 이동 'd'우측이동 )
    public void InputHorizontal()
    {
        if (Input.GetKey(KeyCode.A))
        {
            Debug.Log("INPUT : a(left)");
            vec = new Vector2((speed * -1.0f), 0);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            Debug.Log("INPUT : d(right)");
            vec = new Vector2((speed * +1.0f), 0);
        }
        else
        {
            // Debug.Log("IsStop");
            vec *= new Vector2(0.0f, 0.0f);
        }
        transform.Translate(vec);
    }

    // 수직 이동 ( w : 위, s : 아래 ) - 조건 : 사다리가 있을 경우

    // 점프
    public void InputSpacebar()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //뛰었다
        }
    }
}
