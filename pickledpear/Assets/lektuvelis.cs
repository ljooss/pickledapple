using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lektuvelis : MonoBehaviour {

    














    public GameObject kulka;
    public GameObject kulkasuper;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
       float xaxis = Input.GetAxis("Horizontal");

        transform.Translate(Vector2.right * xaxis);

        transform.position = new Vector2(Mathf.Clamp(transform.position.x, -6.5f, 6.5f), -4.02f);

        //instantiate
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(kulka, transform.position, Quaternion.identity);
            //  transform.Translate(Vector2.up * 2);
        }
        if (Input.GetKeyDown(KeyCode.F))
        {
            Instantiate(kulkasuper, transform.position, Quaternion.identity);
        }
    }
}



