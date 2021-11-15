using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : MonoBehaviour
{
    public GameObject bullet;
    public Transform firePoint;

    public AudioSource shootSound;

    public void Shoot()
    {
        shootSound.Play();
        Instantiate(bullet, firePoint.position, Quaternion.identity);        
    }
}
