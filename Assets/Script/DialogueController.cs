using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueController : MonoBehaviour
{
    public DialogueListView dialogueView;


    //Dialogue View 는 Canvas랑 종속적으로
    public DialogueController(Player player)
    {
        Debug.Log("Dialogue Controller Init");
        //임시 : dialogueList 는 User 에서 저장하고 있는 것을. 로드.
        for (int i = 0; i < 100; i++)
        {
            dialogueView.DiaglueList.Add(new Dialogue() { SenderName = "Anonymous", Seq = i, Context = $"Test {i}" });
        }
    }


    private void Update()
    {
       
    }

}
