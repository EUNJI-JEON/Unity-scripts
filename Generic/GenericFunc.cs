using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenericFunc : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Print<int>(30);
		Print<string>("Hello World");
	}
	
	// Update is called once per frame
	public void Print<T>(T inputMessage)
	{
		Debug.Log(inputMessage);
	}
}
