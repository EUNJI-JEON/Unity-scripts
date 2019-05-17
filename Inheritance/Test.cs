using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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

		nate.Stealth();
		//animal의 print가져와서 찍으면 nate의 애니멀로서의 정보 찍힘
		nate.Print();

		jack.Hunt();
		jack.Print();
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
