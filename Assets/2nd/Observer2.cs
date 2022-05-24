using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ObserverPattern
{
    
    public abstract class Observer2
{
    public abstract void OnNotify();
    
}

    public class Capsule : Observer2
    {
        private GameObject capsuleObj;

        private CapsuleEvents _capsuleEvent;


        public Capsule(GameObject capsuleOBj, CapsuleEvents capsuleEvent)
        {
            this.capsuleObj = capsuleOBj;
            this._capsuleEvent = capsuleEvent;

        }
        
          public override void OnNotify()
        {
            Run(_capsuleEvent.GetMoveForce());
        }


        
          void Run(float moveForce)
            {

                if (capsuleObj.transform.position.y < 0.55f)
                {
                    capsuleObj.GetComponent<Rigidbody>().AddForce(Vector3.up*moveForce);
                    
                }

            }
          
    }
    
    
    
    
    
    
}