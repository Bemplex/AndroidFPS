using UnityEngine;
using System.Collections;

public class ProtoBullet : MonoBehaviour {

	public float damage;
	public Vector3 initialVelocity;

	Rigidbody rigid;

	void Start()
	{
		rigid = GetComponent<Rigidbody> ();
		rigid.velocity = transform.TransformDirection (initialVelocity);
		Invoke ("DestroyThis", 3.0f);
	}

	void DestroyThis()
	{
		Destroy (this.gameObject);
	}

	void OnCollisionEnter(Collision col)
	{
		col.transform.SendMessage ("TakeDamage", damage, SendMessageOptions.DontRequireReceiver);
	}
}
