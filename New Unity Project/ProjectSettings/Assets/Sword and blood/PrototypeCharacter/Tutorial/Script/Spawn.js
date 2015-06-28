#pragma strict

// Add this script to a Parent GameObject of the spawnPoints.
// Note: enemyPrefab will have an AI script attached which will already Tag the Player object 
// so it won't be needed here.

public var spawnPoints : Transform[];  // Array of spawn points to be used.
public var enemyPrefabs : GameObject[]; // Array of different Enemies that are used.
public var amountEnemies = 20;  // Total number of enemies to spawn.
public var yieldTimeMin = 2;  // Minimum amount of time before spawning enemies randomly.
public var yieldTimeMax = 5;  // Don't exceed this amount of time between spawning enemies randomly.
private var i : int;

function Start()
{
    Spawn();
}

public function Spawn() 
{ 
   for (i=0; i<amountEnemies; i++) // How many enemies to instantiate total.
   {
      yield WaitForSeconds(Random.Range(yieldTimeMin, yieldTimeMax));  // How long to wait before another enemy is instantiated.

      var obj : GameObject = enemyPrefabs[Random.Range(0, enemyPrefabs.length)]; // Randomize the different enemies to instantiate.
      var pos: Transform = spawnPoints[Random.Range(0, spawnPoints.length)];  // Randomize the spawnPoints to instantiate enemy at next.

      Instantiate(obj, pos.position, pos.rotation); 
      
}
}  