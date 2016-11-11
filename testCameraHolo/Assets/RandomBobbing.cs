using UnityEngine;
using System.Collections;

public class RandomBobbing : MonoBehaviour {

	public float maxYTranslation;
	public float maxYRotation;
	public float maxPlaneRotation;
	public float yTranslationSpeed;
	public float yRotationSpeed;
	public float planeRotationSpeed;

	float offsetYTranslation = 0.0f;
	float offsetYRotation = 0.0f;
	float offsetPlaneRotation = 0.0f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 currentPosition = transform.position;
		Vector3 currentRotation = transform.rotation.eulerAngles;

		offsetYTranslation += yTranslationSpeed * Time.deltaTime;
		offsetYRotation += yRotationSpeed * Time.deltaTime;
		offsetPlaneRotation += planeRotationSpeed * Time.deltaTime;

		float yTranslation = Mathf.PerlinNoise(offsetYTranslation, 0.0f) * maxYTranslation;
		currentPosition.y = yTranslation;
		transform.position = currentPosition;

		float yRotation = Mathf.PerlinNoise(offsetYRotation, 10.0f) * maxYRotation - (maxYRotation / 2.0f);
		float xRotation = Mathf.PerlinNoise(offsetPlaneRotation, 20.0f) * maxPlaneRotation - (maxPlaneRotation / 2.0f);
		float zRotation = Mathf.PerlinNoise(offsetPlaneRotation, 30.0f) * maxPlaneRotation - (maxPlaneRotation / 2.0f);
		transform.eulerAngles = new Vector3(xRotation, yRotation, zRotation);
	}
}
