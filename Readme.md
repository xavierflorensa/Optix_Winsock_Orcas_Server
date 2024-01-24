<a name="_toc155458070"></a><a name="_toc156766291"></a>Third party libraries (dll) Socket Server application with FactoryTalk Optix
# Contents
[1.	Introduction	1](#_toc157019700)

[2.	Installing third party DLL’s into FactoryTalk Optix.	1](#_toc157019701)

[2.1.	Installing external references (dll libraries) into the project with Visual Studio code	9](#_toc157019702)

[1.	Building the Server	11](#_toc157019703)




1. # <a name="_toc157019700"></a>Introduction
You can see the result here

<https://youtu.be/6E4xt02Ohzw>

You can download the code from here

<https://github.com/xavierflorensa/Optix_Winsock_Orcas_Server.git>

You can use third party libraries.

For instance Winsock\_Orcas.dll

Even thought this library was created for Visual Basic, since it is compiled, it can be also used with C#

<https://www.codeproject.com/Articles/21443/Winsock-Revamped>

Let’s start this application from zero
# <a name="_toc157019701"></a>1. Installing third party DLL’s into FactoryTalk Optix.
The easiest way to install external references to a project is using Visual Studio 2002, since it will do all the work for you. Then if you prefer you can continue with Visual Studio Code since it is much faster to open and close.

Start a new project in FT Optix Studio

Add a new NetLogic code

![Aspose Words ba282580-5f3d-413f-93f5-cedb57be876b 001](https://github.com/xavierflorensa/Optix_Winsock_Orcas_Server/assets/55208134/e3283e46-6c67-41fe-849a-83a6cb07105c)

Save the project

Insert this dll on the root directory of the project

Winsock\_Orcas.dll

![Aspose Words ba282580-5f3d-413f-93f5-cedb57be876b 002](https://github.com/xavierflorensa/Optix_Winsock_Orcas_Server/assets/55208134/8b935f29-22b8-41b9-9e95-1f867ce8b1ed)

Select editor to Visual Studio 2022

Close and open FT Optix to have this change updated.

Click on the code

![Aspose Words ba282580-5f3d-413f-93f5-cedb57be876b 003](https://github.com/xavierflorensa/Optix_Winsock_Orcas_Server/assets/55208134/8dd9fe97-8d63-474d-88f7-e49a48040f69)

Visual Studio 2022 will open

![Aspose Words ba282580-5f3d-413f-93f5-cedb57be876b 004](https://github.com/xavierflorensa/Optix_Winsock_Orcas_Server/assets/55208134/09409351-db93-458e-8207-db8020c25be4)

![A screenshot of a computer

Description automatically generated](Aspose.Words.ba282580-5f3d-413f-93f5-cedb57be876b.004.png)

Go to Project / Add Project Reference

![Aspose Words ba282580-5f3d-413f-93f5-cedb57be876b 005](https://github.com/xavierflorensa/Optix_Winsock_Orcas_Server/assets/55208134/0d37f71a-5a76-4a0d-b0a5-83cbd8a2b741)

Click on Browse

![Aspose Words ba282580-5f3d-413f-93f5-cedb57be876b 006](https://github.com/xavierflorensa/Optix_Winsock_Orcas_Server/assets/55208134/f2ca1c69-a188-4543-9823-534ae8abb325)

Select the dll

![Aspose Words ba282580-5f3d-413f-93f5-cedb57be876b 007](https://github.com/xavierflorensa/Optix_Winsock_Orcas_Server/assets/55208134/2a1ccfcb-54f6-43a4-a0c1-987312e6c1e6)

Verify that this is the right path

![Aspose Words ba282580-5f3d-413f-93f5-cedb57be876b 008](https://github.com/xavierflorensa/Optix_Winsock_Orcas_Server/assets/55208134/5ba81675-c77d-4b2f-aac4-3e18968bdb24)

Click Ok

Unfold assemblies

![Aspose Words ba282580-5f3d-413f-93f5-cedb57be876b 009](https://github.com/xavierflorensa/Optix_Winsock_Orcas_Server/assets/55208134/36080bcf-e6dc-4b3f-b23c-2806ba3300df)

You have it installed

![Aspose Words ba282580-5f3d-413f-93f5-cedb57be876b 010](https://github.com/xavierflorensa/Optix_Winsock_Orcas_Server/assets/55208134/af2db39e-46d8-4d81-813b-69c4308164a6)

Build the application (Do not build solution)

![Aspose Words ba282580-5f3d-413f-93f5-cedb57be876b 011](https://github.com/xavierflorensa/Optix_Winsock_Orcas_Server/assets/55208134/5bd6085a-24aa-420f-9b1b-a85f0a20688f)

You can close Visual Studio 2022

Change the code editor to Visual Studio Code in FT Optix Studio

Save close and open it again

Open Netlogic

![Aspose Words ba282580-5f3d-413f-93f5-cedb57be876b 012](https://github.com/xavierflorensa/Optix_Winsock_Orcas_Server/assets/55208134/69af0bbd-05c5-4920-ad70-ab50af9b8469)

Open references file \*.csproj

VS 2022 has done the dll installation for you without editing this \*.csproj file

![Aspose Words ba282580-5f3d-413f-93f5-cedb57be876b 013](https://github.com/xavierflorensa/Optix_Winsock_Orcas_Server/assets/55208134/d80b8218-5c81-479b-8007-87d9ee02e384)

## <a name="_toc156766294"></a><a name="_toc157019702"></a>2 Installing external references (dll libraries) into the project with Visual Studio code
Pending to test this way

How you add a reference depends on the project type for the code you're working on:

- If you see a **Dependencies** node in [**Solution Explorer**](https://learn.microsoft.com/en-us/visualstudio/ide/use-solution-explorer?view=vs-2022), you can use the right-click context menu to select **Add Project Reference**.

  ![Screenshot of the Add Project Reference option from the right-click context menu.](Aspose.Words.ba282580-5f3d-413f-93f5-cedb57be876b.014.png)
  
  ![Aspose Words ba282580-5f3d-413f-93f5-cedb57be876b 014](https://github.com/xavierflorensa/Optix_Winsock_Orcas_Server/assets/55208134/a2029104-b854-4a95-a009-93bca481d9a0)

- If you see a **References** node in [**Solution Explorer**](https://learn.microsoft.com/en-us/visualstudio/ide/use-solution-explorer?view=vs-2022), you can use the right-click context menu to select **Add Reference**.

  ![Screenshot of the Add Reference option from the right-click context menu.](Aspose.Words.ba282580-5f3d-413f-93f5-cedb57be876b.015.png)

  ![Aspose Words ba282580-5f3d-413f-93f5-cedb57be876b 015](https://github.com/xavierflorensa/Optix_Winsock_Orcas_Server/assets/55208134/7ee28544-5def-46d1-955f-4919330461e1)

For more information, see [How to: Add or remove references](https://learn.microsoft.com/en-us/visualstudio/ide/how-to-add-or-remove-references-by-using-the-reference-manager?view=vs-2022).
1. # <a name="_toc157019703"></a>Building the Server
As soon as you use this library, you can see some data from class Winsock\_Orcas

As you can see here, we have been able to see which one is the the Protocol used (TCP or UDP)

![Aspose Words ba282580-5f3d-413f-93f5-cedb57be876b 016](https://github.com/xavierflorensa/Optix_Winsock_Orcas_Server/assets/55208134/cf8c7eef-ae74-40b5-bc74-210289ac6c4e)


This is done with this code

At least we can have a dialog with the class to read, write data, when we hit the button.

Socket\_winsock

[ExportMethod]



`    `public void Send()

`    `{

`         `Log.Info("Hello World");

`         `winsock\_Ear.Listen(2000);//This is to make the PC act as host

`                                 `//winsock\_Ear.Connect("10.2.10.201", 2000); //This is to make the PC act as client



`        `Log.Info(winsock\_Ear.LocalIP.ToString());

`        `Log.Info("protocol"+winsock\_Ear.Protocol.ToString());

`        `Log.Info("Legacy support"+winsock\_Ear.LegacySupport.ToString());

`        `Log.Info("Hello World");

`        `string text\_to\_send = "Hello World";

`        `winsock\_Ear.Send(text\_to\_send);



`    `}

This is the complete code

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

using Winsock\_Orcas;

using System.Reflection.Emit;

using System.Net.Sockets;

using System.Net.Security;

#endregion

public class RuntimeNetLogic1 : BaseNetLogic

{



`    `Winsock winsock\_Ear = new Winsock();



`    `private void winsock\_Ear\_Connected(object sender, Winsock\_Orcas.WinsockConnectedEventArgs e)

`    `{

`        `Log.Info("Connected to slave!!");



`    `}

`    `[ExportMethod]



`    `public void Send()

`    `{

`         `Log.Info("Hello World");

`         `winsock\_Ear.Listen(2000);//This is to make the PC act as host

`                                 `//winsock\_Ear.Connect("10.2.10.201", 2000); //This is to make the PC act as client



`        `Log.Info(winsock\_Ear.LocalIP.ToString());

`        `Log.Info("protocol"+winsock\_Ear.Protocol.ToString());

`        `Log.Info("Legacy support"+winsock\_Ear.LegacySupport.ToString());

`        `Log.Info("Hello World");

`        `string text\_to\_send = "Hello World";

`        `winsock\_Ear.Send(text\_to\_send);



`    `}





`    `public void Start(object sender, EventArgs e)

`    `//public override void Start(object sender, EventArgs e)

`    `{









`       `winsock\_Ear.Listen(2000);//This is to make the PC act as host

`                                 `//winsock\_Ear.Connect("10.2.10.201", 2000); //This is to make the PC act as client



`        `// Insert code to be executed when the user-defined logic is started

`    `}

`    `public override void Stop()

`    `//public override void Stop()

`    `{

`         `Log.Info("Stopping");

`        `// Insert code to be executed when the user-defined logic is stopped

`    `}

`    `private void winsock\_Ear\_ConnectionRequest(object sender, WinsockConnectionRequestEventArgs e)

`    `{

`        `winsock\_Ear.Close();

`        `winsock\_Ear.Accept(e.Client);

`        `Log.Info("Connected to slave!!");

`    `}

`    `//private Winsock\_Orcas.Winsock winsock\_Ear;

`    `//public Winsock\_Orcas.Winsock winsock\_Ear;

}


If we change status of legacy support we see

![Aspose Words ba282580-5f3d-413f-93f5-cedb57be876b 017](https://github.com/xavierflorensa/Optix_Winsock_Orcas_Server/assets/55208134/23942f3a-76a9-404d-bf51-af3409ef1b9b)

![Aspose Words ba282580-5f3d-413f-93f5-cedb57be876b 018](https://github.com/xavierflorensa/Optix_Winsock_Orcas_Server/assets/55208134/86c33545-1f91-40eb-beb2-1502f074a788)

We must check if the server is listening on port 2000.

![Aspose Words ba282580-5f3d-413f-93f5-cedb57be876b 019](https://github.com/xavierflorensa/Optix_Winsock_Orcas_Server/assets/55208134/cb4975bd-e5cb-4265-ade8-c404175a5bf0)

We can even retrieve the IP from server host and from remote client

![Aspose Words ba282580-5f3d-413f-93f5-cedb57be876b 020](https://github.com/xavierflorensa/Optix_Winsock_Orcas_Server/assets/55208134/6408a2f1-7678-4251-a3f9-d4ad18bf9f4d)

[ExportMethod]



`    `public void Send()

`    `{

`         `Log.Info("Hello World");

`         `winsock\_Ear.Listen(2000);//This is to make the PC act as server host

`                                 `//winsock\_Ear.Connect("10.2.10.201", 2000); //This is to make the PC act as client



`        `winsock\_Ear.LegacySupport=true;

`        `Log.Info("LocalIP: "+winsock\_Ear.LocalIP[0]);

`        `Log.Info("protocol: "+winsock\_Ear.Protocol.ToString());

`        `Log.Info("Legacy support: "+winsock\_Ear.LegacySupport.ToString());

`        `Log.Info("LocalPort: "+winsock\_Ear.LocalPort.ToString());

`        `Log.Info("Remote Host: "+winsock\_Ear.RemoteHost.ToString());

`        `Log.Info("Remote Port: "+winsock\_Ear.RemotePort.ToString());

`        `Log.Info("State: "+winsock\_Ear.State.ToString());

`        `Log.Info("Hello World");

`        `string text\_to\_send = "Hello World";

`        `winsock\_Ear.Send(text\_to\_send);



`    `}


Let’s improve the code

Let’s try to put the code on the start program

This works accepting connections but not more else

public class RuntimeNetLogic1 : BaseNetLogic

{



`    `//Winsock winsock\_Ear = new Winsock();



`    `private void winsock\_Ear\_Connected(object sender, Winsock\_Orcas.WinsockConnectedEventArgs e)

`    `{

`        `Log.Info("Connected to slave!!");



`    `}

`    `[ExportMethod]



`    `public void Send()

`    `{

`        `/\*

`         `Log.Info("Hello World");

`         `winsock\_Ear.Listen(2000);//This is to make the PC act as server host

`                                 `//winsock\_Ear.Connect("10.2.10.201", 2000); //This is to make the PC act as client



`        `winsock\_Ear.LegacySupport=true;

`        `Log.Info("LocalIP: "+winsock\_Ear.LocalIP[0]);

`        `Log.Info("protocol: "+winsock\_Ear.Protocol.ToString());

`        `Log.Info("Legacy support: "+winsock\_Ear.LegacySupport.ToString());

`        `Log.Info("LocalPort: "+winsock\_Ear.LocalPort.ToString());

`        `Log.Info("Remote Host: "+winsock\_Ear.RemoteHost.ToString());

`        `Log.Info("Remote Port: "+winsock\_Ear.RemotePort.ToString());

`        `Log.Info("State: "+winsock\_Ear.State.ToString());

`        `Log.Info("Hello World");

`        `while (true)

`        `{

`        `string text\_to\_send = "Hello World";

`        `winsock\_Ear.Send(text\_to\_send);

`        `System.Threading.Thread.Sleep(1000);

`        `}

`        `\*/

`    `}





`    `public override void Start()

`    `//public override void Start(object sender, EventArgs e)

`    `{

`       `Winsock winsock\_Ear = new Winsock();

`       `winsock\_Ear.LegacySupport=true;



`       `winsock\_Ear.Listen(2000);//This is to make the PC act as host

`                                 `//winsock\_Ear.Connect("10.2.10.201", 2000); //This is to make the PC act as client



`        `Log.Info("LocalIP: "+winsock\_Ear.LocalIP[0]);

`        `Log.Info("protocol: "+winsock\_Ear.Protocol.ToString());

`        `Log.Info("Legacy support: "+winsock\_Ear.LegacySupport.ToString());

`        `Log.Info("LocalPort: "+winsock\_Ear.LocalPort.ToString());

`        `Log.Info("Remote Host: "+winsock\_Ear.RemoteHost.ToString());

`        `Log.Info("Remote Port: "+winsock\_Ear.RemotePort.ToString());

`        `Log.Info("State: "+winsock\_Ear.State.ToString());

`        `Log.Info("Hello World");

`        `/\*

`        `while (true)

`        `{

`        `string text\_to\_send = "Hello World";

`        `winsock\_Ear.Send(text\_to\_send);

`        `System.Threading.Thread.Sleep(1000);

`        `} 

`        `\*/

`    `}

`    `public override void Stop()

`    `//public override void Stop()

`    `{

`         `Log.Info("Stopping");

`        `// Insert code to be executed when the user-defined logic is stopped

`    `}

`    `private void winsock\_Ear\_ConnectionRequest(object sender, WinsockConnectionRequestEventArgs e)

`    `{

`        `//winsock\_Ear.Close();

`        `//winsock\_Ear.Accept(e.Client);

`        `Log.Info("Connected to slave!!");

`    `}

`    `//private Winsock\_Orcas.Winsock winsock\_Ear;

`    `//public Winsock\_Orcas.Winsock winsock\_Ear;

}


EventArgs e is a parameter called e that contains the event data, see the EventArgs MSDN page for more information.

Object Sender is a parameter called Sender that contains a reference to the control/object that raised the event.

You can download the code from here

<https://github.com/xavierflorensa/Optix_Winsock_Orcas_Server.git>

Let’s deal with events,

![Aspose Words ba282580-5f3d-413f-93f5-cedb57be876b 021](https://github.com/xavierflorensa/Optix_Winsock_Orcas_Server/assets/55208134/939472af-94de-49d1-804f-1141966539e9)

Now we can send whatever messages we want from server

You have to change the application and add this sentence

To assign a callback that be executed after first connectionrequest

` `public override void Start()

`    `{

`       `winsock\_Ear.LegacySupport=true;



`       `winsock\_Ear.Listen(2000);//This is to make the PC act as host

`                                 `//winsock\_Ear.Connect("10.2.10.201", 2000); //This is to make the PC act as client

`        `// Assign a callback to be excuted when the client is connected

`        `//Winsock\_Ear.Connected += winsock\_Ear\_Connected;

`        `// Assign a callback to be executed when a message is received from the server

`        `winsock\_Ear.ConnectionRequest += winsock\_Ear\_ConnectionRequest;

This is the complete code

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

using Winsock\_Orcas;

using System.Reflection.Emit;

using System.Net.Sockets;

using System.Net.Security;

using System.Net.Http;

#endregion

public class RuntimeNetLogic1 : BaseNetLogic

{

`    `Winsock winsock\_Ear = new Winsock(); //opens a new socket



`    `[ExportMethod]



`    `public void Send()

`    `{

`        `string text\_to\_send = "Hello World";

`        `winsock\_Ear.Send(text\_to\_send);

`    `}

`    `public override void Start()

`    `{

`       `winsock\_Ear.LegacySupport=true;



`       `winsock\_Ear.Listen(2000);//This is to make the PC act as host

`                                 `//winsock\_Ear.Connect("10.2.10.201", 2000); //This is to make the PC act as client

`        `// Assign a callback to be excuted when the client is connected

`        `//Winsock\_Ear.Connected += winsock\_Ear\_Connected;

`        `// Assign a callback to be executed when a message is received from the server

`        `winsock\_Ear.ConnectionRequest += winsock\_Ear\_ConnectionRequest;

`        `Log.Info("LocalIP: "+winsock\_Ear.LocalIP[0]);

`        `Log.Info("protocol: "+winsock\_Ear.Protocol.ToString());

`        `Log.Info("Legacy support: "+winsock\_Ear.LegacySupport.ToString());

`        `Log.Info("LocalPort: "+winsock\_Ear.LocalPort.ToString());

`        `Log.Info("Remote Host: "+winsock\_Ear.RemoteHost.ToString());

`        `Log.Info("Remote Port: "+winsock\_Ear.RemotePort.ToString());

`        `Log.Info("State: "+winsock\_Ear.State.ToString());

`        `Log.Info("Hello World");

`        `string text\_to\_send = "Hello World";

`        `winsock\_Ear.Send(text\_to\_send);

`    `}

`    `public override void Stop()

`    `{

`         `Log.Info("Stopping");



`    `}



`    `private void winsock\_Ear\_Connected(object sender, Winsock\_Orcas.WinsockConnectedEventArgs e)

`    `{

`        `Log.Info("Connected to slave!!");



`    `}

`    `private void winsock\_Ear\_ConnectionRequest(object sender, Winsock\_Orcas.WinsockConnectionRequestEventArgs e)

`        `{

`            `winsock\_Ear.Close();

`            `winsock\_Ear.Accept(e.Client);

`        `}

`    `private void winsock\_Ear\_DataArrival(object sender, Winsock\_Orcas.WinsockDataArrivalEventArgs e)

`        `{

`            `string abRecibidos = winsock\_Ear.Get<string>();

`            `Log.Info(abRecibidos);



`        `}

`    `private Winsock Winsock\_Ear;

`    `//private Winsock\_Orcas.Winsock winsock\_Ear;

`    `//public Winsock\_Orcas.Winsock winsock\_Ear;

}


Let’s try the client application with those callbacks

[A screenshot of a computer

Description automatically generated]: Aspose.Words.ba282580-5f3d-413f-93f5-cedb57be876b.001.png
