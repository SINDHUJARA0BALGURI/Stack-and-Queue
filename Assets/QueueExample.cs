using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class QueueExample : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI queueDebug;

    // Start is called before the first frame update
    void Start()
    {
        Queue queue = new Queue();

        queue.Enqueue("S");
        queue.Enqueue("I");
        queue.Enqueue("N");
        queue.Enqueue("D");
        queue.Enqueue("H");
        queue.Enqueue("U");

        ShowInformationInQueue(queue);

        queue.Dequeue();
        ShowInformationInQueue(queue);

    }
    public void ShowInformationInQueue(Queue queue)
    {
        queueDebug.text += "...............\n";
        foreach(var queueitem in queue)
        {
            queueDebug.text += "{queueitem}\n";
        }
    }
}
