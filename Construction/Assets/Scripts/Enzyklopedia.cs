using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Enzyklopedia:MonoBehaviour {

	public bool printEnzyclopedia = true;

	// to not have to search all over the place
	public static Enzyklopedia instance;

	// all pretty names gathered in one pretty place, hi peter
	public Dictionary<string,bool[,,]> peter = new Dictionary<string,bool[,,]>();

	void Awake()
	{
		instance = this;

		bool[,,] block_01 = new bool[3, 1, 3];
		fillTrue(block_01);
		peter.Add ("block_01", block_01);

		bool[,,] block_02 = new bool[1, 3, 1];
		fillTrue(block_02);
		peter.Add ("block_02", block_02);

		bool[,,] block_03 = new bool[2, 3, 2];
		fillTrue(block_03);
		peter.Add ("block_03", block_03);
	}

	void Start () {

		// print all dictionnary if wanted
		if(printEnzyclopedia){
			LogEnzyclopedia();
		}

	}
	
	// Update is called once per frame
	void Update () {
	
	}

	// fill the whole array with "true" values
	void fillTrue( bool[,,] arr){
		int i = 0;
		int j = 0;
		int k = 0;
		for(i = 0; i< arr.GetLength(0); i++){
			for(j = 0; j< arr.GetLength(1); j++){
				for(k = 0; k< arr.GetLength(2); k++){
					arr[i,j,k] = true;
				}
			}
		}
	}

	void LogEnzyclopedia(){ // print all dictionnary to be sure		

		foreach(KeyValuePair<string,bool[,,]> keyValue in peter)
        {
        	string debugLine ="";
            debugLine += keyValue.Key;
            debugLine += ":";
            bool[,,] val = keyValue.Value;
            for(int i = 0; i< val.GetLength(0); i++){
            	debugLine += " [";
				for(int j = 0; j< val.GetLength(2); j++){
					debugLine += "(";
					for(int k = 0; k< val.GetLength(1); k++){
						if( val[i,k,j] ){
							debugLine += "1,";
						}else{
							debugLine += "0,";
						}
					}
					debugLine += ") ";
				}
				debugLine += "] ";
			}
			Debug.Log(debugLine);
		}
	}

}
