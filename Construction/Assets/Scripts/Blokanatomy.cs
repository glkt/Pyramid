﻿using UnityEngine;
using System.Collections;

public class Blokanatomy : MonoBehaviour {

	// dimensions of existence
	public bool[,,] koerper;

	// name for finding in enzyklopedia
	// public string namae = this.name;

	// 0 = player1, 1 = player2, 2 = player3, 3 = player4
	public int zugehoergig;

	void Start () {

		koerper = Enzyklopedia.instance.peter [name];
	}
	
	// Update is called once per frame
	void Update () {

		Debug.Log (koerper);
	}
}
