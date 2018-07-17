using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VoiceGuideStart : MonoBehaviour {
    public AudioSource AS;
    public GameObject obj;
    public AudioClip AC;
    bool startFlag;

    void Start()
    {
        //AudioSourceコンポーネントを取得し、変数に格納
        AS = gameObject.GetComponent<AudioSource>();
        startFlag = true;
    }

    void OnTriggerStay(Collider other)
    {
        if(other.gameObject.tag == obj.tag && startFlag)
        {
            AS.PlayOneShot(AC);
            startFlag = false;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        startFlag = true;
    }
}
