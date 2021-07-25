using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class resetposition : MonoBehaviour
{

    public void Onclick()
    {
        Vector3 tmp = GameObject.Find("AircraftJet").transform.position;

        GameObject.Find("AircraftJet").transform.rotation = Quaternion.identity;

        Rigidbody rigidBody = GameObject.Find("AircraftJet").transform.GetComponent<Rigidbody>();
        rigidBody.velocity = Vector3.zero;
        rigidBody.angularVelocity = Vector3.zero;
        rigidBody.ResetInertiaTensor();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
