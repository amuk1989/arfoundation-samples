using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;

public class HairController : MonoBehaviour
{
    [SerializeField] private ARFaceManager _faceManager;
    [SerializeField] private GameObject _hairPrefab; 

    private ARFace _arFace;
    private Transform _hairTransform;
    
    
    // Start is called before the first frame update
    void Start()
    {
        _hairTransform = Instantiate(_hairPrefab).transform;
    }

    // Update is called once per frame
    void Update()
    {
        if (_arFace == null)
        {
            _arFace = _faceManager.GetComponentInChildren<ARFace>();
            if (_arFace == null) return;
            _hairTransform.SetParent(_arFace.transform, false);
        }
    }
}
