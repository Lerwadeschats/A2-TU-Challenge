using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Move : MonoBehaviour
{
    // Start is called before the first frame update
  [SerializeField] private int _speed;
    [SerializeField] private InputActionReference _move;
    // Update is called once per frame
    Vector2 _joystickDirection;
    private void Start()
    {
        _move.action.started += StartMove;
        _move.action.canceled += StopMove;
        _move.action.performed += UpdateMove;
    }

    IEnumerator MoveRoutine()
    {
        while (true)
        {
            yield return new WaitForFixedUpdate();
            transform.Translate(_joystickDirection * _speed * Time.deltaTime);
            
        }
    }
    
    private void StartMove(InputAction.CallbackContext obj)
    {
        _joystickDirection = obj.ReadValue<Vector2>();
        StartCoroutine(MoveRoutine());
    }
    private void UpdateMove(InputAction.CallbackContext obj)
    {
        Debug.Log($"update Move : {obj.ReadValue<Vector2>()}");
    }
    private void StopMove(InputAction.CallbackContext obj)
    {
        Debug.Log($"stop Move : {obj.ReadValue<Vector2>()}");
    }
    /*void FixedUpdate()
    {
        if (noInput) return;
        transform.Translate(new Vector2(Input.GetAxis("Horizontal") * _speed * Time.deltaTime,0));
    }*/
}
