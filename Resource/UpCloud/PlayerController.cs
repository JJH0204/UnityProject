using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    Rigidbody2D rigid2D;
    Animator animator;
    float jumpForce = 680.0f;
    float walkForce = 30.0f;
    float maxWalkSpeed = 2.0f;

    // 기울기 값 받는 변수
    float threshold = 0.2f;

    // Start is called before the first frame update
    void Start()
    {
        this.rigid2D = GetComponent<Rigidbody2D>();
        this.animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        //is_mobile();

        // player up
        if (Input.GetKeyDown(KeyCode.Space) && this.rigid2D.velocity.y == 0)
        {
            //애니메이션
            this.animator.SetTrigger("JumpTrigger");
            this.rigid2D.AddForce(transform.up * this.jumpForce);
        }

        // move
        int key = 0;
        if (Input.GetKey(KeyCode.RightArrow)) key = 1;
        if (Input.GetKey(KeyCode.LeftArrow)) key = -1;

        float speedx = Mathf.Abs(this.rigid2D.velocity.x);

        if (speedx < this.maxWalkSpeed)
        {
            this.rigid2D.AddForce(transform.right * key * this.walkForce);
        }

        if (key != 0)
        {
            transform.localScale = new Vector3(key, 1, 1);
        }

        // Animation speed
        if (this.rigid2D.velocity.y == 0)
        {
            this.animator.speed = speedx / 2.0f;
        }
        else
        {
            this.animator.speed = 1.0f;
        }
        
        // Game over
        if (transform.position.y < -10)
        {
            SceneManager.LoadScene("UpCloud");
        }
    }
    // goal
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Goal~!");
        SceneManager.LoadScene("UpCloud_Clear");
    }

    //void is_mobile()
    //{
    //    if (Input.GetMouseButtonDown(0) && this.rigid2D.velocity.y == 0)
    //    {
    //        this.rigid2D.AddForce(transform.up * this.jumpForce);
    //    }

    //    int key = 0;
    //    if (Input.acceleration.x > this.threshold) key = 1;
    //    if (Input.acceleration.x < -this.threshold) key = -1;

    //    float speedx = Mathf.Abs(this.rigid2D.velocity.x);
    //}
}
