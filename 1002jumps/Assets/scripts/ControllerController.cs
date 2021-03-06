﻿using UnityEngine;
using System.Collections;

public class ControllerController : MonoBehaviour {

    public GameObject SmallControler;

    private GameObject player;
    private GameObject arrow;
    private GameObject reactor;
    private Vector3 initialPos;
    private Vector3 mousePreviousPos;
    private Vector3 difference;

    

    // Use this for initialization
    void Start () {
        initialPos = transform.position;
        mousePreviousPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        SmallControler.transform.position = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        player = GameObject.Find("player(Clone)");
        arrow = GameObject.Find("player(Clone)/rotator/arrow");
        reactor = GameObject.Find("player(Clone)/rotator/reactor");
        reactor.SetActive(false);
        player.GetComponent<Rigidbody2D>().velocity = Vector3.zero;
    }
	
	// Update is called once per frame
	void Update () {

        if(GameManager.instance.gameStart == false)
        {
            Destroy(gameObject);
        }

        initialPos = transform.position;

        mousePreviousPos = mousePreviousPos + (Vector3.up * (Time.deltaTime * (GameManager.instance.speed + GameManager.instance.Score / 10)));
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);


        Vector3 objectPos = SmallControler.transform.position + (mousePos - mousePreviousPos);

        objectPos.z = 0f;


        Vector3 allowedPos = objectPos - initialPos;

        allowedPos = Vector3.ClampMagnitude(allowedPos, 1.5f);


        SmallControler.transform.position = initialPos + allowedPos;

        mousePreviousPos = mousePos;

        difference = SmallControler.transform.position - transform.position;

        float rotZ = (Mathf.Atan2(difference.y, difference.x) * Mathf.Rad2Deg) -270;

        //rotator.transform.rotation = Quaternion.AngleAxis(rotZ, Vector3.forward);

        if(difference.magnitude > 0.1f)
        {
            player.transform.rotation = Quaternion.AngleAxis(rotZ, Vector3.forward);
            arrow.transform.localScale = new Vector3(1 + difference.magnitude, 1 + difference.magnitude, arrow.transform.localScale.z);
            arrow.GetComponent<SpriteRenderer>().enabled = true;
        }
        else
        {
            arrow.GetComponent<SpriteRenderer>().enabled = false;
        }

        if (Input.GetMouseButtonUp(0))
        {
            if (difference.magnitude > 0.1f)
            {
                //player.GetComponent<Rigidbody2D>().AddForce((-difference.normalized * 75) * ((arrow.transform.localScale.y - 1) * 10));
                player.GetComponent<Rigidbody2D>().AddForce(-difference.normalized * (450 * (difference.magnitude / 1.5f)));
                arrow.GetComponent<SpriteRenderer>().enabled = false;
                reactor.SetActive(true);
            }

            Destroy(gameObject);
        }
    }
}
