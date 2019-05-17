using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//인터페이스의 경우 Attack이 껍데기의 기능만 하도록 내부 구현 안함. 상속받는 다른 클래스들이 이 Attack 함수를 알아서 구현해서 사용하도록 함. 추상클래스는 좀 다름. 
//공통적으로 추상클래스도 이 baseMonster를 상속받으면 무조건 Attack을 갖고 있음. 
//그런데 추상클래스는 껍데기가 아닌 애들도 갖고 있음. 껍데기+껍데기 아닌 걸로 구성. 그래서 실시간으로 찍어내진 못함. 껍데기가 아닌 애들도 있기 때문에. 
//즉 BaseMonster는 자신을 상속받는 자식들이 Attack을 강제로 구현하도록 하고(필요한 부분만 오버라이드) Update를 따로 작성하지 않고도 작동되도록 미리 Update를 구현해뒀음. 
//damage,update같은 내부구현을 클래스 안에 할 수 있다는 게 추상클래스의 특징(인터페이스와의 차이)
public abstract class BaseMonster : MonoBehaviour {
	public float damage = 100f;
	// Use this for initialization
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.Space))
		{
			Attack();
		}
	}

	public abstract void Attack()
	{

	}

}
