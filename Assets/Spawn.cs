using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour {
	public GameObject Triangle;
	int n = 0;

	void Update () {
		if (Input.GetMouseButtonDown(0) && n < 32) {
			if (n > 0) {
				for (int i = 0; i <= n; i++) {
					if (binomialCoeff((ulong)n,(ulong)i)%2==1) { //is odd
						Instantiate(Triangle, new Vector2(Triangle.GetComponent<SpriteRenderer>().bounds.size.x*(i-(n/2f)), n*-1*Triangle.GetComponent<SpriteRenderer>().bounds.size.y), Quaternion.identity);
					}
				}
			}else {
				Instantiate(Triangle, new Vector2(0, 0), Quaternion.identity);
			}
			n++;
		}
	}

	static ulong binomialCoeff(ulong n, ulong k) { 
        ulong res = 1; 

		if (k > n - k)
       		k = n - k;     
       	for (ulong i = 0; i < k; ++i) { 
        	res *= (n - i); 
        	res /= (i + 1); 
    	} 
    	return res; 
    } 
}