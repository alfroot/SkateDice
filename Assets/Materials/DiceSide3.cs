using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiceSide3 : MonoBehaviour
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
            if(col.gameObject.tag == "SPINS"){ 
           
                switch (col.gameObject.name) {
                case "180":
                    DiceNumberTextScript.diceNumber2 = "180";
                    break;
                case "1802":
                    DiceNumberTextScript.diceNumber2 = "180";
                    break;
                case "360":
                    DiceNumberTextScript.diceNumber2 = "360";
                    break;
                case "3602":
                    DiceNumberTextScript.diceNumber2 = "360";
                    break;
                case "SD":
                    DiceNumberTextScript.diceNumber2 = "";
                    break;
                case "SD2":
                    DiceNumberTextScript.diceNumber2 = "";
                    break;
                }
            }
		}
	}
   
}
