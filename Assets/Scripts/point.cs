using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using System;

public class point : MonoBehaviour
{
    [SerializeField] GameObject Ring;
    [SerializeField] [Range(0f, 1f)] float capacity;

    // Start is called before the first frame update
    void Start()
    {
        int[] array1 = Enumerable.Range(0, transform.childCount).ToArray();

        int[] array2 = array1.OrderBy(i => Guid.NewGuid()).ToArray();

        int count = Mathf.FloorToInt(transform.childCount * capacity);

        for (int n = 0; n < count; n++)
        {
            Instantiate(Ring, transform.GetChild(array2[n]).position, Ring.transform.rotation);
        }

        Destroy(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
