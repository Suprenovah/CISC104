using System;
using UnityEngine;

public class RedBallCollisionManager : BallCollisionManager
{
    public GameObject blackBallPrefab;
    public GameObject plane;

    public override void CollideWithBall(GameObject OtherBall)
    {
        Debug.Log("Red Ball Collision Manager Function");

        if (OtherBall.GetComponent<BlueBallCollisionManager>() != null)
        {
            Debug.Log("Red Collided With Blue");

            Instantiate(blackBallPrefab, plane.transform);
        }

        if (OtherBall.GetComponent<GreenBallCollisionManager>() != null)
        {
            Debug.Log("Green Collided With Red");
        }
    }
}

