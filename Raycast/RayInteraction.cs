using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayInteraction : MonoBehaviour {

	public LayerMask whatIsTarget;

	private Camera playerCam;
	//광선이 날아가는 거리
	public float distance=100f;
	//충돌한 상대방을 moveTarget이라는 변수에 넣고 moveTarget에 들어온 애를 계속 시선에 따라 이동시킬 거임.
	private Transform moveTarget;
	// 상대방과 나 사이의 처음 간격을 기억한 다음 이 간격을 유지한채로 옮겨주기
	private float targetDistance;

	// Use this for initialization
	void Start () {
		playerCam = Camera.main;
	}
	
	// Update is called once per frame
	void Update () {

		//광선이 시작되는 지점-ViewportToWorldPoint라는 카메라 내장함수. 화면상의 위치 찍어주면 해당 위치가 월드포지션으로 어딘지 알려줌. 
		Vector3 rayOrigin = playerCam.ViewportToWorldPoint(new Vector3(0.5f,0.5f,0f));
		//광선이 날아가는 방향-카메라의 앞쪽 방향으로 설정
		Vector3 rayDir = playerCam.transform.forward;
		//ray 데이터 만들고 광선 눈에 보이게 그려주기
		Ray ray= new Ray(rayOrigin,rayDir);
		Debug.DrawRay(ray.origin,ray.direction*100f,Color.green);

		//왼쪽 마우스 클릭했을 때 카메라에서 광선을 발사해서 카메라에 닿는 무언가가 있으면 감지
		if(Input.GetMouseButtonDown(0))
		{

			//RaycastHit은 레이캐스트에 대한 정보를 담아다주는 단순 컨테이너
			RaycastHit hit;
			//rayOrigin위치에서 광선을 rayDir방향으로 distance만큼 날렸을 때 어떤 collider가 걸리면 감지가 되서 true나오고 아니면 false
			//out은 입력으로 들어온 값이 내부에서 어떤 값을 갖고 빠져나온다는 뜻. 레이캐스트가 hit을 받게 되면 레이캐스트가 된 정보를 채워서 넘겨줌. 그 다음 이 hit을 통해 레이캐스트에 상대방에 대한 정보를 가져올 수 있음. 
			
			if(Physics.Raycast(ray,out hit,distance,whatIsTarget))
			{
				//충돌한 상대를 가져와서 컬러를 레드로 바꿔줌
				GameObject hitTarget = hit.collider.gameObject;
				hitTarget.GetComponent<Renderer>().material.color=Color.red;

				moveTarget=hitTarget.transform;
				targetDistance = hit.distance;
			}
		}
		//마우스 버튼 해제
		if(Input.GetMouseButtonUp(0))
		{
			if(moveTarget != null)
			{
				moveTarget.GetComponent<Renderer>().material.color=Color.white;
			}
			moveTarget = null;;
		}

		if(moveTarget != null)
		{
			//ray.origin은 카메라의 위치+ 처음 기록했던 간격(targetDistance) 유지한 채로 옮겨줌
			moveTarget.position = ray.origin + ray.direction * targetDistance;
		}
		
	}
}
