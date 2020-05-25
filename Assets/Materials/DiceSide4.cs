using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiceSide4 : MonoBehaviour
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

            if(col.gameObject.tag == "JUMP"){ 
           
                switch (col.gameObject.name) {
                case "Ollie":
                    DiceNumberTextScript.diceNumber3 = "Switch";
                    break;
                case "Switch":
                    DiceNumberTextScript.diceNumber3 = "Ollie";
                    break;
                case "Fakie":
                    DiceNumberTextScript.diceNumber3 = "Nollie";
                    break;
                case "Nollie":
                    DiceNumberTextScript.diceNumber3 = "Fakie";
                    break;
                case "SD":
                    DiceNumberTextScript.diceNumber3 = "";
                    break;
                case "SD2":
                    DiceNumberTextScript.diceNumber3 = "";
                    break;
                }
            }
	    }   
    }
}