using UnityEngine;

public class ballScript : MonoBehaviour
{
	public float speed = 25;

	private void Start()
	{
		var force = (transform.right + transform.forward) * speed;
		this.GetComponent<Rigidbody> ().AddForce (force,ForceMode.VelocityChange);
	}
	private void Update(){
	}

}