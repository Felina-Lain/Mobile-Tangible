﻿using UnityEngine;
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

	void Update(){
		
		PlayersS = Players;

		colorListS = colorList;

		turnsS = turns;
		
	}
	
}
