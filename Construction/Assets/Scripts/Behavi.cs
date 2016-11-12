using UnityEngine;
using System.Collections;

public class Behavi : MonoBehaviour {

	public int myId = 0;
	public Inputry myInputry;
	public Gridcircus myGridcircus;
	private GameObject currentlyInHand;
	private InventouriDisplay inventory; 		//either a common inventory class, or 1 per player?

	public bool canI;

	void Start () {
		
		myInputry.buttons [myId, 0].AddListener(Right);
		myInputry.buttons [myId, 1].AddListener(Left);
		myInputry.buttons [myId, 2].AddListener(Up);
		myInputry.buttons [myId, 3].AddListener(Down);
		myInputry.buttons [myId, 4].AddListener(Fire);

		inventory = GetComponent<InventouriDisplay> ();
	}
	
	void Update () {
	
		// hey grid, can i place my blok?
		if (currentlyInHand != null)
		{
//			canI = myGridcircus.canTheBlokBePlacedIHave(currentlyInHand.GetComponent<Blokanatomy>());
		//	Debug.Log (canI);			
		}
	}

	void MoveDirection(int MoveX, int MoveY)
	{

		int TempAxis = MoveX;

		if (myId == 1) {
			
			MoveX = -MoveY;
			MoveY = MoveX;

		} else if (myId == 2) {
			
			MoveX = -MoveY;
			MoveY = -MoveX;

		} else if (myId == 3) {

			MoveX = -MoveY;
			MoveY = MoveX;
			
		}

		Vector3 bblu = currentlyInHand.GetComponent<Transform> ().position;

		//at edge of grid?
		if ((bblu.x += MoveX) >= 0 && (bblu.x += MoveX) <= GGG.gridSize) {

			if ((bblu.y += MoveY) >= 0 && (bblu.y += MoveY) <= GGG.gridSize) {

				bblu += new Vector3 (MoveX, MoveY, 0);

				currentlyInHand.GetComponent<Transform> ().position = bblu;

			}
				
		}
	}

	void Left()
	{
		//do we have a block in our hands?
		if (currentlyInHand != null) {
			
			MoveDirection (-1, 0);
		} else {

			inventory.movePointer ("left");
		}
	}
	void Right()
	{
		//do we have a block in our hands?
		if (currentlyInHand != null) {
			//move our block right
			MoveDirection (1, 0);
		} else {

			inventory.movePointer ("right");
		}
	}
	void Up()
	{
		//do we have a block in our hands?
		if (currentlyInHand != null) {
			//movemovemove
			MoveDirection (0, -1);
		} else {
			//do nothing i guess?
		}
	}
	void Down()
	{
		//do we have a block in our hands?
		if (currentlyInHand != null) {
			//movemovemove
			MoveDirection (0, 1);
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

				Debug.Log (myId.ToString ());
				if (Spawnli [i].name == myId.ToString()) {
				
					hello = Spawnli [i].position;
					hillo = Spawnli [i].rotation;
				}
			}

			// and initiate
			if(myGridcircus.canTheBlokBePlacedIHave(currentlyInHand)) { 

				// add to scene
				Instantiate(currentlyInHand, hello, hillo);

				//change the grid
				myGridcircus.changeMyInnerLifeBoi(currentlyInHand);
			}
		}
	}
}
