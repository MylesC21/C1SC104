using System;
using System.Numerics;
using UnityEngine;

public class GreenBallCollisionManager : BallCollisionManager
{
    public override void CollideWithBall(GameObject OtherBall)
    {
        Debug.Log("Green Ball Collision Manager Function");
        if (OtherBall.GetComponent<YellowBallCollisionManager>() != null)
        {
            Debug.Log("Green Collided With Yellow");

            GetComponent<Renderer>().material.color = new Color(152, 255, 0);
        }
    }
}

