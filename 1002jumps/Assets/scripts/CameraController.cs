using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {

    private GameObject player;

	// Use this for initialization
	void Start () {
        player = GameObject.Find("player");
    }
	
	// Update is called once per frame
	void Update () {
        transform.position = new Vector3(transform.position.x, player.transform.position.y, transform.position.z);
	}
}
