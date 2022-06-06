using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Raycast : MonoBehaviour
{
    RaycastHit hitInfo;//Raycast�̓����蔻����

    // Start is called before the first frame update
    void Start()
    {

    }

    void Update()
    {
        //����Raycast��Cube�̉�����rayDictance���L�тĂ�����
        if (Physics.Raycast(transform.position, -transform.up, out hitInfo, 5.0f))
        {
            Debug.DrawRay(transform.position, -transform.up * 5.0f, Color.red);//Raycast��\������

            Debug.Log("hit");//hit���ĕ\������B

            Debug.Log(hitInfo.collider.gameObject.tag);//ray�����������R���C�_�[�̃^�O��\��
        }
    }
}