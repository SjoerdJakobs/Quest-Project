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

    public string Description;

    public string progres;

    public int nodeCounter;
    

	void Awake ()
    {
        progres = "finished step " + nodeCounter + " out of " + _questNodes.Length;
        foreach(QuestNode Q in _questNodes)
        {
            Q.NodeClosed += OnNodeClose;
        }
    }
	

    void OnNodeClose()
    {

    }


	public string GetProgress()
    {
        progres = "finished step " + nodeCounter + " out of " + _questNodes.Length;
        return (progres);
    }
}
