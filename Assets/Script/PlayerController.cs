using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float speed = 10;
    [SerializeField] private Transform camera;
    void FixedUpdate()
    {
        // 入力をxとzに代入
        //float hInput = Input.GetAxis("Horizontal");
        // vInput = Input.GetAxis("Vertical");

        // Rigidbody rigidbody = GetComponent<Rigidbody>();

        // var forward = camera.forward;
        //Vector3 moveDirection = (forward - new Vector3(0, forward.y, 0));
        
        //rigidbody.AddForce(moveDirection * speed * vInput);
    }
}
