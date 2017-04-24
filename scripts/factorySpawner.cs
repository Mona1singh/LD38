using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class factorySpawner : MonoBehaviour {

    public GameObject Factory;

    public Transform spawn01;
    public Transform spawn02;
    public Transform spawn03;
    public Transform spawn04;
    public Transform spawn05;
    public Transform spawn06;

    public int howManySpawned;
    public int howManyAlive;
    public float firstSpawn;

    public bool pos1Taken;
    public bool pos2Taken;
    public bool pos3Taken;
    public bool pos4Taken;
    public bool pos5Taken;
    public bool pos6Taken;

    public bool debug01;

    public earthHealth eHealth;

    Vector3 pos1;
    Vector3 pos2;
    Vector3 pos3;
    Vector3 pos4;
    Vector3 pos5;
    Vector3 pos6;


    public void Start()
    {
        var pel = Random.Range(1f, 6f);
        var rot = Random.Range(1f, 360f);
        pel = Mathf.Round(pel);
        firstSpawn = pel;


        if (pel == 1)
        {
            //if (!pos1Taken)
            //{
                pos1 = new Vector3(spawn01.transform.position.x, -42.25303f, spawn01.transform.position.z);
                var one = Instantiate(Factory, pos1, spawn01.transform.rotation);
                howManySpawned += 1;
                howManyAlive += 1;
                pos1Taken = true;
                eHealth.amountOfFactories += 1;
                StartCoroutine(fix());
            //}
        }

        if (pel == 2)
        {
            //if (!pos2Taken)
            //{
                pos2 = new Vector3(spawn02.transform.position.x, -42.25303f, spawn02.transform.position.z);
                var one = Instantiate(Factory, pos2, spawn02.transform.rotation);
                howManySpawned += 1;
                howManyAlive += 1;
                pos2Taken = true;
                eHealth.amountOfFactories += 1;
                StartCoroutine(fix());
            //}
        }

        if (pel == 3)
        {
            //if (!pos3Taken)
            //{
                pos3 = new Vector3(spawn03.transform.position.x, -42.25303f, spawn03.transform.position.z);
                var one = Instantiate(Factory, pos3, spawn03.transform.rotation);
                howManySpawned += 1;
                howManyAlive += 1;
                pos3Taken = true;
                eHealth.amountOfFactories += 1;
                StartCoroutine(fix());
            //
        }

        if (pel == 4)
        {
            //if (!pos4Taken)
            //{
                pos4 = new Vector3(spawn04.transform.position.x, -42.25303f, spawn04.transform.position.z);
                var one = Instantiate(Factory, pos4, spawn04.transform.rotation);
                howManySpawned += 1;
                howManyAlive += 1;
                eHealth.amountOfFactories += 1;
                pos4Taken = true;
                StartCoroutine(fix());
            //}

        }

        if (pel == 5)
        {
            //if (!pos5Taken)
            //{
                pos5 = new Vector3(spawn05.transform.position.x, -42.25303f, spawn05.transform.position.z);
                var one = Instantiate(Factory, pos5, spawn05.transform.rotation);
                howManySpawned += 1;
                howManyAlive += 1;
                eHealth.amountOfFactories += 1;
                StartCoroutine(fix());
            //}
        }

        if (pel == 6)
        {
            //if (!pos6Taken)
            //{
                pos6 = new Vector3(spawn06.transform.position.x, -42.25303f, spawn06.transform.position.z);
                var one = Instantiate(Factory, pos6, spawn06.transform.rotation);
                howManySpawned += 1;
                howManyAlive += 1;
                eHealth.amountOfFactories += 1;
                pos6Taken = true;
                StartCoroutine(fix());
            //}
        }
    }

    public IEnumerator fix()
    {
        yield return new WaitForSeconds(5);
        debug01 = true;
        spawnFactories();
    }

    private void Update()
    {
        if (debug01)
        {
            StartCoroutine(fix());
            debug01 = false;

        }


    }

    void spawnFactories()
    {
        var pel = Random.Range(1f, 6f);
        pel = Mathf.Round(pel);


        if (pel == 1)
        {
            if (!pos1Taken)
            {
                pos1 = new Vector3(spawn01.transform.position.x, -42.25303f, spawn01.transform.position.z);
                var one = Instantiate(Factory, pos1, spawn01.transform.rotation);
                howManySpawned += 1;
                howManyAlive += 1;
                pos1Taken = true;
                eHealth.amountOfFactories += 1;
            }
        }

        if (pel == 2)
        {
            if (!pos2Taken)
            {
                pos2 = new Vector3(spawn02.transform.position.x, -42.25303f, spawn02.transform.position.z);
                var one = Instantiate(Factory, pos2, spawn02.transform.rotation);
                howManySpawned += 1;
                howManyAlive += 1;
                pos2Taken = true;
                eHealth.amountOfFactories += 1;
            }
        }

        if (pel == 3)
        {
            if (!pos3Taken)
            {
                pos3 = new Vector3(spawn03.transform.position.x, -42.25303f, spawn03.transform.position.z);
                var one = Instantiate(Factory, pos3, spawn03.transform.rotation);
                howManySpawned += 1;
                howManyAlive += 1;
                pos3Taken = true;
                eHealth.amountOfFactories += 1;
            }
        }

        if (pel == 4)
        {
            if (!pos4Taken)
            {
                pos4 = new Vector3(spawn04.transform.position.x, -42.25303f, spawn04.transform.position.z);
                var one = Instantiate(Factory, pos4, spawn04.transform.rotation);
                howManySpawned += 1;
                howManyAlive += 1;
                eHealth.amountOfFactories += 1;
                pos4Taken = true;
            }

        }

        if (pel == 5)
        {
            if (!pos5Taken)
            {
                pos5 = new Vector3(spawn05.transform.position.x, -42.25303f, spawn05.transform.position.z);
                var one = Instantiate(Factory, pos5, spawn05.transform.rotation);
                howManySpawned += 1;
                howManyAlive += 1;
                eHealth.amountOfFactories += 1;
            }
        }

        if (pel == 6)
        {
            if (!pos6Taken)
            {
                pos6 = new Vector3(spawn06.transform.position.x, -42.25303f, spawn06.transform.position.z);
                var one = Instantiate(Factory, pos6, spawn06.transform.rotation);
                howManySpawned += 1;
                howManyAlive += 1;
                eHealth.amountOfFactories += 1;
                pos6Taken = true;
            }
        }


    }

}
