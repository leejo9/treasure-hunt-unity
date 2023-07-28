using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RNG : MonoBehaviour
{
    public GameObject treasure;
    public int xpos;
    public int zpos;
    public int num;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(spawn());
    }

    // Update is called once per frame
    IEnumerator spawn()
    {
        while (num < 9)
        {
            xpos = Random.Range(100, 700);
            zpos = Random.Range(-150, 650);
            Instantiate(treasure, new Vector3(xpos, 175, zpos), Quaternion.identity);
            yield return new WaitForSeconds(0.1f);
            num+=1;
        }
        
    }
}
