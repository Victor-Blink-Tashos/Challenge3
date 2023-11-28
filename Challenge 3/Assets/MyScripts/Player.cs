using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{


    public Transform trans;

    [SerializeField] Rigidbody bodies;

    [SerializeField] Transform mal;

   

    public float moveSpeed;

    public float timeToNextDash;
    public float shootDelay;
    public float bulletSpeed;

    bool initialDelayApplied;
    // Start is called before the first frame update
    void Start()
    {
        trans.GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(horizontalInput, 0, verticalInput) * moveSpeed;
        transform.Translate(movement);




        transform.LookAt(mal);

    }
}
