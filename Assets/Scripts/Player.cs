using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {
  private void Update() {
    Vector2 inputVector = Vector2.zero;

    if(Input.GetKey(KeyCode.W)) {
      inputVector.y = 1;
    }
    if(Input.GetKey(KeyCode.S)) {
      inputVector.y = -1;
    }
    if(Input.GetKey(KeyCode.A)) {
      inputVector.x = -1;
    }
    if(Input.GetKey(KeyCode.D)) {
      inputVector.x = 1;
    }
    inputVector = inputVector.normalized;

    Vector3 moveDir = new Vector3(inputVector.x, inputVector.y, 0f);
    transform.position += moveDir * Time.deltaTime;
    Debug.Log(inputVector);
  }
}
