using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Worker : MonoBehaviour {

	Action work;

	void MoveBricks()
	{
		Debug.Log("벽돌을 옮겼다");
	}

	void DigIn()
	{
		Debug.Log("땅을 팠다");
	}
	//delegate work에 할일 몰아넣고
	void Start()
	{
		work += MoveBricks;
		work += DigIn;
	}
	
	// work 발동하는 방식으로 일 처리
	void Update () {
		if(Input.GetKeyDown(KeyCode.Space))
		{
			work();
		}
	}
}
