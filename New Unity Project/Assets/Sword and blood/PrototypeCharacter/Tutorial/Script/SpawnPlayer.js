var pgo: GameObject;

function OnNetworkLoadedLevel()
{

Network.Instantiate(pgo, transform.position, transform.rotation, 0);
}

function OnPlayerDisconnected(player : NetworkPlayer)
{
Network.RemoveRPCs(player, 0);
Network.DestroyPlayerObjects(player);
}
