using UnityEngine;
using System.Collections;
using DG.Tweening;

public class SwipeMove : MonoBehaviour {

	public Transform player; // Drag your player here
	private Vector2 fp; // first finger position
	private Vector2 lp; // last finger position
	private float angle;
	private float swipeDistanceX;
	private float swipeDistanceY;
	public float movementSpeed = 1.0f;
	private float t = 0;

	void Start()
	{
		// Initialize DOTween (needs to be done only once).
		// If you don't initialize DOTween yourself,
		// it will be automatically initialized with default values.
		DOTween.Init(false, true, LogBehaviour.ErrorsOnly);

		// Create two identical infinitely looping tweens,
		// one with the shortcuts way and the other with the generic way.
		// Both will be set to "relative" so the given movement will be calculated
		// relative to each target's position.

		// cubeA > SHORTCUTS WAY
		//cubeA.DOMove(new Vector3(-2, 2, 0), 1).SetRelative().SetLoops(-1, LoopType.Yoyo);

		// cubeB > GENERIC WAY
		//DOTween.To(()=> cubeB.position, x=> cubeB.position = x, new Vector3(-2, 2, 0), 1).SetRelative().SetLoops(-1, LoopType.Yoyo);

		// Voilà.
		// To see all available shortcuts check out DOTween's online documentation.
	}


	void Update () {
		foreach(Touch touch in Input.touches)
		{
			if (touch.phase == TouchPhase.Began)
			{
				fp = touch.position;
				lp = touch.position;
			}
			if (touch.phase == TouchPhase.Moved )
			{
				lp = touch.position;
				swipeDistanceX = Mathf.Abs((lp.x-fp.x));
				swipeDistanceY = Mathf.Abs((lp.y-fp.y));
			}

			if(touch.phase == TouchPhase.Ended)
			{
				angle = Mathf.Atan2((lp.x-fp.x),(lp.y-fp.y))*57.2957795f;

				transform.rotation = Quaternion.Euler(0,angle,0);


				
				//player.DOMove (new Vector3 (player.transform.position.x, player.transform.position.y, (player.transform.position.z+movementSpeed)), 0.5f, false);
				player.transform.position += player.transform.forward * Time.deltaTime * movementSpeed;

				
				/*if(angle > 60 && angle < 120 && swipeDistanceX > 40    )
				{
					print ("right");
					player.Rotate(0,45,0);
				}
				if(angle > 150 || angle < -150 && swipeDistanceY > 40)
				{
					print ("down");
					player.position+=new Vector3(0,-2,0);
				}
				if(angle < -60 && angle > -120 && swipeDistanceX > 40)
				{
					print ("left");
					player.Rotate(0,-45,0);
				}
				if(angle > -30 && angle < 30 && swipeDistanceY > 40)
				{
					print ("up");
					player.position+=new Vector3(0,2,0);
				}*/
			}
		}
	}
}