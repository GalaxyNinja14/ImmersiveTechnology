using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CradleTrigger : MonoBehaviour
{
   private void OnTriggerEnter(Collider other)
   {
        if (other.tag == "cradleObject")
        {
            GameEvents.current.SetCradleActive();
        }
   }

   private void OnTriggerExit(Collider other)
   {
        if (other.tag == "cradleObject")
        {
            GameEvents.current.SetCradleDeactive();
        }
   }
}
