using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehavior : MonoBehaviour
{
    public float moveSpeed = 5f;     // 水平方向の移動速度
    public float jumpForce = 7f;     // ジャンプ力
    private Rigidbody2D rb;          // 2D物理演算用リジッドボディ
    private bool isGrounded; // 地面についているかの判定
    float rayLength = 0.1f;
    RaycastHit2D hit;
    public GameObject panel;


    void Start()
    {
        // Rigidbody2Dを取得
        rb = GetComponent<Rigidbody2D>();
        isGrounded = false;
    }

    void Update()
    {
        Debug.Log(isGrounded);
        // --- 左右移動 ---
        float move = 0f;

        if (Input.GetKey(KeyCode.A))
        {
            move = -1f;
        }
        if (Input.GetKey(KeyCode.D))
        {
            move = 1f; // 右
        }

        // Rigidbody2D の速度を直接変更（Time.deltaTimeは不要）
        rb.velocity = new Vector2(move * moveSpeed, rb.velocity.y);


        // --- ジャンプ ---
        if (Input.GetKeyDown(KeyCode.W) && isGrounded)
        {
            rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
            isGrounded = false; // 空中判定
        }
    }

    // --- 地面に接触したとき ---
    void OnCollisionEnter2D(Collision2D collision)
    {

        Debug.Log(collision.gameObject.CompareTag("Ground"));
        Debug.Log(collision.gameObject.name);

        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
            Debug.Log("Ground判定");
        }

        // if (collision.gameObject.name == "Step (3)")
        // {
        //     bool isActive = collision.gameObject.activeSelf;
        //     panel.SetActive(!isActive);
        // }
    }
}

/*
オブジェクトの種類に応じて使えるVectorが異なる
*/
