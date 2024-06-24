using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using DG.Tweening;

public class PlayerMove : MonoBehaviour
{
    public bool isMove;

    private void Start()
    {

    }

    private void Update()
    {
        Move();

    }

    public void Move()
    {
        if (!isMove)
        {
            return;
        }
    }
    public void OnMove(InputValue value)
    {
        Vector2 direction = value.Get<Vector2>();

        Vector3 direction3D = new Vector3(direction.x, 0, direction.y);

        transform.DOMove(transform.position + direction3D, 1);
        
       
        
    }
}
