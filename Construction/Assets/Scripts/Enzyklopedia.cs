using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Enzyklopedia:MonoBehaviour {

	// to not have to search all over the place
	public static Enzyklopedia instance;

	// all pretty names gathered in one pretty place, hi peter
	public Dictionary<string,bool[,,]> peter = new Dictionary<string,bool[,,]>();

	void Awake()
	{
		instance = this;

		bool[,,] firsty = new bool[1, 1, 1];
		firsty [0, 0, 0] = true;
		peter.Add ("firsty", firsty);

		bool[,,] secondy = new bool[1, 2, 1];
		secondy [0, 0, 0] = true;
		secondy [0, 1, 0] = true;
		peter.Add ("secondy", secondy);

		bool[,,] thirdy = new bool[2, 1, 2];
		thirdy [0, 0, 0] = true;
		thirdy [1, 0, 0] = true;
		thirdy [0, 0, 1] = true;
		thirdy [1, 0, 1] = true;
		peter.Add ("thirdy", thirdy);
	}

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
