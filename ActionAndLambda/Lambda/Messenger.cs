using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Messenger : MonoBehaviour {

	public delegate void Send(string reciever);

	Send onSend;

	void Start()
	{
		onSend+=SendMail;
		onSend+=SendMoney;
		//lambda
		onSend += (string man) => { 
			Debug.Log("Kill " + man); 
			Debug.Log("Hide the body"); 
			};
	}

	void Update()
	{
		if(Input.GetKeyDown(KeyCode.Space))
		{
			//receiver:elena
			onSend("Elena");
		}
	}


	void SendMoney(string reciever)
	{
		Debug.Log("Money sent to:" + reciever);
	}

		void SendMail(string reciever)
	{
		Debug.Log("Mail sent to:" + reciever);
	}
}
