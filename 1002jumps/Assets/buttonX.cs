using UnityEngine;
using System.Collections;

public class buttonX : MonoBehaviour {

    public GameObject Shop;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void click()
    {
        Shop.SetActive(false);
    }
}
