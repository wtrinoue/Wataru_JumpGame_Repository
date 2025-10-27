using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehavior : MonoBehaviour
{
    public float moveSpeed = 5f;     // 水平方向の移動速度
    public float jumpForce = 7f;     // ジャンプ力
    private Rigidbody2D rb;          // 2D物理演算用リジッドボディ
    private bool isGrounded = false; // 地面についているかの判定
    float rayLength = 0.1f;
    RaycastHit2D hit;


    void Start()
    {
        // Rigidbody2Dを取得
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
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
        foreach (ContactPoint2D contact in collision.contacts){
            if (collision.gameObject != null && (contact.point.y < transform.position.y - rayLength))
        {
            Debug.Log("Grounded");
            isGrounded = true;
        }
        }
    }
}

/*
オブジェクトの種類に応じて使えるVectorが異なる
*/
