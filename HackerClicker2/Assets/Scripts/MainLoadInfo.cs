using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class MainLoadInfo : MonoBehaviour {
    private List<GameObject> computers;
	void Start () {

        
        
	}

    void Update()
    {
        Ray ray;
        RaycastHit rayCashHit;
        if (Input.GetMouseButtonDown(0))
        {
            ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            Debug.DrawRay(gameObject.transform.position, ray.direction * 1000, Color.red);
            if(Physics.Raycast(ray,out rayCashHit))
            {
                Debug.Log(rayCashHit.collider.GetComponent<Transform>().name);
            }
        }
        
	}
}
