
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//NavMesh
using UnityEngine.AI;

public class GolemTunoController : MonoBehaviour
{
    //地点（親オブジェクト）
    public GameObject Navi;

    //地点カウンター
    private int counter = 0;

    //オブジェクト数
    private int number = 0;

    // Start is called before the first frame update
    void Start()
    {
        //アニメーション
        GetComponent<Animator>().SetBool("Walk", true);

        //子オブジェクトの数
        number = Navi.GetComponentInChildren<Transform>().childCount;

        //最初の目標地点 ※無しチェック
        if (number > 0)
        {
            GetComponent<NavMeshAgent>().destination = Navi.transform.GetChild(0).transform.position;
        }
    }

    // Update is called once per frame
    void Update()
    {
        //目標地点まで行った？
        if (GetComponent<NavMeshAgent>().remainingDistance < 0.1f)
        {
            //次の地点
            counter++;

            //次の目標地点 ※無しチェック
            if (number > 0)
            {
                //次の目標地点へ
                GetComponent<NavMeshAgent>().destination = Navi.transform.GetChild(counter % number).transform.position;
            }
        }
    }
    void OnCollisionEnter(Collision other)
    {
        //タグ
        if (other.gameObject.tag == "Player")
        {
            Debug.Log("当たった");
        }
    }
}
