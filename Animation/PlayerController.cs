using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	//애니메이션 재생될 때 바라보거나 손을 얹을 타겟
	public Transform target;
	public Animator anim;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetButtonDown("Jump"))
		{
			anim.SetTrigger("Jump");
		}
		//vertical은 위아래 방향키 의미. 누르면 스피드 1씩 증가해서 움직임. horizontal은 왼오 방향키 의미
		float verticalInput = Input.GetAxis("Vertical");
		float horizontalInput = Input.GetAxis("Horizontal");
		
		anim.SetFloat("Speed",verticalInput);
		anim.SetFloat("Horizontal",horizontalInput);
	}

	//OnAnimatorIK는 애니메이터가 부착되어있는 게임오브젝트에만 동작함.
	//SetIKPositionWeight는 IK의 우선순위 결정해줌. 괄호값이 1에 가까우면 IK가 완전히 적용. 0에 가까우면 덜 적용
	//입력으로는 IK를 적용할 부위,IK를 적용할 퍼센테이지(0~1)
	void OnAnimatorIK()
	{
		anim.SetIKPositionWeight(AvatarIKGoal.LeftHand,1.0f);
		anim.SetIKRotationWeight(AvatarIKGoal.LeftHand,1.0f);

		//IK를 적용할 위치-왼손이 타겟의 위치로 이동
		anim.SetIKPosition(AvatarIKGoal.LeftHand,target.position);
		anim.SetIKRotation(AvatarIKGoal.LeftHand,target.rotation);

		//IK를 통해 캐릭터 시선 처리
		anim.SetLookAtWeight(1.0f);
		//바라볼 포지션
		anim.SetLookAtPosition(target.position);
	}
}
