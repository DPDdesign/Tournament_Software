using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class __Player_Manager 
{
    public static List<TFTPlayer> Players = new List<TFTPlayer>();
  
    public class TFTPlayer
    {
        public int ID;
        public int Points;
        public int Place;
        public string Discord_Name;
        public string League_Name;
        public int TempPlace;
    }

    public void CreatePlayer(int ID, string LeaugeName)
    {
       
        TFTPlayer player = new TFTPlayer();
        player.ID = ID;
        player.League_Name = LeaugeName;
        player.Points = 0;
        Players.Add(player);
    }

    public string ReturnPlayerNameWithID(int ID)
    {
        string error = "brak gracza";

        foreach (TFTPlayer k  in Players){
            if (k.ID ==  ID){
                return k.League_Name; } 
        } 

        return error;
    }

    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
