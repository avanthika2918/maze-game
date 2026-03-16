using UnityEngine;

public class PlayerAnimation : MonoBehaviour
{
	Animator anim;

	void Start()
	{
		anim = GetComponent<Animator>();
	}

	void Update()
	{
		float h = Input.GetAxis("Horizontal");
		float v = Input.GetAxis("Vertical");

		if (h != 0 || v != 0)
			anim.SetBool("isRunning", true);
		else
			anim.SetBool("isRunning", false);
	}
}
