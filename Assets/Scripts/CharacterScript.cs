using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterScript : MonoBehaviour, IHealthHolder, IMovable
{
    private float hp = 20f;
    private readonly float speed = 15f;

    void FixedUpdate()
    {
        Move();
    }

    public void Move()
    {
        transform.position += new Vector3(Input.GetAxis("Horizontal") * speed * Time.deltaTime, 0,
            Input.GetAxis("Vertical") * speed * Time.deltaTime);
    }

    public float Speed { get { return speed; } }

    public void ChangeHp(float step)
    {
        hp += step;
    }

    public float HealthPoints { get { return hp; } }  
}
