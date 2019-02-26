using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharactorController : MonoBehaviour
{
	[SerializeField] private float speed = 0.1f;
	[SerializeField] private Transform camera;
	private Transform _transform;
	private Animator animator;
	
	private void Start()
	{
		_transform = GetComponent<Transform>();
		animator = GetComponent<Animator>();
	}

	private void Update()
	{
		float vInput = Input.GetAxis("Vertical");
		animator.SetFloat("Speed", vInput);
		var forward = camera.forward;
		Vector3 moveDirection = new Vector3(forward.x, 0, forward.z);
		_transform.LookAt(_transform.position + moveDirection);
		_transform.Translate( _transform.forward * speed * vInput * Time.deltaTime, Space.World);
		// Debug.Log("forward: "+_transform.forward);
	}
}