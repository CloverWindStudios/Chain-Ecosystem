using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Controller : MonoBehaviour
{
    public bool bunnyExist;
    public bool birdExist;
    public bool catExist;
    public bool squirrleExist;
    public double respawnTime;
    public GameObject bunnyObj;
    public GameObject birdObj;
    public GameObject catObj;
    public GameObject squirrelObj;
    // Start is called before the first frame update
    void Start()
    {
        if (bunnyExist)
        {
            SpawnAnimal(bunnyObj);
            SpawnAnimal(bunnyObj);
        }
        if (birdExist)
        {
            SpawnAnimal(birdObj);
            SpawnAnimal(birdObj);
        }
        if (catExist)
        {
            SpawnAnimal(catObj);
            SpawnAnimal(catObj);
        }
        if (squirrleExist)
        {
            SpawnAnimal(squirrelObj);
            SpawnAnimal(squirrelObj);
        }
    }
    // Update is called once per frame
    void Update()
    {
    }
    void SpawnAnimal(GameObject animal)
    {
        Vector3 position = new Vector3(Random.Range(-10.0F, 10.0F),
            2, Random.Range(-10.0F, 10.0F));
        Instantiate(animal, position, Quaternion.identity);
    }

}
