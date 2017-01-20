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
        QuestNode Q = _questNodes[nodeCounter];
        if(Q.Completed == true)
        {
            nodeCounter++;
            _questNodes[nodeCounter].ActivateNode();
        }   
    }

    private void CheckCurrentNode()
    {

    }

	public string GetProgress()
    {
        progres = "finished step " + nodeCounter + " out of " + _questNodes.Length;
        return (progres);
    }
}
