using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConcreteFactory : Singleton<ConcreteFactory> , AbstractFactoryInterface
{
    public virtual ProductAAbstract CreateProductA()
    {
        return new ProductA();
    }

    public virtual ProductBAbstract CreateProductB()
    {
        return new ProductB();
    }
}
