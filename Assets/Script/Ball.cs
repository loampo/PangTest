using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Ball : MonoBehaviour
{
    public float speed;

    public abstract void Bounce();
    public abstract void Destroy();
}

public class SmallBall : Ball
{
    public override void Bounce() { }

    public override void Destroy() { }

}public class MediumBall : Ball
{
    public override void Bounce() { }

    public override void Destroy() { }

}public class LargeBall : Ball
{
    public override void Bounce() { }

    public override void Destroy() { }

}public class ExtraLargeBall : Ball
{
    public override void Bounce() { }

    public override void Destroy() { }
}
