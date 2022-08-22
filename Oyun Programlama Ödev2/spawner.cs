using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{
    public GameObject chest;



    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Spawn();
        }

        void Spawn()
        {
            float randomy = Random.Range(0.579f, 1.567f);
            float randomx = Random.Range(-0.777f, 0.81f);
            GameObject newChest = Instantiate(chest, new Vector3(randomx,randomy, -9.265f), Quaternion.Euler(270f, 180f, 270f));
            newChest.GetComponent<Rigidbody>().AddForce(Vector3.forward * 1100);
            Destroy(newChest, 2f);
        }
    }
}
