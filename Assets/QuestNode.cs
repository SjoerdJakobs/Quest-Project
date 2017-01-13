using UnityEngine;
using System.Collections;

public class QuestNode : MonoBehaviour {

    private bool _active;
    public bool Active
    {
        get { return _active; }
        set { _active = value; }
    }

    private bool _completed;
    public bool Completed
    {
        get { return _completed; }
        set { _completed = value; }
    }

    private bool _timer;
    public bool Timer
    {
        get { return _timer; }
        set { _timer = value; }
    }

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
