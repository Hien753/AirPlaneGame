using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIAirplane : MonoBehaviour
{
    [SerializeField]
    private GameObject player;
    [SerializeField]
    private float speed = 10f;
    
    void Update()
    {
        transform.LookAt(player.transform);
        transform.position += transform.forward * (speed * Time.deltaTime);
    }
}
