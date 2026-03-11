using UnityEngine;

public class InventoryManager : MonoBehaviour
{

    public bool debugEnabled = false;

    public static InventoryManager Instance;// allows access to a global connection point to inventory manager
    [Header("Inventory")]
    [SerializeField] public int Gems = 0; //outputs the gem count to the players inspector


    void Awake() 
    { 
        Instance = this; //initalizes the gcp
    }



}
