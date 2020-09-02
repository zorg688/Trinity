using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private float _speed = 5f;
    // Start is called before the first frame update
    void Start()
    {
        this.transform.position = new Vector3(123f, 2.5f, 192f);
    }

    // Update is called once per frame
    void Update()
    {
        MovementBehaviour();
    }

    void MovementBehaviour()
    {

        if (Input.GetKey(KeyCode.D))
        {
            this.transform.Translate(Vector3.right * (_speed * Time.deltaTime));
        }
        if (Input.GetKey(KeyCode.A))
        {
            this.transform.Translate(Vector3.left * (_speed * Time.deltaTime));
        }
        if (Input.GetKey(KeyCode.W))
        {
            this.transform.Translate(Vector3.forward * (_speed * Time.deltaTime));
        }
        if (Input.GetKey(KeyCode.S))
        {
            this.transform.Translate(Vector3.back * (_speed * Time.deltaTime));
        }
        
    }
}
