using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoRotate : MonoBehaviour
{
    
    public float Rot_x;
    public float Rot_y;
    public float Rot_z;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Rot_x,Rot_y,Rot_z);
    }
}
