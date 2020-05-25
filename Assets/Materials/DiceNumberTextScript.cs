using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Text.RegularExpressions;


public class DiceNumberTextScript : MonoBehaviour {

	public Text text;
	public static string diceNumber;  //FLIPS
	public static string diceNumber1; //DIR
	public static string diceNumber2; //SPINS
	public static string diceNumber3; //JUMP

	// Use this for initialization
	void Start () {
		text = GetComponent<Text> ();
	}
	
	// Update is called once per frame
	void Update () {
		
		string textfin = diceNumber3+","+diceNumber+","+diceNumber2+","+diceNumber1;
		textfin = textfin.Replace(",", " ");
		textfin = textfin.Replace("  "," ");
		text.text = textfin;
	}
}
