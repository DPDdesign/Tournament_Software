using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class __Player_Manager 
{
    public static List<TFTPlayer> Players = new List<TFTPlayer>();

    TFTPlayer ErrorPlayer = new TFTPlayer();

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

    public TFTPlayer ReturnPlayerWithID(int ID)
    {
        foreach (TFTPlayer k  in Players){
            if (k.ID ==  ID){
                return k; } 
        } 

        return ErrorPlayer;
    }

    
    // Start is called before the first frame update
    void Start()
    {
        ErrorPlayer.ID = 404;
        ErrorPlayer.Discord_Name = "ErrorPlayerName";
        ErrorPlayer.League_Name = "ErrorPlayerName";
    }

    // Update is called once per frame
    void Update()
    {
   
    }
}
