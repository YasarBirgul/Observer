using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace ObserverPattern
{    
    public abstract class CapsuleEvents
    {
        public abstract float GetMoveForce();
    }

    public class MoveLittle : CapsuleEvents
    {

        public override float GetMoveForce()
        {
            return 10f;
        }

    }
    
    public class MoveMore : CapsuleEvents
    {

        public override float GetMoveForce()
        {

            return 20f;
        }

    }
    
    
}