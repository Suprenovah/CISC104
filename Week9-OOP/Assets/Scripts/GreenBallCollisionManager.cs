using System;
using UnityEngine;

public class GreenBallCollisionManager : BallCollisionManager
{
    public GameObject blackBallPrefab;
    public GameObject plane;

    public override void CollideWithBall(GameObject OtherBall)
    {
        Debug.Log("Green Ball Collision Manager Function");

        if (OtherBall.GetComponent<RedBallCollisionManager>() != null)
        {
            Debug.Log("Green Collided With Red");

            Instantiate(blackBallPrefab, plane.transform);
        }
    }
}

