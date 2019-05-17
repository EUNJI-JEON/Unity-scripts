using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//BaseRotator 상속
public class ZRotator : BaseRotator {

	protected override void Rotate()
	{
		//Z방향으로 회전
		transform.Rotate(0,0,speed*Time.deltaTime);
	}
}
