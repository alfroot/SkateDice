using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiceSide : MonoBehaviour
{

	Vector3 diceVelocity;
    
	// Update is called once per frame
	void FixedUpdate () {
		diceVelocity = Dice.diceVelocity;
	}

	void OnTriggerStay(Collider col)
	{
		if (diceVelocity.x == 0f && diceVelocity.y == 0f && diceVelocity.z == 0f)
		{			
            if(col.gameObject.tag == "FLIPS"){ 
           
                switch (col.gameObject.name) {
                case "HeelFlip":
                    DiceNumberTextScript.diceNumber = "HeelFlip";
                    break;
                case "HeelFlip2":
                    DiceNumberTextScript.diceNumber = "HeelFlip";
                    break;
                case "KickFlip":
                    DiceNumberTextScript.diceNumber = "KickFlip";
                    break;
                case "KickFlip2":
                    DiceNumberTextScript.diceNumber = "KickFlip";
                    break;
                case "SD":
                    DiceNumberTextScript.diceNumber = "";
                    break;
                case "SD2":
                    DiceNumberTextScript.diceNumber = "";
                    break;
                }
            }          

		}
	}
   
}
