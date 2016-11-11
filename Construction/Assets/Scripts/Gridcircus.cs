using UnityEngine;
using System.Collections;

public class Gridcircus : MonoBehaviour {
	
	public int gridMaxUnits = 9;
	public int gridSize = 1;
	private int currentLayer;
	private bool[,,] tehOneAndOnly;

	void Start () 
	{
		currentLayer = new int(0);

		// initiate the grid
		tehOneAndOnly = new bool[gridMaxUnits, gridMaxUnits, gridMaxUnits];
		for (int i = 0; i < gridMaxUnits; i++) 
		{
			for (int j = 0; i < gridMaxUnits; j++) 
			{
				for (int k = 0; i < gridMaxUnits; k++) 
				{
					tehOneAndOnly [i, j, k] = false;
				}
			}
		}
	}
	
	void Update () 
	{

		/**
		//Drawing the invisible grid 
		for (int i = 0; i <= 9; i++) {

			Debug.DrawLine (new Vector3 (i * gridSize, 0, 0), new Vector3 (i * gridSize, 0, gridMaxUnits * gridSize), Color.red);
			Debug.DrawLine (new Vector3 (0, 0, i * gridSize), new Vector3 (gridMaxUnits * gridSize, 0, i * gridSize), Color.red);
			Debug.DrawLine (new Vector3 (i * gridSize, 0, 0), new Vector3 (i * gridSize, gridMaxUnits * gridSize, 0), Color.red);
			Debug.DrawLine (new Vector3 (0, 0, i * gridSize), new Vector3 (0, gridMaxUnits * gridSize, i * gridSize), Color.red);
		}
		*/
	}

	// check for already placed bloks
	public bool canTheBlokBePlacedIHave(Blokanatomy ana) 
	{
		bool[,,] holga = ana.koerper;
	}

	// i need some refreshment in my inner blok placement
	private void changeMyInnerLifeBoi(Blokanatomy cool)
	{
		// get the value of the blok
		bool[,,] changeOfmyLife = cool.koerper;
		// get it's position
		Vector3 positionOfMychange = cool.GetComponentInParent<Transform> ().position;
	}
}
