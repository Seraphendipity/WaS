using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResourceNode : MonoBehaviour
{


    public GameObject[] pfItems;
    public Vector2 population = new Vector2(2,20);
    public Vector2 radius = new Vector2(5.0f,15.0f);

    private float populationActual; 
    private float radiusActual; 
    private Vector3 spawnPos;
    private int itemNum;

    // Start is called before the first frame update
    void Awake()
    {
        populationActual = Random.Range(population[0], population[1]);
        radiusActual = Random.Range(radius[0], radius[1]);

        for(int i = 0; i < populationActual; i++) {
            RandomItem();
        }
    }

    void RandomItem() {
        spawnPos = transform.position;
        spawnPos += new Vector3(Random.Range(-radiusActual, radiusActual), 0.75f, Random.Range(-radiusActual, radiusActual));
        itemNum = Random.Range(0, pfItems.Length);
        Instantiate(pfItems[itemNum], spawnPos, Quaternion.identity);
    }
}
