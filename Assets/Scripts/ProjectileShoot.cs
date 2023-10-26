using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileShoot : MonoBehaviour
{
//reference to the rojectile prefab
    public GameObject projectilePrefab;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    //check if the fire1 button is pressed and if it is
        if(Input.GetButtonDown("Fire1"))
        {
        //creates an instance of the projectileprefab at the position of the gameobject that it;s attached to(the trans.position) and the quaternion gives us rotation
            Instantiate(projectilePrefab, transform.position, Quaternion.identity);
        }
    }
}
