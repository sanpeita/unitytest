using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move_player: MonoBehaviour
{

    public float MoveSpeed;
    
    private float JumpPower = 800;// ジャンプ力
    
    private Rigidbody rb;// Rigidbodyの機能を使うための変数
    private bool Grounded = false;// 地面についているかどうかを判定するための変数

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.position += transform.forward * MoveSpeed;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.position += transform.forward * -1 * MoveSpeed;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(0, 5, 0);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate(0, -5, 0);
        }
        
        if(Input.GetKeyDown(KeyCode.Space))// もし、スペースキーがおされたら、
        {
            if(Grounded == true)// もし地面に着いていたら、
            {
                rb.AddForce(Vector3.up * JumpPower);// Rigidbodyに上向きにジャンプ力をかける
            }
        }
        
    }
   
    private void OnCollisionEnter(Collision collision)// 物に触れた時の処理
    {
        if (collision.gameObject.tag == "Ground")// もし、触れた物のタグがGroundなら、
        {
            Grounded = true;// Groundedをtrueにする
        }
    }

    private void OnCollisionExit(Collision collision)// 物から離れた時の処理
    {
        if (collision.gameObject.tag == "Ground")// もし、離れた物のタグがGroundなら、
        {
            Grounded = false;// Groundedをfalseにする
        }
    }    
    
}
