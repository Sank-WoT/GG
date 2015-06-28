﻿var remoteIP = "127.0.0.1";
var remotePort = 25000;
var listenPort = 25000;
var useNAT = false;
var yourIP = "";
var yourPort = "";

function OnGUI ()
{
if(Network.peerType == NetworkPeerType.Disconnected)
{
if(GUI.Button(new Rect(10,10,100,30),"Connect"))
{
Network.useNat = useNAT;
Network.Connect(remoteIP, remotePort);
}
if(GUI.Button(new Rect(10,50,100,30),"Start Server"))
{
Network.useNat = useNAT;
Network.InitializeServer(32, listenPort);
for(var go : GameObject in FindObjectsOfType(GameObject))
{
go.SendMessage("OnNetworkLoadedLevel", SendMessageOptions.DontRequireReceiver);
}
}
remoteIP = GUI.TextField(new Rect(120,10,100,20),remoteIP);
remotePort = parseInt(GUI.TextField(new Rect(230,10,40,20),remotePort.ToString()));
}
else
{
var ipaddress = Network.player.ipAddress;
var port = Network.player.port.ToString();
GUI.Label(new Rect(140,20,250,40),"IP:"+ipaddress+":"+port);
if(GUI.Button(new Rect(10,10,100,50),"Disconnect"))
{
Network.Disconnect(200);
}
}
}
function OnConnectedToServer()
{
for(var go : GameObject in FindObjectsOfType(GameObject))
go.SendMessage("OnNetworkLoadedLevel", SendMessageOptions.DontRequireReceiver);
}
