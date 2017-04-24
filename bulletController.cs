using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletController : MonoBehaviour {

    public GameObject Tree;
    public Vector3 TreeSpawn;
    public earthHealth eHealth;

    private void Update()
    {
        TreeSpawn = new Vector3(transform.position.x, 3.359f, transform.position.z);


    }

    private void OnCollisionEnter(Collision collision)
    {
        {
            if (collision.collider.gameObject.layer == LayerMask.NameToLayer("Ground"))
            {
                GameObject eHealth = GameObject.FindWithTag("eHealth");
                eHealth.GetComponent<earthHealth>().addTree();
                Instantiate(Tree, TreeSpawn, Quaternion.identity);
                Destroy(gameObject);
            }
        }

    }
}
