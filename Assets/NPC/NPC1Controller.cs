using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine. UI;

public class NPC1Controller : MonoBehaviour
{
    private GameObject NPCText;

    // Start is called before the first frame update
    void Start()
    {
        this.NPCText = GameObject.Find("NPCText");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter(Collision other)
    {
        this.NPCText.GetComponent<Text>().text = "茶色の敵には赤いアイテム6個いるみたいだよ";
    }
}
