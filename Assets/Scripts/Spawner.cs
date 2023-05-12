using UnityEngine;

public class Spawner : MonoBehaviour
{
	public GameObject powerupPrefab;
	public GameObject obstaclePrefab;
	public float spawncycle = .5f;

	GameManager manager;
	float elapsedTime;
	bool spawnPowerup=true;

	void Start()
	{
		manager = GetComponent<GameManager>();
	}

	void Update()
		{
			elapsedTime += Time.deltaTime;
				if(elapsedTime > spawncycle)
				{
			 		GameObject temp;
				
			 		if (spawnPowerup)
						temp = Instantiate(powerupPrefab) as GameObject;
					else
						temp = Instantiate(obstaclePrefab) as GameObject;

					Vector3 position = temp.transform.position;
					position.x = Random.Range(-3f,3f);
					temp.transform.position = position;

					Collidable col = temp.GetComponent<Collidable>();
					col.manager = manager;
					elapsedTime = 0;
					spawnPowerup = !spawnPowerup;
		}
	}
}	
