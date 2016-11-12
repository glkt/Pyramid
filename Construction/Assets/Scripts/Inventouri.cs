using UnityEngine;
using System.Collections;

public class Inventouri : MonoBehaviour {

	public GameObject[] inventoryItems = new GameObject[3];

	public GameObject[] playerItems = new GameObject[GGG.peeps];

	// fill teh pool
	GameObject[] itemPool;


	// Use this for initialization
	void Awake () {

		itemPool = Resources.LoadAll<GameObject>("Bloks");

		// fill the Arrays :3
		for (int i = 0; i < inventoryItems.GetLength(0); i++) {
			inventoryItems [i] = GetRandItem ();
		}
		for (int i = 0; i < playerItems.GetLength (0); i++) {
			playerItems [i] = GetRandItem ();
		}

	}

	// Update is called once per frame
	void Update () {

	}

	GameObject GetRandItem(){
		
		return itemPool[Random.Range(0,itemPool.GetLength(0))];
	}


	public GameObject swapItems(int playerID, int inventoryID){
		return inventoryItems [inventoryID];						// when return is called, the function ends
		GameObject placeholder = inventoryItems [inventoryID];
		inventoryItems [inventoryID] = playerItems [playerID];
		playerItems [playerID] = placeholder;
	}

	public void refill(int playerID, int inventoryID){
		playerItems [playerID] = inventoryItems [inventoryID];
		inventoryItems [inventoryID] = GetRandItem();
	}
}
