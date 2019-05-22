using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
public class PlayerHealth : MonoBehaviour {

	//이벤트 기능을 등록할 명단
	public UnityEvent onPlayerDead;
	private void Dead()
	{
		//등록된 이벤트 명단 발동
		onPlayerDead.Invoke();
		Destroy(gameObject);
	}

	void OnTriggerEnter(Collider other)
	{
		Dead();
	}
}
