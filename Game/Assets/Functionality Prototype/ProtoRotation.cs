using UnityEngine;
using System.Collections;

public class ProtoRotation : MonoBehaviour {

	public float sensitivity;

	void Update()
	{
		float h = Input.GetAxis ("Mouse X");

//		transform.Rotate (0, h * sensitivity, 0);
	}
}
