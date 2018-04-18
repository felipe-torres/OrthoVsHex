using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Defense : Structure
{
    public float damagePerSecond;
    public float damagePerShot;
    private float fireRate; // dpshot/dpsecond
	public int range; 

    // Use this for initialization
    void Start()
    {
        fireRate = damagePerShot / damagePerSecond;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
