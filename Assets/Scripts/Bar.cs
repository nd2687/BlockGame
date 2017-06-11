using UnityEngine;
using System.Collections;

public class Bar : MonoBehaviour {
	
	public float speed = 0.04f;
	
	void Update ()
	{
		if (Input.GetKey(KeyCode.LeftArrow))
		{
			if (-0.5f < transform.position.x)
			{
				transform.position -= new Vector3(speed, 0.0f);
			}
			else
			{
				transform.position = new Vector3(-0.5f, transform.position.y);
			}
		}
		else if (Input.GetKey(KeyCode.RightArrow))
		{
			if (0.5f > transform.position.x)
			{
				transform.position += new Vector3(speed, 0.0f);
			}
			else
			{
				transform.position = new Vector3(0.5f, transform.position.y);
			}
		}
	}
}


