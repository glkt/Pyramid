using UnityEngine;
using System.Collections;

public class Behavi : MonoBehaviour {

	public int myId = 0;
	public Inputry myInputry;
	public Gridcircus myGridcircus;
	private GameObject currentlyInHand;
	private InventouriDisplay inventory; 		//either a common inventory class, or 1 per player?

	void Start () {
		
		myInputry.buttons [myId, 0].AddListener(Right);
		myInputry.buttons [myId, 1].AddListener(Left);
		myInputry.buttons [myId, 2].AddListener(Up);
		myInputry.buttons [myId, 3].AddListener(Down);
		myInputry.buttons [myId, 4].AddListener(Fire);

		inventory = GetComponent<InventouriDisplay> ();
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
			bool canI = myGridcircus.canTheBlokBePlacedIHave(currentlyInHand.GetComponent<Blokanatomy>());

		} else {

			currentlyInHand = null;

			// hey inventouri, I CLICKED SELECT!
			currentlyInHand = inventory.getObject();

			// connect the blok id with the player id
			currentlyInHand.GetComponent<Blokanatomy>().zugehoergig = myId;

			// get the spawnpoints
			Transform[] Spawnli = GameObject.FindGameObjectWithTag("SpawnPostelein").GetComponentsInChildren<Transform>();
			Vector3 hello = new Vector3 (); 
			Quaternion hillo = new Quaternion ();
			for (int i = 0; i < GGG.peeps; i++) {

				if (Spawnli [i].name == myId.ToString()) {
				
					hello = Spawnli [i].position;
					hillo = Spawnli [i].rotation;
				}
			}

			// and initiate
			Instantiate(currentlyInHand, hello, hillo);
		}
	}
}
