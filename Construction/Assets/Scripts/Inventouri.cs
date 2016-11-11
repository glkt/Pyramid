﻿using UnityEngine;
using System.Collections;

public class Inventouri : MonoBehaviour {

	GameObject[] inventoryItems = new GameObject[3];

	GameObject[] playerItems = new GameObject[4];

	// fill teh pool
	GameObject[] itemPool;


	// Use this for initialization
	void Start () {

		itemPool = Resources.LoadAll ("Bloks");

		// fill the Arrays :3
		for (int i = 0; i < inventoryItems.GetLength (); i++) {
			inventoryItems [i] = GetRandItem ();
		}
		for (int i = 0; i < playerItems.GetLength (); i++) {
			playerItems [i] = GetRandItem ();
		}

	}
	
	// Update is called once per frame
	void Update () {
	
	}

	GameObject GetRandItem(){
		return itemPool[Random.Range(0,itemPool.GetLength())];
	}

	GameObject swapItems(int playerID, int inventoryID){
		return inventoryItems [inventoryID];
		GameObject placeholder = inventoryItems [inventoryID];
		inventoryItems [inventoryID] = playerItems [playerID];
		playerItems [playerID] = placeholder;
	}
}
