using UnityEngine;
using System.Collections;
using UnityEngine.UI;
    
public class InventouriDisplay : MonoBehaviour {

	public Inventouri leBigBoss;
	GameObject currObj;
	private int playerID = 0;
	Text[] slots;
	int pointer;

	// Use this for initialization
	void Start () {
		pointer = 0;
		slots = GetComponentsInChildren<Text>();
		for (int i = 0; i < slots.GetLength (0); i++) {
			slots [i].text = leBigBoss.inventoryItems [i].name;
		}
//		slot1.text = leBigBoss.inventoryItems [0].name;
//		slot2.text = leBigBoss.inventoryItems [1].name;
//		slot3.text = leBigBoss.inventoryItems [2].name;

		playerID = this.GetComponent<Behavi> ().myId;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	/**
	public void setPlayerId (int id){
		playerID = id;
	}*/

	public void movePointer(string dir){
		if (dir == "right") {
			slots [pointer].color = Color.black;
			pointer++;
			if (pointer > 2) {
				pointer = 0;
			}
			slots [pointer].color = Color.red;

		}
		if (dir == "left") {
			slots [pointer].color = Color.black;
			pointer--;
			if (pointer < 0) {
				pointer = 2;
			}
			slots [pointer].color = Color.red;
		}
	}

	public GameObject switchItem(){
		return leBigBoss.swapItems (playerID, pointer);
	}

	public void takeItem(){
		leBigBoss.refill (playerID, pointer);
	}

	public GameObject getObject(){
		
		return leBigBoss.playerItems[playerID];
	}
}
