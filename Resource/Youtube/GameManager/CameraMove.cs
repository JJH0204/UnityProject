using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CameraMove : MonoBehaviour
{
    private Vector2 v_MousePos;
    private Vector2 v_Target;
    private GameObject Player;
    public float f_CameraSpeed = 5.0f;

    void Start()
    {
        Init_Camera();
    }

    void Update()
    {
        Update2MouseNCamera();
        UpdateCamera();
    }

    private void Init_Camera()
    {
        v_MousePos = new Vector2(0.0f, 0.0f);
        v_Target = new Vector2(0.0f, 0.0f);
        Player = GameObject.Find("Player");
    }

    private void UpdateCamera()
    {
        float f_Speed = f_CameraSpeed * Time.deltaTime;
        Vector2 v_Dir = new Vector2((v_Target.x - this.transform.position.x),(v_Target.y - this.transform.position.y));
        Vector2 v_Move = new Vector2(v_Dir.x * f_Speed, v_Dir.y * f_Speed);
        this.transform.Translate(v_Move);
    }
    // [마우스 커서 표시 가이].(https://codefinder.janndk.com/22).
    // [화면 제한].(https://velog.io/@cedongne/Unity-2D-카메라-범위-제한하기).
    private void Update2MouseNCamera()
    {
        v_MousePos = Input.mousePosition;

        Debug.Log(v_MousePos);
        if (v_MousePos != null)
        {
            float f_CenterX = (Player.transform.position.x + v_MousePos.x) / 2.0f;
            float f_CenterY = (Player.transform.position.y + v_MousePos.y) / 2.0f;
            v_Target = new Vector2(f_CenterX, f_CenterY);
        }
        else
            v_Target = Player.transform.position;
    }
}
