using UnityEngine;
using System.Collections;

public class TutoSpawnerController : MonoBehaviour {

    public GameObject Tuto;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	    if(transform.position.y == Camera.main.transform.position.y)
        {
            Instantiate(Tuto, new Vector3(transform.position.x + 2, transform.position.y, transform.position.z), Quaternion.identity);
            GameManager.instance.GetComponent<GameplayController>().enabled = true;
            Destroy(gameObject);
        }
	}
}
