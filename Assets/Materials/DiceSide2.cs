using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiceSide2 : MonoBehaviour
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

            if(col.gameObject.tag == "DIR"){ 
           
                switch (col.gameObject.name) {
                case "BackSide":
                    DiceNumberTextScript.diceNumber1 = "BackSide";
                    break;
                case "BackSide2":
                    DiceNumberTextScript.diceNumber1 = "BackSide";
                    break;
                case "FrontSide":
                    DiceNumberTextScript.diceNumber1 = "FrontSide";
                    break;
                case "FrontSide2":
                    DiceNumberTextScript.diceNumber1 = "FrontSide";
                    break;
                case "SD":
                    DiceNumberTextScript.diceNumber1 = "";
                    break;
                case "SD2":
                    DiceNumberTextScript.diceNumber1 = "";
                    break;
                }
            }
		}
	}   
}
