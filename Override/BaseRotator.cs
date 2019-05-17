using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseRotator : MonoBehaviour {

	public float speed=60f;

	void Update()
	{
		Rotate();
	}

	
	protected virtual void Rotate()
	{
		//x방향으로 speed만큼 회전. 즉, x축을 기준으로 1초에 60도 회전
		//만약 y,z축을 기준으로도 회전하게 하려면 yRotator,zRotator 등 여러종류의 로테이터 만들어야함. 회전하는 것 자체는 baseRotator라고 부를 수 있음 그런데 회전이 어떻게 이루어지는지는 baseRotator 밑에서 알아서 각자 구현하면 어떨까? 즉 baseRotator는 Update함수 안에서 Rotate()를 받아서 회전을 시킴. 단, 그 회전이 어떻게 이뤄지는 지는 부모 클래스 입장에서 먼저 정해놓지 않는 거. 즉 부모 클래스인 baseRotator는 회전만 하는 거. 단 그 회전이 어떻게 구현되는지는 각각의 자식들이 알아서 하는 거. baseRotator는 하나뿐이고 얘를 상속받는 애들이 알아서 rotate 함수의 내부 구현을 해서 덮어 씌우는 거. 이를 위해 virtual 사용. 함수 앞에 virtual 붙이면 자식들이 해당 함수를 덮어씌울 수 있다는 의미. 가상으로 존재해서 자식들이 덮어씌울 수 있다는 의미. 만약 덮어씌우지 않으면 기본값으로 rotate함수 안에 들어있는 코드가 구현됨.
		transform.Rotate(speed*Time.deltaTime,0,0);
	}
	
}
