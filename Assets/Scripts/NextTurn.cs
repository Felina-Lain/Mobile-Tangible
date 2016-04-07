using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;

public class NextTurn : MonoBehaviour {

	public Text buttonTurn;

	public int turnNum;

	void Start (){

		turnNum = 1;
		Manager.turnsS = "Player" + turnNum as string;
		buttonTurn.text = "Player" + turnNum as string;

	}

	// Update is called once per frame
	public void ChangeTurn () {

		turnNum += 1;

		Manager.turnsS = "Player" + turnNum as string;
	
		if (turnNum > Manager.PlayersS.Count) {
		
			ResertTurns ();
		
		}

		buttonTurn.text = "Player" + turnNum as string;
	}

	public void ResertTurns () {
	
		turnNum = 1;
		Manager.turnsS = "Player" + turnNum as string;
		buttonTurn.text = "Player" + turnNum as string;
	
	}
}
