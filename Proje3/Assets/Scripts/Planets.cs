using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Planets : MonoBehaviour
{
    public Vector3 rotate1;
    void Start()
    {
        rotate1 = new Vector3(0, 0.1f, 0);
    }

    void Update()
    {
        transform.Rotate(rotate1);
    }
}
