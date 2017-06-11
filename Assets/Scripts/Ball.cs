using UnityEngine;
using System.Collections;

public class Ball : MonoBehaviour {
	
	void Start ()
	{
		GetComponent<Rigidbody2D>().AddForce(new Vector2(1.5f, 1.5f), ForceMode2D.Impulse);
	}
}
