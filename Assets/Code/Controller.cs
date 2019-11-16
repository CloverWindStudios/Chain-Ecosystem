using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class NewBehaviourScript : MonoBehaviour
{
    public bool bunnyExist;
    public bool birdExist;
    public bool catExist;
    public bool squirrleExist;
    public double respawnTime;
    public GameObject bunnyObj;
    public GameObject birdObj;
    public GameObject catObj;
    public GameObject squirrleObj;
    // Start is called before the first frame update
    void Start()
    {
        if (bunnyExist)
        {
            Instantiate(bunnyObj);
            Instantiate(bunnyObj);
        }
        if (birdExist)
        {
            Instantiate(birdObj);
            Instantiate(birdObj);
        }
        if (catExist)
        {
            Instantiate(catObj);
            Instantiate(catObj);
        }
        if (squirrleExist)
        {
            Instantiate(squirrleObj);
            Instantiate(squirrleObj);
        }
    }
    // Update is called once per frame
    void Update()
    {

    }
}
