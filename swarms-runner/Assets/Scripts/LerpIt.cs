using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LerpIt: MonoBehaviour
{
   private bool lerpOrNot = false;
   public Vector3 endPosition;
   public Vector3 startPosition;
   public float lerpTime;
   public float timeStartedLerping;

    void Start() {
        startLerping();
    }

    void Update(){
        if (lerpOrNot){
          transform.position = Lerp(startPosition,endPosition, timeStartedLerping,lerpTime); 
        }
        
    }

   private void startLerping(){
       timeStartedLerping = Time.time;
       lerpOrNot = true;
;
   }


   public Vector3 Lerp(Vector3 start, Vector3 end, float timeStartedLerping, float lerpTime = 1){
       float timeSinceStarted = Time.time - timeStartedLerping;
       float precentageComplete = timeSinceStarted / lerpTime;

       var result = Vector3.Lerp(start, end, precentageComplete);
       return result;
   }

}
