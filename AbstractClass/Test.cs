using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//오크와 고블린을 하나의 몬스터 배열로 모음
public class Test : MonoBehaviour {

	public BaseMonster[] monsters;

	void Start()
	{
		for(int i = 0; i<monsters.Length; i++)
		{
			Debug.Log(monsters[i].gameObject.name);
		}
	}
}
