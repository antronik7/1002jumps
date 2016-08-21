using UnityEngine;
using System.Collections;

public class SectionController : MonoBehaviour {

    public GameObject[] coinSpawner;
    public GameObject coin;

	// Use this for initialization
	void Start () {
        if(Random.Range(1, 5) > 2)
        {
            int index = Random.Range(0, coinSpawner.Length);
            Instantiate(coin, coinSpawner[index].transform.position, Quaternion.identity);
        }
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
