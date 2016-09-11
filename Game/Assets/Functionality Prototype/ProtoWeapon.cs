using UnityEngine;
using System.Collections;

public class ProtoWeapon : MonoBehaviour {

	public Vector3 inHandPositon;
	public Vector3 bulletInstantiationPosition;

	bool UseLaser;

	public bool useLaser
	{
		get
		{
			return UseLaser;
		}

		set
		{
			laser.gameObject.SetActive (value);
			UseLaser = value;
		}
	}

	public GameObject bulletPrefab;
	LineRenderer laser;

	void Start () 
	{
		laser = transform.GetChild (0).gameObject.GetComponent<LineRenderer>();
		laser.gameObject.SetActive (useLaser);

		transform.localPosition = inHandPositon;
	}

	void Update () 
	{
		if (useLaser)
		{
			laser.SetPosition (0,transform.TransformPoint (new Vector3 (0, 0, 0.5f)));
			laser.SetPosition (1, transform.TransformPoint (new Vector3 (0, 0, 50.5f)));
		}

		if (Input.GetKeyDown (KeyCode.F))
		{
			useLaser = !useLaser;
		}
	}

	void Shoot()
	{
		Instantiate (bulletPrefab, transform.TransformPoint (bulletInstantiationPosition), Quaternion.Euler (this.transform.rotation.eulerAngles + new Vector3 (90, 0, 0)));
	}
}
