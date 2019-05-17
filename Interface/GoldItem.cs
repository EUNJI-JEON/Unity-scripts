using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//IItem 상속
public class withoutInterface : MonoBehaviour, IItem {

	public int goldAmount = 100;


	//인터페이스를 상속받는 애들은 무조건 인터페이스가 강제하는 함수를 만들어야함. 이 경우 IItem을 상속받으려면 무조건 Use함수를 갖고있어야함. 안그럼 오류남.
	public void Use()
	{
		Debug.Log("골드 득템");
		Player player = FindObjectOfType<Player>();
		player.gold += goldAmount;

		gameObject.SetActive(false);
	}
}
