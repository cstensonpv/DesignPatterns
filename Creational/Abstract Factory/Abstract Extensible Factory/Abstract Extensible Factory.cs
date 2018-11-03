using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface AbstractExtensibleFactoryInterface {

    ProductAbstract Make(string classIdentifier);
}
