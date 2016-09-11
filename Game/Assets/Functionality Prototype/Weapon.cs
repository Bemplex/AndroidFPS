using UnityEngine;
using System.Collections;

public abstract class Weapon : MonoBehaviour {

	public Vector3 inHandPositon;
	public Vector3 bulletInstantiationPosition;

	void Start () {
	
	}
	
	void Update () {
	
	}

	public abstract void Shoot ();
}
