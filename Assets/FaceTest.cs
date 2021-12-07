using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;


public class FaceTest : MonoBehaviour
{

    private ARFace face;
    //public sphere prefab;

    private Transform lefteye;

    public GameObject glasses1;
    public GameObject cubeMarker;

    // Start is called before the first frame update
    void Start()
    {
        //getcooñpononet arface
        face = GetComponent<ARFace>();

        lefteye = face.leftEye;

        //lefteye = ARFace.leftEye;
        cubeMarker = Instantiate(glasses1, transform);
        
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(augmentedFace.getMeshVertices());
        //Debug.Log("hellooo");

        //cubeMarker.transform.localPosition = Vector3.zero;
    }
}
