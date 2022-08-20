using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float speed = 5;
    [SerializeField] private float turnSpeed = 360;
    private Vector3 input;
    [SerializeField] private Rigidbody _rigidBody;
    [SerializeField] private Transform _model;

    public float jumpForce = 4000f;
    public bool isGrounded;
    public LayerMask LayerGround;

    private void Update()
    {
        GatherInput();
        Look();

        Debug.DrawRay(transform.position, Vector3.down * 0.6f, Color.red);

        CheckinGround();
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {

            Jump();
        }
    }

    private void FixedUpdate()
    {
        Move();
    }

    private void GatherInput()
    {
        input = new Vector3(Input.GetAxisRaw("Horizontal"), 0, Input.GetAxisRaw("Vertical"));
    }

    private void Move()
    {
        _rigidBody.MovePosition(transform.position + input.ToIso() * input.normalized.magnitude * speed * Time.deltaTime);
    }
    private void Look()
    {
        if (input == Vector3.zero) return;

        Quaternion rot = Quaternion.LookRotation(input.ToIso(), Vector3.up);
        _model.rotation = Quaternion.RotateTowards(_model.rotation, rot, turnSpeed * Time.deltaTime);
    }

    void CheckinGround()
    {
        RaycastHit hitInfo = new RaycastHit();

        // wip cambiar distancia al importar el modelo
        if (Physics.Raycast(transform.position, Vector3.down, out hitInfo, 0.6f, LayerGround))
        {
            isGrounded = true;
            Debug.Log("esta en el piso");
        }
        else isGrounded = false;
    }

    void Jump()
    {

        Debug.Log("salto");
       _rigidBody.AddForce(Vector3.up * jumpForce);
       
       
    }
}

public static class Helpers
{
    private static Matrix4x4 _isoMatrix = Matrix4x4.Rotate(Quaternion.Euler(0, 45, 0));
    public static Vector3 ToIso(this Vector3 input) => _isoMatrix.MultiplyPoint3x4(input);
}
