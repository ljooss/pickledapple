using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lektuvelis : MonoBehaviour {

   
    public GameObject kulka;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
       float xaxis = Input.GetAxis("Horizontal");

        transform.Translate(Vector2.right * xaxis);


        //instantiate
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(kulka, transform.position, Quaternion.identity);
            //  transform.Translate(Vector2.up * 2);
        }



    }
}
