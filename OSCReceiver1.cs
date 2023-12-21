using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using TMPro;
using UnityEngine.InputSystem;

public class OSCReceiver1 : MonoBehaviour
{
    public string RemoteIP = "127.0.0.1";
    public int SendToPort = 8000;
    public int ListenerPort = 8001;
    //public Transform controller;
    private OSC handler;

    public TMP_InputField IP;
    public TMP_InputField Port;

    public TMP_Text CIP;
    public TMP_Text CPort;

    public GameObject ACC;

    string message;

    // int a;
    // Use this for initialization
    void Start()
    {
        // a = 1;


        //Initializes on start up to listen for messages
        //make sure this game object has both UDPPackIO and OSC script attached
        UDPPacketIO udp = GetComponent("UDPPacketIO") as UDPPacketIO;

        udp.Init(RemoteIP, SendToPort, ListenerPort);
        handler = GetComponent("OSC") as OSC;
        handler.Init(udp);
    }


    void Update()
    {

        CIP.GetComponent<TextMeshProUGUI>().text = RemoteIP;
        CPort.GetComponent<TextMeshProUGUI>().text = SendToPort.ToString();

        OscMessage message;

        message = new OscMessage();
        message.Address = "/acc";
        message.Values.Add(ACC.GetComponent<Acclemeter_mag>().acclemeter);


        handler.Send(message);

        Debug.Log("send" + SendToPort + RemoteIP);

    }

    public void IPSet()
    {
        RemoteIP = IP.text;
    }

    public void PortSet()
    {
        string a = Port.text;
        SendToPort = int.Parse(a);
    }
}
