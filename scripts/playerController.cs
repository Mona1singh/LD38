using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class playerController : MonoBehaviour
{
    public int currentInMag;
    public float ROF;
    public GameObject bullet;
    public GameObject shell;
    public Transform bulletSpawn;
    public bool Shot;

    public Text SC;
    public Text P;

    public Animator anim;
    public Text text01;

    private void Start()
    {
        
    }


    private void Update()
    {
        text01.text = currentInMag + ";";

        if (Input.GetMouseButton(0))
        {
            anim.SetBool("shooting", true);
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
            anim.SetBool("shooting", false);

        }
    }

    public void Shooting()
    {
        if (!Shot)
        {
            //Creating the bullet and shooting it
            var pel = Instantiate(bullet, bulletSpawn.position, Quaternion.identity);
            pel.GetComponent<Rigidbody>().AddForce(transform.forward * 1000f);
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
        currentInMag += 2;
    }
}
       
