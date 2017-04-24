using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletController2 : MonoBehaviour {

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.gameObject.layer == LayerMask.NameToLayer("Player"))
        {
        }
        else
        {
            Destroy(gameObject);
        }
    }


}
