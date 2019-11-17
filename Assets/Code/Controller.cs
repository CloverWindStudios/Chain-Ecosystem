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
    private int numBunnies = 1; //we start with 1 bunny in the game
    private int numCats = 1; //we start with 1 lion in the game
    // Start is called before the first frame update
    public int respawnRabbits = 0;
    public int respawnCats = 0;
    public GameObject cats;
    public GameObject bunnies;
    //respawn plants
    //respawn bunnies in 1/4 the time of lions
    void Start()
    {
        if (bunnyExist)
        {
            if (numBunnies < 2)
            {
                SpawnAnimal(bunnyObj);
                SpawnAnimal(bunnyObj);
            }
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
        if (GameObject.Find("Rabbit 1"))
        {
            respawnRabbits++;
        }
        if (GameObject.Find("Lion"))
        {
            respawnCats++;
        }
        if (respawnCats >= 250)
        {
            for (int i = 0; i < Random.Range(1, 30); i++)
            {
                Vector3 position = new Vector3(Random.Range(-10.0F, 10.0F),
                    1, Random.Range(-10.0F, 10.0F));
                Instantiate(cats, position, Quaternion.identity);
            }
            respawnCats = 0;
        }
        if(respawnRabbits >= 250)
        {
            for (int i = 0; i < Random.Range(1, 30); i++)
            {
                Vector3 position = new Vector3(Random.Range(-10.0F, 10.0F),
                    2, Random.Range(-10.0F, 10.0F));
                Instantiate(bunnies, position, Quaternion.identity);
            }
            respawnRabbits = 0;
        }
    }
    void SpawnAnimal(GameObject animal)
    {
        for (int i = 0; i < Random.Range(1, 40); i++)
        {
            Vector3 position = new Vector3(Random.Range(-10.0F, 10.0F),
                2, Random.Range(-10.0F, 10.0F));
            Instantiate(animal, position, Quaternion.identity);
        }
    }
}
