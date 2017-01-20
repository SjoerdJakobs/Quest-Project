using UnityEngine;
using System.Collections;

public class QuestNode : MonoBehaviour {

    public event System.Action NodeClosed;

    private bool _active;
    public bool Active
    {
        get { return _active; }
        set { _active = value; }
    }
    
    public bool Completed { get; set; }

    private bool _timer;
    public bool Timer { get; set; }

	public void ActivateNode(float timer = 0)
    {

    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
