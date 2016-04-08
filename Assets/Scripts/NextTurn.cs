using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;

public class NextTurn : MonoBehaviour {

	public Text buttonTurn;

	public static int turnNum;

	public int _turnNum;

	public int tmp;

	void Start (){

		turnNum = 0;

	}

	void Update(){

		_turnNum = turnNum;
		tmp = turnNum + 1;
		buttonTurn.text = "Player" + tmp as string;
		Manager.turnsS = "Player" + tmp as string;

		if (turnNum == Manager.PlayersS.Count) {
			
			turnNum = 0;


		}
	}
		
}
