using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour {
    public float minusgreitis = 1.0f;
    public float greitis = 1.0f;
    public float power = 10;
    private Rigidbody2D rb;

    // Use this for initialization
    void Start () {

        rb = GetComponent<Rigidbody2D>();
    
	}
	
	// Update is called once per frame
	void Update () {

        //if (Input.GetKeyDown(KeyCode.Space))
        //{
        //    rb.AddForce(Vector2.up * power, ForceMode2D.Impulse);
        //}



        if (Input.GetKey(KeyCode.W))
        {
            greitis += 0.1f;
            Vector2 move = new Vector2(minusgreitis, greitis);
            rb.MovePosition(move);
        }

        if (Input.GetKey(KeyCode.S))
        {
            greitis -= 0.1f;
            Vector2 move = new Vector2(minusgreitis, greitis);
            rb.MovePosition(move);
        }

        if (Input.GetKey(KeyCode.A))
        {
            minusgreitis -= 0.1f;
            Vector2 move = new Vector2(minusgreitis, greitis);
            rb.MovePosition(move);
        }

        if (Input.GetKey(KeyCode.D))
        {
            minusgreitis += 0.1f;
            Vector2 move = new Vector2(minusgreitis, greitis);
            rb.MovePosition(move);
        }






        //float xaxis = Input.GetAxis("Horizontal");

        //transform.Translate(Vector2.right * xaxis);

        //transform.position = new Vector2(Mathf.Clamp(transform.position.x, -6.5f, 6.5f), 0);

        //float yaxis = Input.GetAxis("Vertical");

        //transform.Translate(Vector2.up * yaxis);



    }

}
