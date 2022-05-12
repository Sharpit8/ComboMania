using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shaker : MonoBehaviour
{
    Transform _target;
    Vector3 _intialPos;

    void Start(){
     _target = GetComponent<Transform>();
     _intialPos = _target.localPosition;
    }

    float _pendingShakeDuration = 0f;

    public void Shake(float duration) {
        if (duration > 0)
        {
            _pendingShakeDuration += duration;
        }
    }

    bool _isshaking = false;

    void Update(){
    if (_pendingShakeDuration > 0 && !_isshaking)
    {
        StartCoroutine(DoShake());
    }

    
    }
  
  IEnumerator DoShake(){
     
     _isshaking = true;

     var startTime = Time.realtimeSinceStartup;
     while (Time.realtimeSinceStartup < startTime+ _pendingShakeDuration)
     {
     var randomPoint = new Vector3(Random.Range(-1f,1f), Random.Range(-1f,1f), _intialPos.z);
     _target.localPosition = randomPoint;
     yield return null;
     }

     _pendingShakeDuration = 0f;
     _target.localPosition = _intialPos;
     _isshaking = false;

  }


}
