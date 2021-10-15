using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    public float movementspeed=1000000000000000f;
    public spwanmanager spwanmanager;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float amovement = Input.GetAxis("Horizontal") * movementspeed;
        float bmovement = Input.GetAxis("Vertical") * movementspeed;
        transform.Translate(new Vector3(bmovement,0,-amovement)*Time.deltaTime*movementspeed*3);
    }

    private void OnTriggerEnter(Collider other)
    {
        print(other.gameObject.name);
        spwanmanager.spawntrigg();
    }
}
