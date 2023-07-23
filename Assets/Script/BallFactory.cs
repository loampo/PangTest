using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class BallFactory
{
    public static Ball CreateBall(BallSize size)
    {
        switch (size)
        {
            case BallSize.Small:
                return new SmallBall();
            case BallSize.Medium:
                return new MediumBall();
            case BallSize.Large:
                return new LargeBall();
            case BallSize.ExtraLarge:
                return new ExtraLargeBall();
            default:
                throw new System.ArgumentException("Invalid ball size");
        }
    }
}

public enum BallSize
{
    Small,
    Medium,
    Large,
    ExtraLarge
}
