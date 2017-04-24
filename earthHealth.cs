using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class earthHealth : MonoBehaviour
{

    public float Health;
    public float amountOfTrees;
    public float amountOfFactories;

    public float perSec;
    public float perSec2;

    public bool deductable;
    public bool deductable2;
    public Text earthDisplay;

    private void Update()
    {
        earthDisplay.text = "Earth Health" + "/" + Health;

        perSec = amountOfFactories / 2;
        perSec2 = amountOfTrees / 3;


        if (!deductable)
        {
            Health = Health - perSec;
            deductable = true;
            StartCoroutine(factoryCal());
        }

        if (!deductable2)
        {
            Health = Health + perSec2;
            deductable2 = true;
            StartCoroutine(treeCal());
        }

        if (Health >= 100)
        {
            Health = 100;
        }

        if (Health >= 0)
        {
            SceneManager.LoadScene(0);

        }

    }

    public void subtractFactory()
    {
        amountOfFactories -= 1;
    }

    public void addTree()
    {
        amountOfTrees += 1;
    }

    public IEnumerator factoryCal()
    {
        yield return new WaitForSeconds(1);
        deductable = false;
    }

    public IEnumerator treeCal()
    {
        yield return new WaitForSeconds(8);
        deductable2 = false;
    }
}
