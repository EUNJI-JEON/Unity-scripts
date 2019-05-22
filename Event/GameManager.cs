using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {


	public void OnPlayerDead()
	{
		//Invoke("함수이름",시간)는 괄호 안에 함수 이름 넣고 지연시간 넣으면 지연 시간 흐른 후에 함수가 발동됨.
		Invoke("Restart",5f);
	}
	private void Restart()
	{
		SceneManager.LoadScene(0);
	}

}
