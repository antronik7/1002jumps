using UnityEngine;
using System.Collections;

public class MapGenerator : MonoBehaviour {

    public GameObject[] section;
    public GameObject baseSection;
    public GameObject motherShip;

    public float LastSpawnPos;
    int index;

    // Use this for initialization
    void Start () {
        LastSpawnPos = 10;
	}
	
	// Update is called once per frame
	void Update () {
	    if(GameManager.instance.gameStart)
        {
            if(LastSpawnPos - Camera.main.transform.position.y < 10)
            {
                index = Random.Range(0, 5);

                LastSpawnPos = LastSpawnPos + 10;
                Instantiate(section[index], new Vector3(0, LastSpawnPos, 0), Quaternion.identity);
            }
        }
	}

    public void FirstGeneration()
    {
        LastSpawnPos = LastSpawnPos + 10;

        Instantiate(baseSection, new Vector3(0, LastSpawnPos, 0), Quaternion.identity);

        Instantiate(motherShip, new Vector3(0, LastSpawnPos - 6, 0), motherShip.transform.rotation);

        LastSpawnPos = LastSpawnPos + 10;

        index = Random.Range(0, 5);

        Instantiate(section[index], new Vector3(0, LastSpawnPos, 0), Quaternion.identity);
    }
}
