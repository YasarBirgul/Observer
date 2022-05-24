using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ObserverPattern
{    
    public class Subject
    {
        private List<Observer2> _observer2s = new List<Observer2>();

        public void Notify()
        {
            { for (int i = 0; i < _observer2s.Count; i++)
                {
                    //Notify all observers even though some may not be interested in what has happened
                    //Each observer should check if it is interested in this event
                    _observer2s[i].OnNotify();
                }
    
            }
            
            
        }
       public void AddObserver(Observer2 observer)
    {
    _observer2s.Add(observer);
    }


    }
    
   

}