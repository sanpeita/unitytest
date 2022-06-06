using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Raycast : MonoBehaviour
{
    RaycastHit hitInfo;//Raycastの当たり判定情報

    // Start is called before the first frame update
    void Start()
    {

    }

    void Update()
    {
        //もしRaycastがCubeの下からrayDictance分伸びていたら
        if (Physics.Raycast(transform.position, -transform.up, out hitInfo, 5.0f))
        {
            Debug.DrawRay(transform.position, -transform.up * 5.0f, Color.red);//Raycastを表示する

            Debug.Log("hit");//hitって表示する。

            Debug.Log(hitInfo.collider.gameObject.tag);//rayが当たったコライダーのタグを表示
        }
    }
}