using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueController : MonoBehaviour
{
    public DialogueListView dialogueView;
    public Dialog dialogDB;
    public List<Dialogue> diaglueList { get; set; }

    //Dialogue View �� Canvas�� ����������
    public DialogueController(Player player)
    {
        Debug.Log("Dialogue Controller Init");
        //�ӽ� : dialogueList �� User ���� �����ϰ� �ִ� ����. �ε�.
        for (int i = 0; i < 5; i++)
        {
            diaglueList.Add(new Dialogue() { SenderName = dialogDB.Entities[i].name, Seq = dialogDB.Entities[i].index, Context = dialogDB.Entities[i].dialog });
        }
    }


    private void Update()
    {
       
    }

}
