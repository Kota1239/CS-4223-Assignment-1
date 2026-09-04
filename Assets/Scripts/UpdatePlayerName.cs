using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UpdatePlayerName : MonoBehaviour
{
    public Text nameTextBox;

    void Start()
    {
        nameTextBox.text = "Player: " + GlobalSettings.GetPlayerName();
    } 
}
