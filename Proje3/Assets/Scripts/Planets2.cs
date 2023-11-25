using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Planets2 : MonoBehaviour
{
    public Vector3 rotate3;
    void Start()
    {
        rotate3 = new Vector3(0, 0.3f, 0);
    }
    void Update()
    {
        transform.Rotate(rotate3);
    }
}
