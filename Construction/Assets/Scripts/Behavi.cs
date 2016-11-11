using UnityEngine;
using System.Collections;

public class Behavi : MonoBehaviour {

	public int myId = 0;
	public Inputry myInputry;
	public Blokanatomy currentlyInHand;
	public Gridcircus myGridcircus;
	public Inventouri inventory; //either a common inventory class, or 1 per player?

	void Start () {
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

			// hey grid, can i place my blok?
			bool canI = myGridcircus.canTheBlokBePlacedIHave(currentlyInHand);

		} else {

			// hey inventouri, I CLICKED SELECT!
			Inventouri.someFancyFunction(myId);

			// connect the blok id with the player id
			currentlyInHand.zugehoergig = myId;
		}
	}

}
