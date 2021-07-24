using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestAirplane : MonoBehaviour
{
    public float target_kmph_ = 100f;//時速100km
    private float vert;
    private float hori;

    void FixedUpdate(){
        hori = 2*Input.mousePosition.x/Screen.width-1.0f;
        vert = 2*Input.mousePosition.y/Screen.height-1.0f;
        var rb = GetComponent<Rigidbody>();
        rb.AddRelativeTorque(new Vector3(0,Input.GetAxis("Horizontal"),-hori));
        rb.AddRelativeTorque(new Vector3(-vert,0,0));
        //左
        var left = transform.TransformVector(Vector3.left);
        var horizontal_left = new Vector3(left.x,0f,left.z).normalized;
        rb.AddTorque(Vector3.Cross(left,horizontal_left)*4f);
        //前方
        var forward = transform.TransformVector(Vector3.forward);
        var horizontal_forward = new Vector3(forward.x,0f,forward.z).normalized;
        rb.AddTorque(Vector3.Cross(forward,horizontal_forward)*4f);
        //前進
        var force = (rb.mass*rb.drag*target_kmph_/3.6f)/
                    (1f - rb.drag*Time.fixedDeltaTime);
        rb.AddRelativeForce(new Vector3(0f,0f,Input.GetAxis("Vertical")*force));
    }
}
