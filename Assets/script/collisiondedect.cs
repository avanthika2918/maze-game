using UnityEngine;

public class CollisionDetect : MonoBehaviour
{
	void OnCollisionEnter(Collision collision)
	{
		if (collision.gameObject.CompareTag("Enemy"))
		{
			//  Debug.Log("Hit Enemy!");
		}
	}
}
