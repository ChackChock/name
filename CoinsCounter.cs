using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CoinsCounter : MonoBehaviour
{
    private int coins;

    public void CollectCoins()
    {
        coins++;
        print("Собранные монетки: " + coins);
    }
}