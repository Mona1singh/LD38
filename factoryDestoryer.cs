using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class factoryDestoryer : MonoBehaviour
{

    public GameObject Factory;
    

    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<Collider>().gameObject.layer == LayerMask.NameToLayer("Bullet"))
        {
            GameObject eHealth = GameObject.FindWithTag("eHealth");
            GameObject arm1 = GameObject.FindWithTag("arm1");
            GameObject arm2 = GameObject.FindWithTag("arm2");
            Debug.Log("fuck");
            eHealth.GetComponent<earthHealth>().subtractFactory();
            arm1.GetComponent<playerController>().AddAmmo();
            arm2.GetComponent<rightArm>().AddAmmo();
            Destroy(Factory);
        }


    }



}
