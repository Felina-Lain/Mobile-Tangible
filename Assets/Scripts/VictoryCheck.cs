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
				AlliesAllS.Add(i, _temp);
			}
				
		}
	}
	
	void OnTriggerEnter(Collider col){
		
		int j = NextTurn.turnNum - 1;

		if(col.name == this.name || col.name == "Special" || col.name == "Camps"){

			//print("t" + AlliesAllS[j].Listname);
					
		if (AlliesAllS.ContainsKey (j)) {
				
				AlliesAllS[j].thisAllies.Add (this.GetComponent<Collider>());
				//print("P" + AlliesAllS[j].thisAllies);
				}
		}

		if (col.name == "Camps") {

			CampCounts._inCamps.Add (this.GetComponent<Collider>());
		}
			
			
	}

	// Update is called once per frame
	void Update () {


		
		for (int i = 0; i < Manager.PlayersS.Count; i++) {

			print ("count" + AlliesAllS[i]._count);

			if (AlliesAllS.ContainsKey (i)) {
				
				//foreach (Collider s in AlliesAllS[i].thisAllies) {
				//
				//	if (CampCounts._inCamps.Contains (s)) {
				//	
				//		AlliesAllS[i]._count += 1;
				//	
				//	}
				//}
			}
			//print("P" + AlliesAllS[j].thisAllies);
			if(AlliesAllS[i]._count >= Manager.PlayersS.Count){

				print (" " + Manager.PlayersS [i] + "Win!");

			}
		}
		
	}
}