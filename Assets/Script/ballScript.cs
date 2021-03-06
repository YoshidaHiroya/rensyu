﻿using UnityEngine;
using UnityEngine.UI;//UIをいじるときに必要。Text型を認識しなくなってしまう。
public class ballScript : MonoBehaviour
{
	public float speed = 25;
	private GameObject Message;//このスクリプト内でのみ有効なゲームオブジェクトMessageを定義。ここにmessageをいれる。
	AudioSource audiosource;
	Text text ;//Text型の変数textを定義。

	private void Start()
	{
		audiosource = this.GetComponent<AudioSource> ();
		Message= GameObject.Find ("message");//Hierarchyのmessageオブジェクトを探し出し、さっきのmessageにいれる。

		text = Message.GetComponent<Text> ();//Messageはmessageを指しているので、TextをGetComponentし、さっきのtextにいれる。

		var force = new Vector3(1,0,1) * speed;
		this.GetComponent<Rigidbody> ().AddForce (force,ForceMode.VelocityChange);

	}
	private void Update(){
	}

	void OnCollisionEnter(Collision collision){
		audiosource.Play ();
		if (collision.gameObject.tag == "goal1") {
			text.text="Player2の勝ち！";//テキスト型変数の中身を変更する。
		}
		if (collision.gameObject.tag == "goal2") {

			text.text="Player1の勝ち！";
		}

	}
}