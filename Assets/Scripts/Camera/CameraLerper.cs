using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraLerper : MonoBehaviour {

    public Transform camera;
    public float speed = 1f;
    public Transform[] lerpTarget;
    public int index;
    private Vector3 targetPosition;
    
    void Start() {
        targetPosition = lerpTarget[0].position;
    }
    
    void Update() {
        if (Input.GetKeyDown(KeyCode.RightArrow)) {
            index++;
            if (index >= lerpTarget.Length) {
                index = 0;
            }
            targetPosition = lerpTarget[index].position;
        }
        camera.position = Vector3.Lerp(camera.position, targetPosition, Time.deltaTime * speed);
    }
}
