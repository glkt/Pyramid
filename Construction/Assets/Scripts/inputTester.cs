using UnityEngine;
using System.Collections;
using UnityEngine.Events;

public class inputTester : MonoBehaviour {
	public Inputry my_Inputry;
	// Use this for initialization
	void Start () {
		Asign ();
	}

	//assígnButtons
	public void Asign(){
		my_Inputry.buttons [0, 0].AddListener (goRight);
		my_Inputry.buttons [0, 1].AddListener (goLeft);
		my_Inputry.buttons [0, 2].AddListener (goUp);
		my_Inputry.buttons [0, 3].AddListener (goDown);
		my_Inputry.buttons [0, 4].AddListener (button);
	}
	
	// Update is called once per frame
	void Update () {

	}

	void goRight(){
		//doThis;
		Debug.Log("right");
	}
	void goLeft(){
		//doThis;
		Debug.Log("left");
	}
	void goUp(){
		//doThis;
		Debug.Log("up");
	}
	void goDown(){
		//doThis;
		Debug.Log("down");
	}
	void button(){
		//doThis;
		Debug.Log("b1");
	}

}
