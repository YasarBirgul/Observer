using System.Collections;
using System.Collections.Generic;
using ObserverPattern;
using UnityEngine;

namespace ObserverPattern
{
    
  public class Game_Controller : MonoBehaviour
 {
    public GameObject cube;
    
    // thing that will go away
    public GameObject capsule1bj;
    public GameObject capsule2bj;

    private Subject _subject = new Subject();
    void Start()
    {
        
        Capsule capsule1 = new Capsule(capsule1bj,new MoveLittle());
        Capsule capsule2 = new Capsule(capsule2bj,new MoveMore());
        
        
        _subject.AddObserver(capsule1);
        _subject.AddObserver(capsule2);
        

    }

    // Update is called once per frame
    void Update()
    {
        if ((cube.transform.position).magnitude < 0.5f)
        {
            _subject.Notify();
        }
    }
}
}