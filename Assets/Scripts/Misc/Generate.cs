using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generate : MonoBehaviour
{
    public GameObject prefab;
    // public int count = 5;

    // Start is called before the first frame update
    void Start()
    {
        // generate random prefabs
        /*
        for (int i =0; i< count; i++) {
            float x = Random.Range(-10f, 10f);
            float y = -0.8f; // Random.Range(-2.5f, 2.5f);
            float z = Random.Range(-10f, 10f);
            GameObject g = Instantiate(prefab, new Vector3(x, y, z), Quaternion.identity);

            // faces prefab upright
            // g.transform.Rotate(270, 0, 0);

            // scales prefab
            // g.transform.localScale = new Vector3(0.3298337f, 0.2676086f, 0.1688685f);
        }
        */

        GameObject coin1 = Instantiate(prefab, new Vector3(-134f, 22f, -8f), Quaternion.identity);
        GameObject coin2 = Instantiate(prefab, new Vector3(-106f, 26f, 1f), Quaternion.identity);
        GameObject coin3 = Instantiate(prefab, new Vector3(-66.5f, 28f, -10f), Quaternion.identity);
        GameObject coin4 = Instantiate(prefab, new Vector3(-84f, 28f, 1f), Quaternion.identity);
        GameObject coin5 = Instantiate(prefab, new Vector3(-30f, 30f, 3f), Quaternion.identity);
        GameObject coin6 = Instantiate(prefab, new Vector3(-8f, 32f, -4f), Quaternion.identity);
        GameObject coin7 = Instantiate(prefab, new Vector3(-48f, 33f, -1f), Quaternion.identity);
        GameObject coin8 = Instantiate(prefab, new Vector3(-11f, 28f, -22f), Quaternion.identity);
        GameObject coin9 = Instantiate(prefab, new Vector3(10f, 28f, -5.5f), Quaternion.identity);
        GameObject coin10 = Instantiate(prefab, new Vector3(23f, 36f, -5.5f), Quaternion.identity);
        GameObject coin11 = Instantiate(prefab, new Vector3(58f, 26f, -4f), Quaternion.identity);
        GameObject coin12 = Instantiate(prefab, new Vector3(76f, 28f, -8f), Quaternion.identity);
        GameObject coin13 = Instantiate(prefab, new Vector3(85f, 33f, 8f), Quaternion.identity);
        GameObject coin14 = Instantiate(prefab, new Vector3(107f, 27f, 2f), Quaternion.identity);
        GameObject coin15 = Instantiate(prefab, new Vector3(130f, 31f, 33f), Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
