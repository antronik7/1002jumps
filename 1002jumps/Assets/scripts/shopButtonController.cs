using UnityEngine;
using System.Collections;

public class shopButtonController : MonoBehaviour {

    public GameObject shopUI;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void click()
    {
        shopUI.SetActive(true);
    }
}
