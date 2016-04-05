using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;

public class Manager : MonoBehaviour {

	public static Color Player1S;
	public static Color Player2S;

	public static float detectRadiusS;

	public Color Player1;
	public Color Player2;
	
	public static List<Collider> allies1S = new List<Collider>();
	public static List<Collider> allies2S = new List<Collider>();

	
	void Update(){
		
		Player1S = Player1;
		Player2S = Player2;		
		
	}
	
}
