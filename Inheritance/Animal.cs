using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animal {
	public string name;
	public float weight;
	public int year;
	public void Print()
	{
		Debug.Log(name+ "| 몸무게: " +weight + "| 나이: " +year);
	}

	//부모 클래스인 animal에 있는 public 변수들을 자식클래스만 쓸 수 있도록 하되 바깥에선 못쓰게 하고 싶음. 그럴 때 쓰는게 protected라는 접근자임. protected는 바깥에선 안보이는데 자식클래스들은 볼 수 있어서 가져다 쓸 수 있음. 
	//이렇게 protected를 써서 바깥으로부터 코드를 숨기면 간단하게 보임. 컴퓨터 속도 향상과는 거리가 멂.
	protected float GetSpeed()
	{
		return CalcSpeed();
	}

	//부모 클래스가 자식 내에 존재하는데 이걸 쓸 수 있는지 없는지를 정할 수 있음.
	//이를테면 부모 클래스에서 GetSpeed를 자식클래스가 갖고와서 쓰긴 하는데 GetSpeed가 어떻게 계산되는지는 숨기는 거. 왜냐면 자식 클래스는 부모 클래스가 제공하는 기능을 가져다 쓰기만 하면 되지 갖다 쓰는 코드가 어떻게 동작하는지는 알 필요가 없기 때문. 이렇게하면 코드가 간단해짐. Animal에 CalcSpeed라는 새로운 함수 만들어주고 GetSpeed는 아래처럼 바꿔줌. private으로 만드는데 부모클래스에서 private인 함수와 변수는 자식 클래스에서 보이지 않음. 
	private float CalcSpeed()
	{
		return 100f/(weight*year);
	}

}
//:Animal이라고 해주면 Dog은 Animal에 있는 코드를 미리 바닥에 깔고 가진 상태에서 그 위에 덧붙여서 코드 작성
//즉, dog은 이미 animal의 모든 기능을 가진 채로 시작. 이게 바로 :Monobehavior를 덧붙이는 의미
public class Dog :Animal
{
	public void Hunt()
	{
		//animal안에 GetSpeed가 만들어져있기 때문에 이렇게 갖다 쓰면 됨.
		float speed = GetSpeed();
		Debug.Log(speed + "의 속도로 달려가서 사냥했다.");

		//사냥 후 먹어서 몸무게 증가
		weight = weight + 10f;
	}
}

public class Cat: Animal{
	public void Stealth()
	{
		Debug.Log("숨었다");
	}
}
