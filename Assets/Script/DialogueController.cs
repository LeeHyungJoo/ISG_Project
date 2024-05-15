using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueController : MonoBehaviour
{
    public DialogueListView dialogueView;
    public List<Dialogue> diaglueList { get; set; }

    //Dialogue View �� Canvas�� ����������
    public DialogueController(Player player)
    {
        Debug.Log("Dialogue Controller Init");
        //�ӽ� : dialogueList �� User ���� �����ϰ� �ִ� ����. �ε�.
        for (int i = 0; i < 100; i++)
        {
            diaglueList.Add(new Dialogue() { SenderName = "Anonymous", Seq = i, Context = $"Test {i}" });
        }
    }

    private void Start()
    {
        
    }

    private void Update()
    {
       
    }

}
