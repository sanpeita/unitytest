using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove: MonoBehaviour

    //第一回a01====+====+====+====+====+====+====+====+====+====+====+ここから
    //基本的な移動をするために必要な変数。publicなので、unityエディタで数値を変えることができる。
    public float moveSpeed = 0.1f;
    public float rotateSpeed = 5f;
    //第一回a01====+====+====+====+====+====+====+====+====+====+====+ここまで
    
    private float jumpPower = 800;// ジャンプ力
    
    private Rigidbody rb;// Rigidbodyの機能を使うための変数
    private bool Grounded = false;// 地面についているかどうかを判定するための変数

    void Start()
    {
        rb = GetComponent<Rigidbody>();// rbにRigidbodyの値を代入する
    }

    void Update()
    {
        //第一回a01====+====+====+====+====+====+====+====+====+====+====+ここから
        //WASDキーで、基本的な移動をするための具体的なスクリプト。
        //Wキー押下時
        if (Input.GetKey(KeyCode.W))
        {
            transform.position += transform.forward * MoveSpeed;
        }
        //Sキー押下時
        if (Input.GetKey(KeyCode.S))
        {
            transform.position += transform.forward * -1 * MoveSpeed;
        }
        //Dキー押下時
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(0, rotateSpeed, 0);
        }
        //Aキー押下時
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(0, -1 * rotateSpeed, 0);
        }
        //第一回a01====+====+====+====+====+====+====+====+====+====+====+ここまで
        
        //第一回a02====+====+====+====+====+====+====+====+====+====+====+ここまで
        //AnimatorControllerで、
        //①MakeTransitionの矢印の中で、HasExitTimeのチェックが外れていること。(モーションを最後まで待たないということ)
        //②パラメータが設定されていること。bool型のパラメータisRunningなど。
        //WキーまたはSキー押下時　「||」は「または」の意味
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.S))
        {
            //isRunningをtrueにする(走る的行動をする)
            anim.SetBool("isRunning", true);
        }
        //そうでなければ
        else    
        {
            //isRunningをfalseにする(走る的行動をしない)
            anim.SetBool("isRunning", false);
        }
        //第一回a02====+====+====+====+====+====+====+====+====+====+====+ここまで
        
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
