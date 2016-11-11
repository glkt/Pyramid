using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class Behavi : MonoBehaviour {

	public int myId = 0;
	public Image inventHolder;
	public Blokanatomy currentlyInHand;
	InventouriDisplay inventoryD; //either a common inventory class, or 1 per player?
	public Inputry myInputry;


	void Start () {
		inventoryD = inventHolder.GetComponent<InventouriDisplay> ();
		myInputry.buttons [myId, 0].AddListener(Right);
		myInputry.buttons [myId, 1].AddListener(Left);
		myInputry.buttons [myId, 2].AddListener(Up);
		myInputry.buttons [myId, 3].AddListener(Down);
		myInputry.buttons [myId, 4].AddListener(Fire);
	}
	
	void Update () {
	
	}

	void Left()
	{
		//do we have a block in our hands?
		if (currentlyInHand != null) {
			//then move our block left
		} else {
			//select the previous block in the inventory
		}
	}
	void Right()
	{
		//do we have a block in our hands?
		if (currentlyInHand != null) {
			//move our block right
		} else {
			//select the next block in the inventory
			inventoryD.movePointer("right");
			Debug.Log ("mowed right");
		}
	}
	void Up()
	{
		//do we have a block in our hands?
		if (currentlyInHand != null) {
			//movemovemove
		} else {
			//do nothing i guess?
		}
	}
	void Down()
	{
		//do we have a block in our hands?
		if (currentlyInHand != null) {
			//movemovemove
		} else {
			//do nothing i guess?
		}
	}
	void Rotate()
	{
		if (currentlyInHand != null) {
			//rotate the block ??? lol
		}
			
	}

	void Fire()
	{
		//do we have a block in our hands?
		if (currentlyInHand != null) {
			//then tell the grid we want to place our block here!
		} else {
			//tell the inventory we want a block!
		}
	}

}
