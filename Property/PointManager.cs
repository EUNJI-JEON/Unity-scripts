using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointManager : MonoBehaviour {

	//이 point를 바깥에서 사용하면 Point를 사용하는 게 아니라 set,get을 사용하게 됨.
	//예를 들어 int a = point;라고 하면 get발동됨.
	//예를 들어 point = 100;이라 하면 set발동됨.
	private int point{
		get{
			Debug.Log(m_point);
			return m_point;
		}
		

		set{
			if(value<0)
			{
				m_point = 0;
			}
			else{
				m_point=value;
			}
		}
		
	}

	private int m_point = 0;
}
