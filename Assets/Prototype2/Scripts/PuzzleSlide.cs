using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzleSlide : MonoBehaviour
{
    [SerializeField] private Transform emptySpace = null;
    private Camera _camera;
    public float distance;

    void Start()
    {
        _camera = Camera.main;
    }

    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Ray ray = _camera.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if(Physics.Raycast(ray, out hit, 1000f))
            {
                Debug.Log("shooo6");

                if (Vector3.Distance(emptySpace.position, hit.transform.position) < distance)
                {
                    
                    Vector3 lastEmptySpacePosition = emptySpace.position;
                    emptySpace.position = hit.transform.position;
                    hit.transform.position = lastEmptySpacePosition;
                    Debug.Log("shooo");
                    
                }
            }
        }
    }

    //�÷��̾ �� �������� �̵��ҽ� �� ������ full���°� �Ǿ� �ٸ� Ÿ���� ���� ���Ѵ�.
}
