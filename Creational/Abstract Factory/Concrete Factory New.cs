using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConcreteFactoryNew : Singleton<ConcreteFactoryNew>, AbstractFactoryInterface
{
    public ProductAAbstract CreateProductA()
    {
        return new ProductANew();
    }

    public ProductBAbstract CreateProductB()
    {
        return new ProductBNew();
    }
}
