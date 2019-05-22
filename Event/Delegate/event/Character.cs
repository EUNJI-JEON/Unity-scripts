using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour {

	public delegate void Boost(Character target);

	public Boost playerBoost;
	
	public string playerName = "Elena";

	public float hp = 100;
	public float defense = 50;

	public float damage = 30;

	void Start()
	{
		//Boost 발동시키는데 자기 자신 넣어서 발동시킴.
		playerBoost(this);
	}

	void Update()
	{
		if(Input.GetKeyDown(KeyCode.Space))
		{
			playerBoost(this);
			
		}
	}
}
