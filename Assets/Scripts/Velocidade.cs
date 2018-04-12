using UnityEngine;

public class Velocidade : MonoBehaviour
{
	private const float C = 5995.8416f/1000f;
	
	public float Speed = 1f;
	private Rigidbody2D _rigidbody2D;

	// Use this for initialization
	private void Start ()
	{
		_rigidbody2D = GetComponent<Rigidbody2D>();
	}

	// Update is called once per frame
	private void FixedUpdate ()
	{
		var speed = Speed * C;
		var newPos = transform.position += Vector3.right * speed * Time.fixedDeltaTime;
		_rigidbody2D.MovePosition(newPos);
		
		
	}
}