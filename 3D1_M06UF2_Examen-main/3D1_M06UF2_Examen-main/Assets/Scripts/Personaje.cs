using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Personaje : MonoBehaviour
{
	public float velocidad;
	public float salto;
	float movimiento;
	SpriteRenderer spriteRenderer; 
	BoxCollider2D boxcollider2D;
 	Rigidbody2D rigidbody2D;
	GroundSensor4 groundsensor;
    // Start is called before the first frame update
    void Start()
    {
    spriteRenderer = GetComponent<SpriteRenderer>();
	boxcollider2D = GetComponent<BoxCollider2D>();
	rigidbody2D = GetComponent <Rigidbody2D>();
	groundsensor = GameObject.Find("GroundSensor4").GetComponent <GroundSensor4>();
	velocidad = 5.5f;
	salto = 8f;
	}

    // Update is called once per frame
    void Update()
    {
     movimiento = Input.GetAxis("Horizontal"); 
	
		if (movimiento > 0)
    	{
		spriteRenderer.flipX = true;
    	}

		if (movimiento < 0)
    	{
		spriteRenderer.flipX = false;
   		}
		
		if(Input.GetButtonDown("Jump") && groundsensor.groundsensor)
		{
		rigidbody2D.AddForce(Vector2.up * salto, ForceMode2D.Impulse);
   	 	}
	}
	}
