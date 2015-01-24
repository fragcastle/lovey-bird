using UnityEngine;
using System.Collections;

public class PlatformDirector : BaseBehavior
{
    private GameObject _player;

    private float _lastX = 2;
    private float _distanceToGenerate = 10;
    
	private bool _generateMailbox = false;
	
	public Transform HouseSmall;
	public Transform HouseMedium;
	public Transform HouseLarge;
	public Transform Mailbox;

    public float PlatformRangeMin = 0.25F;
    public float PlatformRange = 0.35F;
    
    public float ChanceForBrokenPlatform = 0.1F;
    public float ChanceForBouncyPlatform = 0.15F;
    
    public float ChanceForDeadPlatform = 0.01F;

	public static PlatformDirector Current;

    void Start()
    {
        _player = GameObject.Find("Player");
		Current = this;
    }

    void Update()
    {
        if (!_player)
            return;

        var playerPosition = _player.transform.position;

        // Generate the first platform in the center of screen
		if (_lastX == 0)
        {
			var platform = (Transform)Instantiate(HouseSmall, new Vector3(transform.position.x, _lastX, transform.position.z), Quaternion.identity);

            platform.parent = transform;
        }
		
		
		
		while (_lastX < playerPosition.x + _distanceToGenerate)
        {
			_lastX += PlatformRangeMin + (PlatformRange * Random.value);

			var random = Random.value;

			Transform newObject;
			
			if (_generateMailbox)
			{
				newObject = (Transform)Instantiate(Mailbox, new Vector3(_lastX, -2.3F, transform.position.z), Quaternion.identity);
			}
			else if (random > 0.66)
			{
				newObject = (Transform)Instantiate(HouseSmall, new Vector3(_lastX, transform.position.y, transform.position.z), Quaternion.identity);
			}
			else if (random > 0.33)
			{
				newObject = (Transform)Instantiate(HouseMedium, new Vector3(_lastX, transform.position.y, transform.position.z), Quaternion.identity);
			}
			else 
			{
				newObject = (Transform)Instantiate(HouseLarge, new Vector3(_lastX, transform.position.y, transform.position.z), Quaternion.identity);
			}

			newObject.parent = transform;
			
			_generateMailbox = !_generateMailbox;
        }
    }
}
