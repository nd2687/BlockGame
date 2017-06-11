using UnityEngine;
using System.Collections;

public class Judge : MonoBehaviour {
	
	public GameObject success_image = null;
	public GameObject failed_image = null;
	
	public GameObject ball_obj = null;
	public GameObject blocks_obj = null;
	
	private bool is_end = false;
	
	void Update ()
	{
		if (!is_end)
		{
			Time.timeScale = 1.0f;
			
			if (ball_obj.transform.position.y < -1.4f)
			{
				failed_image.SetActive(true);
				is_end = true;
			}
			else if (blocks_obj.GetComponentInChildren<Block>() == null)
			{
				success_image.SetActive(true);
				is_end = true;
			}
		}
		else
		{
			Time.timeScale = 0.0f;
			
			if (Input.anyKeyDown)
			{
				Application.LoadLevel(Application.loadedLevelName);
			}
		}
	}
}
