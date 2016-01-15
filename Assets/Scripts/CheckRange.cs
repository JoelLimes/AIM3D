using UnityEngine;
using System.Collections;

public class CheckRange : MonoBehaviour {
	[SerializeField]private GameObject _player;
	private float _maxDistance = 25.0f;
	private float _currentTime;
	private bool _hasFound;
	// Use this for initialization
	void Start () {
		StartCoroutine (CheckIfInRange ());
	}

	IEnumerator CheckIfInRange() {
		while (!_hasFound) {
			if (Vector3.Distance (transform.position, _player.transform.position) < _maxDistance) {
				StartCoroutine(InRange(4.0f));
				_hasFound = true;
				yield return new WaitForEndOfFrame();
			}
		}
	}

	IEnumerator InRange(float wtime) {
		_currentTime = 0;
		while (_currentTime < wtime) {
			Debug.Log("In while loop");
			_currentTime+=Time.deltaTime;
			if(Vector3.Distance(transform.position, _player.transform.position) > _maxDistance) {
				_hasFound = false;
				StopCoroutine("CheckIfInRange");
//				StartCoroutine(CheckIfInRange());
				break;
			}

			yield return new WaitForEndOfFrame();
		}

		Debug.Log ("is catched");
		StopCoroutine ("CheckIfInRange");

	}
}

/**
* ...
* @author Joel Limes
* ...
**/
