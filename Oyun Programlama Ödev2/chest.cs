using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chest : MonoBehaviour
{
    public GameObject ggem;
    public GameObject rgem;
    public GameObject bgem;
    bool durum = false;


    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Duvar")
        {
            durum = true;
            if (durum)
            {
                for(int i = 1; i < 30; i++)
                {
                    SpawnGem();
                }
            }
        }
    }

    private void SpawnGem()
    {
        GameObject ggem1 = Instantiate(ggem, transform.position, Quaternion.identity);
        GameObject rgem1 = Instantiate(rgem, transform.position, Quaternion.identity);
        GameObject bgem1 = Instantiate(bgem, transform.position, Quaternion.identity);
        durum = false;
        Destroy(bgem1, 2f);
        Destroy(ggem1, 4f);
        Destroy(rgem1, 6f);
    }
}
