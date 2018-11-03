using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Client : MonoBehaviour {

    
	// Use this for initialization
	void Start () {
        ProductAAbstract a = ConcreteFactory.Instance.CreateProductA();
        ProductBAbstract b = ConcreteFactory.Instance.CreateProductB();

        Debug.Log(a);
        Debug.Log(b);

        //Not needed to show pattern
        ProductAAbstract asc = ConcreteFactoryNew.Instance.CreateProductA();
        ProductBAbstract bsc = ConcreteFactoryNew.Instance.CreateProductB();

        Debug.Log(asc);
        Debug.Log(bsc);

        ProductAbstract ax = ConcreteExtensibleFactory.Instance.Make("A");
        ProductAbstract bx = ConcreteExtensibleFactory.Instance.Make("B");

        Debug.Log(ax);
        Debug.Log(bx);
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
