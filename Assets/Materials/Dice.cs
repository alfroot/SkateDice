using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using System;



public class Dice : MonoBehaviour
{

    static Rigidbody rb;
	public static Vector3 diceVelocity;  
	public float speed = 150f;
	public bool shake;
	public bool prepared;
	public bool onGame;
	public Vector3 initPos;
	public AudioSource tick;

	public Collider col;

    // Start is called before the first frame update
    void Start()
    {
		
		rb = GetComponent<Rigidbody> ();
		initPos = rb.transform.position;
		prepared = true;
    }

    // Update is called once per frame
    void Update()
    {	
		rb = GetComponent<Rigidbody> ();
		col =  GetComponent<Collider> ();
        diceVelocity = rb.velocity;		

		if(Input.touchCount > 0)
		{
		Touch touch = Input.GetTouch (0);
		}

		shake = Shake.shake;
		if (Input.GetKeyDown(KeyCode.Space) || Input.touchCount > 0 || shake == true) 
		{		
			
			cleanText();
			transform.position = initPos; 
			float dirX = UnityEngine.Random.Range (-10, 100);
			float dirY = UnityEngine.Random.Range (-10, 100);
			float dirZ = UnityEngine.Random.Range (-10, 100);

			transform.position = initPos;
			transform.Rotate (new Vector3(0,Time.deltaTime*50,0));
			transform.position = new Vector3 (UnityEngine.Random.Range (-10, 14), UnityEngine.Random.Range (1, 8) ,UnityEngine.Random.Range (-7, 7));
			
			rb.AddForce (transform.up );
 			rb.AddTorque (dirX, dirY, dirZ);
			transform.Translate(0.1f,0,0);
			rb.maxAngularVelocity = float.MaxValue;
  			//rb.velocity = new Vector3 (UnityEngine.Random.Range (-11, 14), UnityEngine.Random.Range (1, 6) ,UnityEngine.Random.Range (-5, 5));			
			
		}

	}

	void cleanText()
	{
		DiceNumberTextScript.diceNumber = "";
		DiceNumberTextScript.diceNumber1 = "";
		DiceNumberTextScript.diceNumber2 = "";
		DiceNumberTextScript.diceNumber3 = "";
	}

	void spinAroundDiceMove(){
	
		prepared = true;
		
		//transform.position = initPos; 
		//transform.position = new Vector3 (8,1,2);			
		transform.Rotate (new Vector3(0,Time.deltaTime*50,0));

		switch (col.tag)
		{
			case "DIR":
                    transform.position = new Vector3 (3,2,-5);	
                    break;
			case "JUMP":
                    transform.position = new Vector3 (3,2,-2);	
                    break;
			case "FLIPS":
                    transform.position = new Vector3 (3,2,4);	
                    break;
			case "SPINS":
                    transform.position = new Vector3 (3,2,1);	
                    break;
			
		}		
	}

	void OnCollisionEnter(Collision other)
	{
		tick = GetComponent<AudioSource> ();		
		col =  GetComponent<Collider> ();
		
		if(other.gameObject.name+col.gameObject.name == "BoxBox"){
			tick.Play();
		}
	}

	
}   
