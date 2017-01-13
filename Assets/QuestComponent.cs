using UnityEngine;
using System.Collections;

public class QuestComponent : MonoBehaviour {

    private QuestNode _currentQuestNode;

    [SerializeField]
    private QuestNode[] _questNodes;

    [SerializeField]
    private QuestStartPoint _startPoint;

    [SerializeField]
    private QuestEndPoint _endPoint;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
