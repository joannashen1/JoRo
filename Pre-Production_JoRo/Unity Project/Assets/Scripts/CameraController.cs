using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CameraController : MonoBehaviour
{

    public GameObject player;
    private Vector3 offset;

    float distance;
    Vector3 playerPrevPos, playerMoveDir;


    void Start()
    {
        offset = transform.position - player.transform.position;

        //distance = offset.magnitude;
        //playerPrevPos = player.transform.position;
    }

    void LateUpdate()
    {//camera update code should be under LateUpdate to avoid jittering

        transform.position = player.transform.position + offset;

        //playerMoveDir = player.transform.position - playerPrevPos; //how much player moved since last frame
        //if (playerMoveDir != Vector3.zero)//!= means not equal to
        //{
           // playerMoveDir.Normalize(); //normalize" normalizes the vector (with mag) into 1 (direction)
            //transform.position = player.transform.position - playerMoveDir * distance;
            //Vector3 Move = transform.position;
           // transform.position = new Vector3(Move.x, 2, Move.z); //taking transform.position apart using Move

            //transform.Translate(0, 3, 0);

            //transform.LookAt(player.transform.position);

           // playerPrevPos = player.transform.position;
        //}

        //transform.position = player.transform.position + offset;
    }
}