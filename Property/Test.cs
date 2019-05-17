using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour {
	public PointManager pointManager;

	void Start()
	{
		//point 변수를 사용했지만 point 변수 내부의 set처리가 동작함.
		pointManager.point= 100;
		Debug.Log("현재 점수:"+pointManager.point);

		pointManager.point= -100;
		Debug.Log("현재 점수:"+pointManager.point);

		Debug.Log(MonsterManager.count);
		
	}
}
