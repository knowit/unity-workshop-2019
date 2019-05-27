using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileLauncher : MonoBehaviour
{
    public GameObject Projectile;
    public float ProjectileLife = 5.0f;

    IEnumerator Fire()
    {
        var projectileObject = Instantiate(Projectile, gameObject.transform.position, gameObject.transform.rotation);
        yield return new WaitForSeconds(ProjectileLife);
        Destroy(projectileObject);
    }

    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            StartCoroutine(Fire());
        }
    }
}
