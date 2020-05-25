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
           

            if(col.gameObject.tag == "DIR"){ 
           
                switch (col.gameObject.name) {
                case "FrontSide":
                    DiceNumberTextScript2.diceNumber = "BackSide";
                    break;
                case "FrontSide2":
                    DiceNumberTextScript2.diceNumber = "BackSide";
                    break;
                case "BackSide":
                    DiceNumberTextScript2.diceNumber = "FrontSide";
                    break;
                case "BackSide2":
                    DiceNumberTextScript2.diceNumber = "FrontSide";
                    break;
                case "SD":
                    DiceNumberTextScript2.diceNumber = "";
                    break;
                case "SD2":
                    DiceNumberTextScript2.diceNumber = "";
                    break;
                }
            }

            if(col.gameObject.tag == "SPINS"){ 
           
                switch (col.gameObject.name) {
                case "180":
                    DiceNumberTextScript3.diceNumber = "180";
                    break;
                case "1802":
                    DiceNumberTextScript3.diceNumber = "180";
                    break;
                case "360":
                    DiceNumberTextScript3.diceNumber = "360";
                    break;
                case "3602":
                    DiceNumberTextScript3.diceNumber = "360";
                    break;
                case "SD":
                    DiceNumberTextScript3.diceNumber = "";
                    break;
                case "SD2":
                    DiceNumberTextScript3.diceNumber = "";
                    break;
                }
            }

            if(col.gameObject.tag == "JUMP"){ 
           
                switch (col.gameObject.name) {
                case "Ollie":
                    DiceNumberTextScript4.diceNumber = "Switch";
                    break;
                case "Fakie":
                    DiceNumberTextScript4.diceNumber = "Nollie";
                    break;
                case "Switch":
                    DiceNumberTextScript4.diceNumber = "Ollie";
                    break;
                case "Nollie":
                    DiceNumberTextScript4.diceNumber = "Fakie";
                    break;
                case "SD":
                    DiceNumberTextScript4.diceNumber = "";
                    break;
                case "SD2":
                    DiceNumberTextScript4.diceNumber = "";
                    break;
                }
            }
		}
	}
   
}
