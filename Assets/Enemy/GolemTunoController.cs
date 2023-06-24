
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//NavMesh
using UnityEngine.AI;

public class GolemTunoController : MonoBehaviour
{
    //���C�t
    private int Life = 50;

    //�n�_�i�e�I�u�W�F�N�g�j
    public GameObject Navi;

    //�n�_�J�E���^�[
    private int counter = 0;

    //�I�u�W�F�N�g��
    private int number = 0;

    // Start is called before the first frame update
    void Start()
    {
        //�A�j���[�V����
        GetComponent<Animator>().SetBool("Walk", true);

        //�q�I�u�W�F�N�g�̐�
        number = Navi.GetComponentInChildren<Transform>().childCount;

        //�ŏ��̖ڕW�n�_ �������`�F�b�N
        if (number > 0)
        {
            GetComponent<NavMeshAgent>().destination = Navi.transform.GetChild(0).transform.position;
        }
    }

    // Update is called once per frame
    void Update()
    {
        //�ڕW�n�_�܂ōs�����H
        if (GetComponent<NavMeshAgent>().remainingDistance < 0.1f)
        {
            //���̒n�_
            counter++;

            //���̖ڕW�n�_ �������`�F�b�N
            if (number > 0)
            {
                //���̖ڕW�n�_��
                GetComponent<NavMeshAgent>().destination = Navi.transform.GetChild(counter % number).transform.position;
            }
        }
    }
    public void requestDamage()
    {
        //Damage
        GetComponent<Animator>().SetTrigger("Damage");
        //Die�i�Z�b�g�j
        //GetComponent<NavMeshAgent>().isStopped = true;
        //GetComponent<Animator>().SetBool("Walk", false);
        //GetComponent<Animator>().SetTrigger("Die");
        Debug.Log("requestDamage");
    }
}
