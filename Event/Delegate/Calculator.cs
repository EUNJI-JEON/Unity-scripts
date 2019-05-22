using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Calculator : MonoBehaviour {

	//delegate type: 입력을 두 개 받고(float a,float b) 출력을 float형태로 하는 대행 함수 Calculate
	delegate float Calculate(float a, float b);
	//delegate object
	Calculate onCalculate;

	void Start()
	{
		//Sum 함수를 delegate 명부에 등록하는 것이므로 ()괄호를 붙이지 않음. 직접 발동시킬 땐 Sum();이렇게 괄호를 붙여주는 게 맞지만 이 경우엔 delegate에 등록하는 것이므로 괄호 안 붙임.
		onCalculate = Sum;
		//위 코드처럼 Sum 하나만 등록할 수도 있고 추가적으로 덧붙일 수도 있음. onCalculate += Subtract;
		onCalculate = onCalculate + Subtract;
		//등록된 걸 뺄 수도 있음
		onCalculate -= Subtract;
		onCalculate += Multiply;
	}

	public float Sum(float a,float b)
	{
		Debug.Log(a+b);
		return a+b;
	}

	public float Subtract(float a,float b)
	{
		Debug.Log(a-b);
		return a-b;
	}

	public float Multiply(float a,float b)
	{
		Debug.Log(a*b);
		return a*b;	
	}

	void Update(){
		if(Input.GetKeyDown(KeyCode.Space))
		{
			//Sum(1,10);,Subtract(1,10);
			//값을 debug.log같은 걸로 출력할 때는 등록된 기능이 여러개일 땐 맨 마지막 것만 출력됨. 
			onCalculate(1,10);
		}
	}
}
