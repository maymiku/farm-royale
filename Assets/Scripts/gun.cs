using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gun : MonoBehaviour
{
    public float damage = 5f;
    public float range = 100f;

    public Camera character;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
    }

    void Shoot()
    {
        RaycastHit hit;
        if(Physics.Raycast(character.transform.position, character.transform.forward, out hit, range))
        {
            Debug.Log(hit.transform.name);
        }
    }
}
