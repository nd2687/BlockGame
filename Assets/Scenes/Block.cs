using UnityEngine;
using System.Collections;

public class Block : MonoBehaviour {
	
	void OnCollisionEnter2D(Collision2D _col)
	{
		if(_col.gameObject.name == "ball")
		{
			Destroy(gameObject);
		}
	}
}

