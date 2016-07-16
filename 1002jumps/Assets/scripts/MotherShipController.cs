using UnityEngine;
using System.Collections;

public class MotherShipController : MonoBehaviour {

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (GameManager.instance.gameStart)
        {
            transform.Translate(Vector3.down * (Time.deltaTime * (2.5f + GameManager.instance.Score / 10)));
        }
    }
}
