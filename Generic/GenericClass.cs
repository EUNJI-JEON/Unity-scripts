using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenericClass : MonoBehaviour {


	void Start()
	{
		//<>안에 쓰려는 타입 넣어서 사용하면 됨
		Container<string> container = new Container<string>();
		container.messages = new string[3];

		container.messages[0]="Hello";
		container.messages[1]="world";
		container.messages[2]="Hi";

		for(int i=0;i<container.messages.Length; i++)
		{
			Debug.Log(container.messages[i]);
		}

		Container<int> container = new Container<int>();
		container.messages = new int[3];

		container.messages[0]=0;
		container.messages[1]=1;
		container.messages[2]=2;

		for(int i=0;i<container.messages.Length; i++)
		{
			Debug.Log(container.messages[i]);
		}
	public class Container<T>
	{
		public T[] messages;
	}
}
