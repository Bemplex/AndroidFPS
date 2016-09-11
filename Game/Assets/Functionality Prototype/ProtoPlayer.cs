using UnityEngine;
using System.Collections;
using UnityStandardAssets.CrossPlatformInput;

public class ProtoPlayer : MonoBehaviour {

	public float movementSpeed;
	public float rotationSpeed;

	float movementDamping = 0.001f;
	float rotationDamping = 0.001f;

	CharacterController controller;
	ProtoWeapon weapon;



	void Start () 
	{
		controller = GetComponent<CharacterController> ();
		weapon = GetComponentInChildren<ProtoWeapon> ();
	}
	
	void FixedUpdate () 
	{
		Move ();
		Rotate ();
	}

	void Shoot()
	{
		weapon.SendMessage ("Shoot");
	}


	void Move()
	{
		Vector3 movementVector = transform.forward * CrossPlatformInputManager.GetAxis ("Vertical") * movementSpeed * movementDamping;

		controller.Move (movementVector);
	}

	void Rotate()
	{
		transform.Rotate (0, CrossPlatformInputManager.GetAxis("Horizontal")*rotationSpeed, 0);
	}
}
