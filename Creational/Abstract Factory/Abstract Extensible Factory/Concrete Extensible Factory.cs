using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConcreteExtensibleFactory : Singleton<ConcreteExtensibleFactory> , AbstractExtensibleFactoryInterface
{
    public ProductAbstract Make(string classIdentifier)
    {
        switch (classIdentifier)
        {
            case "A":
                return new ProductAExtensible();
            case "B":
                return new ProductBExtensible();
            default:
                throw new NotImplementedException();
        }
    }
}
