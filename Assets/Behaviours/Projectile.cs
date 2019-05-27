using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public float TravelSpeed = 50.0f;

    void Update()
    {
        gameObject.transform.position += gameObject.transform.forward * TravelSpeed * Time.deltaTime;
    }
}
