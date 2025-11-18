using UnityEngine;

public class Player : MonoBehaviour
{
    private Rigidbody _PlayersRigidbody;
    [SerializeField] private int _speedMultiplier = 5;
    private PlayerInputActions _PlayersInputActions;

    private void Start()
    {
        _PlayersRigidbody = GetComponent<Rigidbody>();
        _PlayersInputActions = new PlayerInputActions();
        _PlayersInputActions.Enable();
    }

    private void Update()
    {
        Vector2 _direction = _PlayersInputActions.Player.Move.ReadValue<Vector2>() * _speedMultiplier;
        _PlayersRigidbody.linearVelocity = new Vector3(_direction.x, _PlayersRigidbody.linearVelocity.y, _direction.y);
    }
    /*private void Update()
    {
        Vector3 _direction = Vector3.zero;
        if (Input.GetKey(KeyCode.W))
        {
            Debug.Log("W is pressed down!");

            _direction += new Vector3(1 * _speedMultiplier, 0, 0);
        }
        if (Input.GetKey(KeyCode.S))
        {
            Debug.Log("S is pressed down!");

            _direction += new Vector3(-1 * _speedMultiplier, 0, 0);
        }
        if (Input.GetKey(KeyCode.A))
        {
            Debug.Log("A is pressed down!");

            _direction += new Vector3(0, 0, 1 * _speedMultiplier);
        }
        if (Input.GetKey(KeyCode.D))
        {
            Debug.Log("D is pressed down!");

            _direction += new Vector3(0, 0, -1 * _speedMultiplier);
        }
        _PlayersRigidbody.linearVelocity = new Vector3(_direction.x, _PlayersRigidbody.linearVelocity.y, _direction.z);
    }*/
}
