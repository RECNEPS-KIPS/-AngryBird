﻿using UnityEngine;
using UnityEngine.UI;

public class LevelSelect : MonoBehaviour {
    public bool canSelect = false;
    public Image image;
    public Sprite unlockSprite;
    public Button bt;
    public GameObject levelNum;
    // Start is called before the first frame update
    void Start() {
        bt = GetComponent<Button>();
        bt.enabled = false;
        image = GetComponent<Image>();//获取Image组件
        //解锁第一个关卡
        if (transform.parent.GetChild(0).name == gameObject.name) {
            canSelect = true;
        }
        //若可以选择关卡,将图片替换成解锁图片
        if (canSelect) {
            bt.enabled = true;
            image.sprite = unlockSprite;
            //levelNum.SetActive(true);
            transform.Find("Num").gameObject.SetActive(true);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
