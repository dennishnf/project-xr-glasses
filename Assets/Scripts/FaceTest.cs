using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;


public class FaceTest : MonoBehaviour
{

    private ARFace face;

    //private Transform lefteye;

    public GameObject glasses;
    public GameObject objtxMarker;

    // Start is called before the first frame update
    void Start()
    {
        // Get components from ARFace
        face = GetComponent<ARFace>();

        //lefteye = face.leftEye;

        //objtxMarker = Instantiate(glasses, transform);
        
        Instantiate(glasses, transform);
        
    }

    // Update is called once per frame
    void Update()
    {
        //objtxMarker.transform.localPosition = Vector3.zero;
    }
}
