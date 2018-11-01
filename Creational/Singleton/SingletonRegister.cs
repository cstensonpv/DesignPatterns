using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class SingletonRegister
{
    private static SingletonRegister instance;
    private static List<NameSingletonPair> _registry;

    public static void Register(char name, Singleton s)
    {
        //Needs to be registred correctly at startup.
        //check so not in registry
        _registry.Add(new NameSingletonPair(name, s));
    }

    public static Singleton Lookup(char name)
    {
        //can be done nicer
        //var book = books.Where(book => book.author == search).FirstOrDefault();
        NameSingletonPair sp = _registry.Where(n => n.name == name).FirstOrDefault();
        return sp.singleton;
    }

    public static SingletonRegister Instance
    {
        get
        {
            if(instance == null)
            {
                instance = new SingletonRegister();
            }
            return instance;
        }
    }


}

internal class NameSingletonPair
{
    internal char name;
    internal Singleton singleton;

    public NameSingletonPair(char name, Singleton s)
    {
        this.name = name;
        this.singleton = s;
    }
}
