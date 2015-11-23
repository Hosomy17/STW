using UnityEngine;
using System.Collections;

public static class BehaviourPhysics
{
    public static void Move(GameObject gameObject, Vector2 direction, float velocity)
    {
        gameObject.GetComponent<Rigidbody2D>().velocity = (direction * velocity);
    }

    public static void MoveHorizontal(GameObject gameObject, float xDirection, float velocity)
    {
        gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(xDirection * velocity, gameObject.GetComponent<Rigidbody2D>().velocity.y);
    }

    public static void MoveVertical(GameObject gameObject, float yDirection, float velocity)
    {

        gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(gameObject.GetComponent<Rigidbody2D>().velocity.x, yDirection * velocity);
    }

    public static void Force(GameObject gameObject, Vector2 direction, float force)
    {
        gameObject.GetComponent<Rigidbody2D>().AddForce(direction * force);
    }

    public static void ForceHorizontal(GameObject gameObject, float xDirection, float force)
    {
        gameObject.GetComponent<Rigidbody2D>().AddForce( new Vector2(xDirection,0)* force);
    }

    public static void ForceVertical(GameObject gameObject, float yDirection, float force)
    {
        gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0, yDirection) * force);
    }

    public static void Turn(GameObject gameObject, Vector3 direction, float turnSpeed)
    {
        gameObject.transform.Rotate(-direction * turnSpeed * Time.deltaTime);
    }
}
