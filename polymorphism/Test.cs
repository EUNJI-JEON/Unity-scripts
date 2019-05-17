using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//보통은 :Monobehavior를 꼭 붙여서 사용하는데 :Monobehavior는 유니티가 제공하는 컴포넌트,편의 기능들이 들어있음. 
//:Monobehavior를 상속을 받아 붙여줌으로서 :Monobehavior안에 들어있는  GetComponent같은 함수를 쓸 수 있는 거. 
//그래서 :Monobehavior를 붙여준 경우는 부품으로서 작동하기 때문에 Main camera나 다른 오브젝트들에 붙여줄 수가 있음.
public class Test : MonoBehaviour {

	// Use this for initialization
	void Start () {

		Cat nate = new Cat();
		nate.name = "Nate";
		nate.weight = 1.5f;
		nate.year = 3;


		Dog jack = new Dog();
		jack.name = "Jack";
		jack.weight = 5f;
		jack.year = 2;


		Animal[] animals = new Animal[2];
		animals[0]=nate;//고양이
		animals[1]=jack;//개

		//animal로서 공통되는 print() 기능을 한 번에 쓸 수 있음. 이게 다형성의 특징.
		//단, dog,cat 각각의 고유한 hunt,stealth 기능은 사용할 수 없음.
		for(int i = 0; i<animals.Length; i++)
		{
			animals[i].Print();
		}

		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
