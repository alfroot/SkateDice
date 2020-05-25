using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class FloorSound : MonoBehaviour
{

	public AudioSource tick;


	void OnCollisionEnter(Collision other)
	{
		tick = GetComponent<AudioSource> ();		
			tick.Play();
		
	}

	
}   
