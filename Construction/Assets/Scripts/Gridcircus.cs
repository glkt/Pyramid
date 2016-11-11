using UnityEngine;
using System.Collections;

public class Gridcircus : MonoBehaviour {

	public int gridMaxUnits = 9;
	public int gridSize = 1;

	void Start () {
	

	}
	
	void Update () {




		//Drawing the invisible grid 
		for (int i = 0; i <= 9; i++) {

			Debug.DrawLine (new Vector3 (i * gridSize, 0, 0), new Vector3 (i * gridSize, 0, gridMaxUnits * gridSize), Color.red);
			Debug.DrawLine (new Vector3 (0, 0, i * gridSize), new Vector3 (gridMaxUnits * gridSize, 0, i * gridSize), Color.red);
			Debug.DrawLine (new Vector3 (i * gridSize, 0, 0), new Vector3 (i * gridSize, gridMaxUnits * gridSize, 0), Color.red);
			Debug.DrawLine (new Vector3 (0, 0, i * gridSize), new Vector3 (0, gridMaxUnits * gridSize, i * gridSize), Color.red);
		}

	}
}
