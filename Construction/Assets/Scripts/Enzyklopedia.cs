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

		// simple blocks one size

		bool[,,] block_01 = new bool[3, 1, 3];
		fillTrue(block_01);
		peter.Add ("block_01", block_01);

		bool[,,] block_02 = new bool[1, 3, 1];
		fillTrue(block_02);
		peter.Add ("block_02", block_02);

		bool[,,] block_03 = new bool[2, 3, 2];
		fillTrue(block_03);
		peter.Add ("block_03", block_03);

		//pillars

		bool[,,] pillar_01 = new bool[1, 2, 1];
		fillTrue(pillar_01);
		peter.Add ("pillar_01", pillar_01);

		bool[,,] pillar_02 = new bool[1, 3, 1];
		fillTrue(pillar_02);
		peter.Add ("pillar_02", pillar_02);

		bool[,,] pillar_03 = new bool[1, 3, 1];
		fillTrue(pillar_03);
		peter.Add ("pillar_03", pillar_03);

		bool[,,] pillar_04 = new bool[1, 3, 1];
		fillTrue(pillar_04);
		peter.Add ("pillar_04", pillar_04);

		// pools

		bool[,,] pool_01 = new bool[3, 1, 3];
		fillTrue(pool_01);
		peter.Add ("pool_01", pool_01);

		bool[,,] pool_02 = new bool[3, 1, 3];		
		fillTrue(pool_02);
		peter.Add ("pool_02", pool_02);

		bool[,,] pool_03 = new bool[3, 1, 4];
		pool_03[0,1,0] = false;
		pool_03[0,1,3] = false;
		pool_03[2,1,0] = false;
		pool_03[2,1,3] = false;
		fillTrue(pool_03);
		peter.Add ("pool_03", pool_03);

		// statue

		bool[,,] statue = new bool[2, 3, 1];		
		fillTrue(statue);
		peter.Add ("statue", statue);

		// trees 

		bool[,,] tree_01 = new bool[1, 3, 1];		
		fillTrue(tree_01);
		peter.Add ("tree_01", tree_01);

		bool[,,] tree_02 = new bool[1, 1, 1];		
		fillTrue(tree_02);
		peter.Add ("tree_02", tree_02);

		bool[,,] tree_03 = new bool[1, 2, 1];		
		fillTrue(tree_03);
		peter.Add ("tree_03", tree_03);

		bool[,,] tree_04 = new bool[1, 3, 1];		
		fillTrue(tree_04);
		peter.Add ("tree_04", tree_04);

		bool[,,] tree_05 = new bool[1, 2, 1];		
		fillTrue(tree_05);
		peter.Add ("tree_05", tree_05);

		bool[,,] tree_06 = new bool[1, 3, 1];		
		fillTrue(tree_06);
		peter.Add ("tree_06", tree_06);

		// walls

		bool[,,] wall_01 = new bool[2, 3, 1];		
		fillTrue(wall_01);
		peter.Add ("wall_01", wall_01);

		bool[,,] wall_02 = new bool[1, 1, 3];		
		fillTrue(wall_02);
		peter.Add ("wall_02", wall_02);

		bool[,,] wall_03 = new bool[2, 3, 2];		
		fillTrue(wall_03);
		peter.Add ("wall_03", wall_03);

		bool[,,] wall_04 = new bool[3, 3, 1];		
		fillTrue(wall_04);
		peter.Add ("wall_04", wall_04);
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
