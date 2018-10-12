using UnityEngine;
using UnityEngine.UI;
public class ballScript : MonoBehaviour
{
	public float speed = 25;
	private GameObject Message;
	Text text ;

	private void Start()
	{
		Message= GameObject.Find ("message");
		text = Message.GetComponent<Text> ();
		var force = (transform.right + transform.forward) * speed;
		this.GetComponent<Rigidbody> ().AddForce (force,ForceMode.VelocityChange);

	}
	private void Update(){
	}

	void OnCollisionEnter(Collision collision){
		if (collision.gameObject.tag == "goal1") {
			text.text="Player2の勝ち！";
		}
		if (collision.gameObject.tag == "goal2") {

			text.text="Player1の勝ち！";
		}
	}
}