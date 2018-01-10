
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//The abstract keyword enables you to create classes and class members that are incomplete and must be implemented in a derived class.
public class MovingObject : MonoBehaviour
{

    Camera _mainCam = null;

    /// <summary>
    /// 마우스의 상태
    /// </summary>
    private bool _mouseState;

    /// <summary>
    /// 마우스가 다운된 오브젝트
    /// </summary>
    private GameObject target;
    /// <summary>
    /// 마우스 좌표
    /// </summary>
    private Vector3 MousePos;

    void Awake()
    {
        _mainCam = Camera.main;
    }

    // Update is called once per frame 
    void Update()
    {

        //마우스가 내려갔는지?
        if (true == Input.GetMouseButtonDown(0))
        {
            //내려갔다.

            //타겟을 받아온다.
            target = GetClickedObject();

            //타겟이 있나?
            if (target != null)
            {
                //있으면 마우스 정보를 바꾼다.
                _mouseState = true;
            }

        }
        else if (true == Input.GetMouseButtonUp(0))
        {
            //마우스가 올라 갔다.
            //마우스 정보를 바꾼다.
            _mouseState = false;
        }

        //마우스가 눌렸나?
        if (true == _mouseState)
        {
            //눌렸다!

            //마우스 좌표를 받아온다.
            MousePos = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, -Camera.main.transform.position.z));
            //타겟의 위치 변경
            target.transform.position = new Vector3(MousePos.x, MousePos.y, target.transform.position.z);
        }

    }


    /// <summary>
    /// 마우스가 내려간 오브젝트를 가지고 옵니다.
    /// </summary>
    /// <returns>선택된 오브젝트</returns>
    private GameObject GetClickedObject()
    {
        //충돌이 감지된 영역
        RaycastHit hit;
        //찾은 오브젝트
        GameObject target = null;

        //마우스 포이트 근처 좌표를 만든다.
        Ray ray = _mainCam.ScreenPointToRay(Input.mousePosition);

        //마우스 근처에 오브젝트가 있는지 확인
        if (true == (Physics.Raycast(ray.origin, ray.direction * 10, out hit)))
        {
            //있다!

            //있으면 오브젝트를 저장한다.
            target = hit.collider.gameObject;
        }

        return target;
    }
}