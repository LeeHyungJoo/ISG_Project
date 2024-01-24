using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueController : MonoBehaviour
{
    public DialogueListView dialogueView;


    //Dialogue View �� Canvas�� ����������
    public DialogueController(Player player)
    {
        Debug.Log("Dialogue Controller Init");
        //�ӽ� : dialogueList �� User ���� �����ϰ� �ִ� ����. �ε�.
        for (int i = 0; i < 100; i++)
        {
            dialogueView.DiaglueList.Add(new Dialogue() { SenderName = "Anonymous", Seq = i, Context = $"Test {i}" });
        }
    }


    private void Update()
    {
       
    }

}
