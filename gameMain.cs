using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gameMain : MonoBehaviour
{

    public Canvas MainCanvas;
    
    public Button ButtonBegin;

    public Button ButtonBig;
    public Button ButtonStart;
    public Button ButtonCoutinue;
    public Button ButtonHelp;
    public Button ButtonSetting;
    public Button ButtonOther;
    public Button ButtonQuit;

    public Button openMusic;
    public Button closeMusic;
    public Button ButtonPhone;
    public Button ButtonMice;
    public Button ButtonCloseBackground;
    public Button ButtonOpenBackground;
    public Button ButtonMusic1;
    public Button ButtonMusic2;
    
    public Button ButtonSettingBig;
    public Button ButtonMusic;
    public Button ButtonBackgroundMusic;
    public Button ButtonControlWay;

    public Button Button_restart;
    public Button Button_home;
    public Button Button_setting_2;
    public Button Button_help_2;
        
    public Transform PanleBegin;
    public Transform PanleStart;

    public Transform PanleHelp;
    public Transform PanleSetting;
    public Transform PanleOther;

    public Transform PanleMusic;
    public Transform PanleBackgroundMusic;
    public Transform PanleControlWay;

    public Transform PlaneBlack;
    public Transform PlaneLose;

    void Start()
    {

        init();
        ButtonBegin.onClick.AddListener(() =>
        {
            PanleBegin.gameObject.SetActive(false);
            PanleStart.gameObject.SetActive(true);
        });

        ButtonBig.onClick.AddListener(() =>
        {
            PanleHelp.gameObject.SetActive(false);
            PanleSetting.gameObject.SetActive(false);
            PanleOther.gameObject.SetActive(false);
        });

        ButtonHelp.onClick.AddListener(() =>
        {
            PanleHelp.gameObject.SetActive(true);
        });

        ButtonSetting.onClick.AddListener(() =>
        {
            PanleSetting.gameObject.SetActive(true);
        });

        ButtonOther.onClick.AddListener(() =>
        {
            PanleOther.gameObject.SetActive(true);
        });

        ButtonQuit.onClick.AddListener(() =>
        {
            PanleBegin.gameObject.SetActive(true);
            PanleStart.gameObject.SetActive(false);
        });


        ButtonSettingBig.onClick.AddListener(() =>
        {
            PanleMusic.gameObject.SetActive(false);
            PanleBackgroundMusic.gameObject.SetActive(false);
            PanleControlWay.gameObject.SetActive(false);
        });

        ButtonMusic.onClick.AddListener(() =>
        {
            PanleMusic.gameObject.SetActive(true);
        });

        ButtonBackgroundMusic.onClick.AddListener(() =>
        {
            PanleBackgroundMusic.gameObject.SetActive(true);
        });
        ButtonControlWay.onClick.AddListener(() =>
        {
            PanleControlWay.gameObject.SetActive(true);
        });



        openMusic.onClick.AddListener(() =>
        {
            openMusic.gameObject.SetActive(false);
            closeMusic.gameObject.SetActive(true);
        });

        closeMusic.onClick.AddListener(() =>
        {
            openMusic.gameObject.SetActive(true);
            closeMusic.gameObject.SetActive(false);
        });


        ButtonPhone.onClick.AddListener(() =>
        {
            ButtonPhone.gameObject.SetActive(false);
            ButtonMice.gameObject.SetActive(true);
        });
        ButtonMice.onClick.AddListener(() =>
        {
            ButtonPhone.gameObject.SetActive(true);
            ButtonMice.gameObject.SetActive(false);
        });

        ButtonCloseBackground.onClick.AddListener(() =>
        {
            ButtonCloseBackground.gameObject.SetActive(false);
            ButtonOpenBackground.gameObject.SetActive(true);
        });

        ButtonOpenBackground.onClick.AddListener(() =>
        {
            ButtonCloseBackground.gameObject.SetActive(true);
            ButtonOpenBackground.gameObject.SetActive(false);
        });


        ButtonMusic1.onClick.AddListener(() =>
        {
            ButtonMusic1.gameObject.SetActive(false);
            ButtonMusic2.gameObject.SetActive(true);
        });
        ButtonMusic2.onClick.AddListener(() =>
        {
            ButtonMusic1.gameObject.SetActive(true);
            ButtonMusic2.gameObject.SetActive(false);
        });


        ButtonStart.onClick.AddListener(() =>
        {
            PanleStart.gameObject.SetActive(false);
            PlaneBlack.gameObject.SetActive(false);
        });
        ButtonCoutinue.onClick.AddListener(() =>
        {
            // TODO
            //游戏暂停
            PlaneBlack.gameObject.SetActive(false);
            PanleStart.gameObject.SetActive(false);
        
        });

        Button_home.onClick.AddListener(() =>
        {
            PlaneBlack.gameObject.SetActive(true);
            MainCanvas.gameObject.SetActive(true);
            PanleStart.gameObject.SetActive(true);
        });

        Button_help_2.onClick.AddListener(() =>
        {
            PlaneBlack.gameObject.SetActive(true);
            MainCanvas.gameObject.SetActive(true);
            PanleStart.gameObject.SetActive(true);
            PanleHelp.gameObject.SetActive(true);
        });
        Button_setting_2.onClick.AddListener(() =>
        {
            PlaneBlack.gameObject.SetActive(true);
            MainCanvas.gameObject.SetActive(true);
            PanleStart.gameObject.SetActive(true);
            PanleSetting.gameObject.SetActive(true);
        });

    }

    public void init()
    {
        PlaneLose.gameObject.SetActive(false);
        PlaneBlack.gameObject.SetActive(true);
        PanleStart.gameObject.SetActive(false);
        PanleHelp.gameObject.SetActive(false);
        PanleSetting.gameObject.SetActive(false);
        PanleOther.gameObject.SetActive(false);
        PanleMusic.gameObject.SetActive(false);
        PanleBackgroundMusic.gameObject.SetActive(false);
        PanleControlWay.gameObject.SetActive(false);

    }
    // Update is called once per frame
    void Update()
    {

    }
}
