using System.Collections;  
using System.Collections.Generic;  
using UnityEngine;  
  
public class ControlBall : MonoBehaviour  
{  // Start is called before the first frame update  
    public bool isGrounded;
    public Vector3 jump;
    public float jumpForce = 2.0f;
    Rigidbody rb;
    void Start()  
    {  
        rb = GetComponent<Rigidbody>();
        jump = new Vector3(0.0f, 2.0f, 0.0f);
    }  
    
    void OnCollisionStay()
    {
        isGrounded = true;
    }
    // Update is called once per frame  
    void Update()  
    {  
          
        if (Input.GetKey(KeyCode.W))  
        {  
            this.transform.Translate(Vector3.forward * Time.deltaTime * 4);  
        }  
         
        if (Input.GetKey(KeyCode.S))  
        {  
            this.transform.Translate(Vector3.back * Time.deltaTime);  
        }  
         
        if (Input.GetKey(KeyCode.A))  
        {  
            this.transform.Rotate(Vector3.up, -5);  
        }  
        
        if (Input.GetKey(KeyCode.D))  
        {  
            this.transform.Rotate(Vector3.up, 5);  
        }
        if(Input.GetKeyDown(KeyCode.Space) && isGrounded){
     
            rb.AddForce(jump * jumpForce, ForceMode.Impulse);
            isGrounded = false;
        }
    }  
}