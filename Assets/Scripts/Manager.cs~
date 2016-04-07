using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;

public class Manager : MonoBehaviour {

	public static List<string> PlayersS = new List<string>();
	public List<string> Players = new List<string>();

	public static List<Color> colorListS = new List<Color>();
	public List<Color> colorList = new List<Color>();

	public static string turnsS;
	public string turns;

	public static GameObject playerFabS;
	public static GameObject specialFabS;

	public GameObject playerFab;
	public GameObject specialFab;

	public List<List<Collider>> Listallies = new List<List<Collider>>();

	void Start (){

		Spawn.prefabS = playerFab;

	}


	void Update(){

		playerFabS = playerFab;
		specialFabS = specialFab;
		
		PlayersS = Players;

		colorListS = colorList;

		turns = turnsS;

		for (int i = 0; i < colorListS.Count; i++) {
		
			float newA = 0.3f;
			colorListS [i] = new Color(colorListS [i].r, colorListS [i].g, colorListS [i].b, newA);
		
		}

	}
	
}
