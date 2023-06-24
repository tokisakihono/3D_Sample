using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NPC5Controller : MonoBehaviour
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
        this.NPCText.GetComponent<Text>().text = "—Î‚Ì“G‚É‚Í—Î‚ÌƒAƒCƒeƒ€8ŒÂ‚¢‚é‚Ý‚½‚¢‚¾‚æ";
    }
}