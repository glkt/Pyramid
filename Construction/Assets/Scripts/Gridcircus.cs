using UnityEngine;
using System.Collections;

public class Gridcircus : MonoBehaviour {
	
	private int currentLayer;
	private bool[,,] tehOneAndOnly;

	void Start () 
	{
		currentLayer = 0;

		// initiate the grid
		tehOneAndOnly = new bool[GGG.gridMaxUnits, GGG.gridMaxUnits, GGG.gridMaxUnits];
		for (int i = 0; i < GGG.gridMaxUnits; i++) 
		{
			for (int j = 0; j < GGG.gridMaxUnits; j++) 
			{
				for (int k = 0; k < GGG.gridMaxUnits; k++) 
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

	// check for already placed bloks with a blok in selection
	public bool canTheBlokBePlacedIHave(GameObject ana) 
	{
		// get the grid of the blok
		bool[,,] holga = Enzyklopedia.instance.peter [ana.tag];

		// get it's position
		Vector3 positionOfHolga = ana.GetComponent<Transform>().position;

		// get the boolhool
		for (int i = 0; i < holga.GetLength (0); i++)
		{
			for (int j = 0; j < holga.GetLength (1); j++) 
			{
				for (int k = 0; k < holga.GetLength (2); k++) 
				{
					if (tehOneAndOnly [Mathf.RoundToInt(positionOfHolga.x) + i, 
						Mathf.RoundToInt(positionOfHolga.y) + j, 
						Mathf.RoundToInt(positionOfHolga.z) + k] == true) {
						
						if (holga [i, j, k] != false) {
							
							return false;
						}
					}
				}
			}
		}

		return true;
	}

	// i need some refreshment in my inner blok placement
	private void changeMyInnerLifeBoi(Blokanatomy cool)
	{
		// get the value of the blok
		bool[,,] changeOfmyLife = cool.koerper;

		// get it's position
		Vector3 positionOfMychange = cool.GetComponent<Transform> ().position;

		// change the position
		for (int i = 0; i < changeOfmyLife.GetLength (0); i++)
		{
			for (int j = 0; j < changeOfmyLife.GetLength (1); j++) 
			{
				for (int k = 0; k < changeOfmyLife.GetLength (2); k++) 
				{
					if (tehOneAndOnly [Mathf.RoundToInt(positionOfMychange.x) + i, 
						Mathf.RoundToInt(positionOfMychange.y) + j,
						Mathf.RoundToInt(positionOfMychange.z) + k] == false) {

						tehOneAndOnly [Mathf.RoundToInt(positionOfMychange.x) + i, 
						Mathf.RoundToInt(positionOfMychange.y) + j, 
						Mathf.RoundToInt(positionOfMychange.z) + k] = changeOfmyLife [i, j, k];
					}
				}
			}
		}
	}
}
