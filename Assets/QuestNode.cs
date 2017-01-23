using UnityEngine;
using System.Collections;

public class QuestNode : MonoBehaviour {

    public event System.Action NodeClosed;

    public bool Active { get; set; }

    public bool Completed { get; set; }

    public bool Timer { get; set; }

    public string Description { get; set; }

    public float TotalTime { get; set; }

    public float LeftTime { get; set; }

    public void ActivateNode(float timer = 0)
    {
        if (timer != 0)
        {
            TotalTime = timer;
            LeftTime = timer;
            StartCoroutine(TimerCoroutine(timer));
            Invoke("DeactivateNode", timer);
        }
    }

    IEnumerator TimerCoroutine(float time)
    {
        while (true)
        {
            LeftTime --;
            yield return new WaitForSeconds(1);
        }
    }

    public void DeactivateNode()
    {
        StopAllCoroutines();
        if (NodeClosed != null)
        {
            NodeClosed();
        }
    }
}
