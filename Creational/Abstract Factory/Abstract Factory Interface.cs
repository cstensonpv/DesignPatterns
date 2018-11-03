using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface AbstractFactoryInterface {
    /*
     * Usually done as an abstract class, however since we want to use the
     * Singleton pattern through inheritance I wanted to do it this way.
     */

    ProductAAbstract CreateProductA();
    ProductBAbstract CreateProductB();
}
