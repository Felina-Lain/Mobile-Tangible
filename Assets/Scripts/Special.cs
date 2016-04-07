using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;

public class Special : MonoBehaviour {

	public static List<bool> canSpecialS = new List<bool>();
	public List<bool> canSpecial = new List<bool>();

	public int _counter;

	public static bool _On;

	// Use this for initialization
	void Start () {
	
		canSpecialS.Clear();
		_counter = 0;
		_On = false;

	}

	void Update(){

		canSpecial = canSpecialS;


		if (_counter < Manager.PlayersS.Count) {
			
			canSpecialS.Add (true);
			_counter += 1;
		
		}

	}


	public void SpecialPawn (){

		_On = true;

		for (int i = 0; i < Manager.PlayersS.Count; i++) {

			if (Manager.PlayersS [i] == Manager.turnsS) {
				
				if (canSpecialS [i] == true) {

					if (_On) {						
						Spawn.prefabS = Manager.specialFabS;
					} 

				}
			}
		}
	}
}
