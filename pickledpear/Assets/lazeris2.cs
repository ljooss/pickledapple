using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lazeris2 : MonoBehaviour {

    public float speedsuper = 0.5f;

    // Use this for initialization
    void Start () {

	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(Vector2.up * speedsuper);
	}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "enemy")
        {
            UImanagement.instance.score++;
            UImanagement.instance.tekstas.text = "score = " + UImanagement.instance.score;
            Destroy(collision.gameObject);
        }

        if(collision.tag == "lubos")
        {
            Destroy(gameObject);
        }
    }














}
