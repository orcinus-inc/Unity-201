using UnityEngine;
using System.Collections;

public class Rotator : MonoBehaviour
{
    public Vector3 rotation;
    void Update()
    {
        //transform.Rotate(new Vector3(15, 30, 45) * Time.deltaTime);
        transform.Rotate(rotation * Time.deltaTime);
    }
}