using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Planets3 : MonoBehaviour
{
    public Vector3 rotate2;
    void Start()
    {
        rotate2 = new Vector3(0, -0.2f, 0);//Ven�s ve Uran�s i�in saat y�n� tersi d�n��
    }
    void Update()
    {
        transform.Rotate(rotate2);
    }
}
