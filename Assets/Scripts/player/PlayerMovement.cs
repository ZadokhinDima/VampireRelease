using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {
    private const string HorizontalAxis = "Horizontal";
    private const string GroundTag = "Ground";
    private const string AnimatorSpeedParameter = "speed";
    [SerializeField]
	private float speed;

	[SerializeField]
	private float jumpForce;
	private Rigidbody2D body;
	private Animator animator;


	// Use this for initialization
	void Start () {
		body = GetComponent<Rigidbody2D>();
		animator = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
		HandleOrientation();
		HandleMovement();
	}

	void OnCollisionStay2D(Collision2D collision) {
		if (collision.gameObject.tag == GroundTag) {
			HandleJump();
		}
	}

	private void HandleMovement() {
		float right = Input.GetAxis(HorizontalAxis);
		body.velocity = new Vector2(right * speed * Time.deltaTime, body.velocity.y);
		animator.SetFloat(AnimatorSpeedParameter, Mathf.Abs(right));
	}

	private void HandleJump() {
		if (Input.GetKey(KeyCode.Space)) {
			body.AddForce(Vector2.up * jumpForce);
		}
	}

	private void HandleOrientation() {
		if (body.velocity.x > 0) {
			transform.localScale = new Vector3(1, 1, 1);
		}
		if (body.velocity.x < 0) {
			transform.localScale = new Vector3(-1, 1, 1);
		}
	}
}
