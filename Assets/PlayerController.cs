using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(PlayerMotor))]
public class PlayerController : MonoBehaviour
{
    Camera cam;
    PlayerMotor motor; 

    public LayerMask movementMask; 

    // Start is called before the first frame update
    void Start()
    {
        cam = Camera.main;
        motor.GetComponent<PlayerMotor>();
    }

    // Update is called once per frame
    void Update()
    {
     if(Input.GetMouseButtonDown(0))
        {
            Ray ray = cam.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit; 

            if (Physics.Raycast(ray, out hit, 100, movementMask))
            {

                motor.MoveToPoint(hit.point); 

                // stop focusing any objects 
            }
        }
        if (Input.GetMouseButtonDown(1))
        {
            Ray ray = cam.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit, 100))
            {

               //Check if we hit and interactable 
               //If we did then set it as focus.
            }
        }



    }
}
