using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;

public class VictoryCheck : MonoBehaviour {

	public static Dictionary<int, PlayerClass> AlliesAllS = new Dictionary<int, PlayerClass>();

	void Start(){

		for (int i = 0; i < Manager.PlayersS.Count; i++) {

			if (!AlliesAllS.ContainsKey(i)){
				List<Collider> tmplist = new List<Collider>();
				int k = i + 1;
				PlayerClass _temp = new PlayerClass("Player" + k as string, tmplist);
				AlliesAllS.Add(i, _temp);}
		}

	}
	
	void OnTriggerEnter(Collider col){
		
		int j = NextTurn.turnNum - 1;

		if(col.name == this.name || col.name == "Special"){

			//print("t" + AlliesAllS[j].Listname);
					
		if (AlliesAllS.ContainsKey (j)) {
				
			AlliesAllS[j].thisAllies.Add (col);
				print("P" + AlliesAllS[j].thisAllies);
				}
		}
	}
}