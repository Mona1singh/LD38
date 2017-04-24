using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class rightArm : MonoBehaviour {

    public GameObject bullet;
    public Transform bulletSpawn;

    
    public bool Shot;
    public float ROF;

    public int currentInMag;
    public string Sphere = "Sphere(Clone)";
    public string Sphere02 = "Sphere";

    public Animator anim;
    public Text text01;



    private void Update()
    {
        text01.text = currentInMag + ";";

        if (Input.GetMouseButtonDown(1))
        {
            anim.SetBool("shooting2", true);
            if (currentInMag > 0)
            {
                Shooting();
            }
            else
            {
                //noAmmo.Play();

            }
        }
        else
        {
            anim.SetBool("shooting2", false);
        }

    }

    public void Shooting()
    {
        if (!Shot)
        {
            //Creating the bullet and shooting it
            var pel = Instantiate(bullet, bulletSpawn.position, Quaternion.identity);
            pel.GetComponent<Rigidbody>().AddForce(transform.forward * 8000f);
            //Playing the bullet noise
            //Shot.Play();

            //shooting and reloading
            currentInMag -= 1;

            //Raycasting
            RaycastHit hit;

            if (Physics.Raycast(bulletSpawn.position, transform.forward, out hit))
            {
                Debug.Log(hit.transform.name + "has been hit");
            }

            Shot = true;
            StartCoroutine(shootingFix());
        }
    }

    public IEnumerator shootingFix()
    {
        yield return new WaitForSeconds(ROF);
        Shot = false;
    }

    public void AddAmmo()
    {
        currentInMag += 3;
    }

}
