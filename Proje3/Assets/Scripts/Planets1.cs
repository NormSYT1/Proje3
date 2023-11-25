using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Planets1 : MonoBehaviour
{
    public Vector3 rotate2;
    void Start()
    {
        rotate2 = new Vector3(0, 0.2f, 0);
    }
    void Update()
    {
        transform.Rotate(rotate2);
    }
}
