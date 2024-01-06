#region Using directives
using System;
using UAManagedCore;
using OpcUa = UAManagedCore.OpcUa;
using FTOptix.HMIProject;
using FTOptix.Retentivity;
using FTOptix.UI;
using FTOptix.NativeUI;
using FTOptix.CoreBase;
using FTOptix.Core;
using FTOptix.NetLogic;
using Winsock_Orcas;
using System.Reflection.Emit;
using System.Net.Sockets;
using System.Net.Security;
using System.Net.Http;
#endregion

public class RuntimeNetLogic1 : BaseNetLogic
{
    
    //Winsock winsock_Ear = new Winsock();
    Winsock winsock_Ear = new Winsock(); //opens a new socket
    

    private void winsock_Ear_Connected(object sender, Winsock_Orcas.WinsockConnectedEventArgs e)
    {
        Log.Info("Connected to slave!!");
        
    }

    [ExportMethod]
    
    public void Send()
    {
        /*
         Log.Info("Hello World");
         winsock_Ear.Listen(2000);//This is to make the PC act as server host
                                 //winsock_Ear.Connect("10.2.10.201", 2000); //This is to make the PC act as client
        
        winsock_Ear.LegacySupport=true;
        Log.Info("LocalIP: "+winsock_Ear.LocalIP[0]);
        Log.Info("protocol: "+winsock_Ear.Protocol.ToString());
        Log.Info("Legacy support: "+winsock_Ear.LegacySupport.ToString());
        Log.Info("LocalPort: "+winsock_Ear.LocalPort.ToString());
        Log.Info("Remote Host: "+winsock_Ear.RemoteHost.ToString());
        Log.Info("Remote Port: "+winsock_Ear.RemotePort.ToString());
        Log.Info("State: "+winsock_Ear.State.ToString());
        Log.Info("Hello World");
        while (true)
        {
        */ 
        /*
        Log.Info("Executing procedure");   
        string text_to_send = "Hello World";
        winsock_Ear.Send(text_to_send);
        //System.Threading.Thread.Sleep(1000);
        }
        
        */
    }




    public override void Start()
    //public override void Start()
    //public override void Start(object sender, EventArgs e)
    {
       //Winsock winsock_Ear = new Winsock();
       winsock_Ear.LegacySupport=true;
       
       winsock_Ear.Listen(2000);//This is to make the PC act as host
                                 //winsock_Ear.Connect("10.2.10.201", 2000); //This is to make the PC act as client
        
        Log.Info("LocalIP: "+winsock_Ear.LocalIP[0]);
        Log.Info("protocol: "+winsock_Ear.Protocol.ToString());
        Log.Info("Legacy support: "+winsock_Ear.LegacySupport.ToString());
        Log.Info("LocalPort: "+winsock_Ear.LocalPort.ToString());
        Log.Info("Remote Host: "+winsock_Ear.RemoteHost.ToString());
        Log.Info("Remote Port: "+winsock_Ear.RemotePort.ToString());
        Log.Info("State: "+winsock_Ear.State.ToString());
        Log.Info("Hello World");
        
        //Winsock.Accept(winsock_Ear_Connected);
       
        /*
        void winsock_Ear_ConnectionRequest(object sender, WinsockConnectionRequestEventArgs e)
        {
            winsock_Ear.Close();
            winsock_Ear.Accept(e.Client);
            Log.Info("Connected to slave!!");

        }
        */
        /*
        while (true)
        {
        string text_to_send = "Hello World";
        winsock_Ear.Send(text_to_send);
        System.Threading.Thread.Sleep(1000);
        } 
        */
    }

    public override void Stop()
    //public override void Stop()
    {
         Log.Info("Stopping");
        // Insert code to be executed when the user-defined logic is stopped
    }
    /*private void winsock_Ear_ConnectionRequest(object sender, WinsockConnectionRequestEventArgs e)
    {
        winsock_Ear.Close();
        winsock_Ear.Accept(e.Client);
        Log.Info("Connected to slave!!");

    }
    */
private void winsock_Ear_DataArrival(object sender, Winsock_Orcas.WinsockDataArrivalEventArgs e)
        {
            string abRecibidos = winsock_Ear.Get<string>();
            Log.Info(abRecibidos);
            
        }
    //private Winsock_Orcas.Winsock winsock_Ear;
    //public Winsock_Orcas.Winsock winsock_Ear;
}
