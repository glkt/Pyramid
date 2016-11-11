using UnityEngine;
using System.Collections;
using UnityEngine.Events;

public class Inputry : MonoBehaviour {
	// Players, Inputs
	//public inputTester my_inputTester;
	public UnityEvent[,] buttons = new UnityEvent[4,5];

	// Use this for initialization
	void Awake () {
		// Initialize the Events

		for (int i = 0; i < buttons.GetLength(0); i++) {
			for (int j = 0; j < buttons.GetLength(1); j++) {
				if (buttons[i,j] == null){
					buttons[i,j] = new UnityEvent();
				}
			}
		}
		//my_inputTester.Asign ();
	}
	
	// Update is called once per frame
	void Update () {
	// Iterate through every Button :/

		//horizontal postive:
		for (int i = 0; i < buttons.GetLength(0); i++) {
			if (Input.GetAxis ("Horizontal_" + (i+1)) > 0 && buttons[i,0] != null) {
				buttons [i, 0].Invoke ();
			}
		}
		//horizontal negative:
		for (int i = 0; i < buttons.GetLength(0); i++) {
			if (Input.GetAxis ("Horizontal_" + (i+1)) < 0 && buttons[i,1] != null) {
				buttons [i, 1].Invoke ();
			}
		}
		//vertical positive:
		for (int i = 0; i < buttons.GetLength(0); i++) {
			if (Input.GetAxis ("Vertical_" + (i+1)) > 0 && buttons[i,2] != null) {
				buttons [i, 2].Invoke ();
			}
		}
		// vertical negative:
		for (int i = 0; i < buttons.GetLength(0); i++) {
			if (Input.GetAxis ("Vertical_" + (i+1)) < 0 && buttons[i,3] != null) {
				buttons [i, 3].Invoke ();
			}
		}
		//button 1:
		for (int i = 0; i < buttons.GetLength(0); i++) {
			if (Input.GetButtonDown ("Set_" + (i+1)) && buttons[i,4] != null) {
				buttons [i, 4].Invoke ();
			}
		}
	}
}
