using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ballscript : MonoBehaviour
{
    public GameObject ball;
    public Transform cameratransform;
    public Transform pitchtransform;
    float z;
    Camera maincamera;
    // Start is called before the first frame update
    void Start()
    {
        maincamera = Camera.main;
        float camzpos = cameratransform.position.z;
        float pitchzpos = pitchtransform.position.z;
        z = Mathf.Abs(camzpos - pitchzpos);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            Vector3 mousepos = Input.mousePosition;
            mousepos.z = z;
            Vector3 unityenvironmousepos = maincamera.ScreenToWorldPoint(mousepos);
            Instantiate(ball, unityenvironmousepos, Quaternion.identity);
        }
    }
}
