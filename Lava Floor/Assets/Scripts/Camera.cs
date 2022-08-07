using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    public Transform tf;
    public Transform ballTransform;
    public Rigidbody rgBall;

    // Start is called before the first frame update
    void Start()
    {
        rgBall = ballTransform.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        // Dot product of two normalized vector is equals to cos of theire angle.
        float yRotation = -Mathf.Acos(Vector3.Dot(rgBall.velocity.normalized, Vector3.right)) * Mathf.Rad2Deg;
        tf.eulerAngles = new Vector3(45, yRotation*180, 0);
    }
}
