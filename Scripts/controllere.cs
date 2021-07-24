 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controllere : MonoBehaviour
{
    float mS = 100f;
    public Transform pb;
    float xrot = 0f;
    // Start is called before the first frame update
    void Start()
    {
 
    }

    // Update is called once per frame
    void Update()
    {

        float mousex = Input.GetAxis("Mouse X") * mS * Time.deltaTime;
        float mousey = Input.GetAxis("Mouse Y") * mS * Time.deltaTime;
        xrot -= mousey;
        xrot = Mathf.Clamp(xrot, -80f, 80);
        transform.localRotation = Quaternion.Euler(xrot, 0f, 0f);
        pb.Rotate(Vector3.up * mousex);
        
    }
}