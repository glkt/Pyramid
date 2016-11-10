#pragma strict


var turn : float = 0.1; 

function Start () {

}

function Update () {
	transform.localEulerAngles.y = turn * Time.time;
}