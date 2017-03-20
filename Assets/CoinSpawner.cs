using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinSpawner : MonoBehaviour {

	public int coinsInStack = 15;
	public GameObject coin;

	private GameObject[] coinStack;

	void Start () {

		coinStack = new GameObject[coinsInStack];

		for (int i = 0; i < coinsInStack; i ++) {

			coinStack [i] = SpawnCoin();
			coinStack [i].transform.Translate (
				0.18f * i, 
				0, 
				0 
			);

		}

	}

	private GameObject SpawnCoin () {

		return Instantiate(coin);

	}

	void Update () {
		
	}
}
