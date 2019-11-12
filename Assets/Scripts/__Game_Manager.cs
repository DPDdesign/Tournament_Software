using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class __Game_Manager : MonoBehaviour
{

    __Player_Manager Player1 = new __Player_Manager();

    public int players_number;
    int teamsize = 8;
    public int round;

    public List<Text> PlayerNames = new List<Text>();

    public List<List<Text>> PlayerList = new List<List<Text>>();





    #region UI

    public List<GameObject> Panels = new List<GameObject>();
    string[] DisplayDescriptions = { "Sign Up", "Results", "Round 1", "Round 2", "Round 3", "Round 4", "Round 5" };
    public Text DisplayText;

    public void ActivatePanel(int i)
    {
        int j = 0;
        foreach (GameObject panel in Panels)
        {
            Panels[j].SetActive(false);
            j++;
        }
        Panels[i].SetActive(true);
        DisplayText.text = DisplayDescriptions[i];
    }

    #endregion


    public List<List<List<__Player_Manager.TFTPlayer>>> ListOfPlayersInRound = new List<List<List<__Player_Manager.TFTPlayer>>>();

    public List<List<__Player_Manager.TFTPlayer>> ListOfTeams = new List<List<__Player_Manager.TFTPlayer>>();

    public List<__Player_Manager.TFTPlayer> Team1 = new List<__Player_Manager.TFTPlayer>();
    public List<__Player_Manager.TFTPlayer> Team2 = new List<__Player_Manager.TFTPlayer>();
    public List<__Player_Manager.TFTPlayer> Team3 = new List<__Player_Manager.TFTPlayer>();
    public List<__Player_Manager.TFTPlayer> Team4 = new List<__Player_Manager.TFTPlayer>();
    public List<__Player_Manager.TFTPlayer> Team5 = new List<__Player_Manager.TFTPlayer>();


    List<List<List<Text>>> DisplayNames = new List<List<List<Text>>>();

    List<List<Text>> DisplayNamesR1 = new List<List<Text>>();
    List<List<Text>> DisplayNamesR2 = new List<List<Text>>();
    List<List<Text>> DisplayNamesR3 = new List<List<Text>>();

    public List<Text> R1T1 = new List<Text>();
    public List<Text> R1T2 = new List<Text>();

    public List<Text> R2T1 = new List<Text>();
    public List<Text> R2T2 = new List<Text>();

    public List<Text> R3T1 = new List<Text>();
    public List<Text> R3T2 = new List<Text>();



 
    

   // public List<Text> R4T1 = new List<Text>();
    

    public Text text1;
    public Text test;
    // Start is called before the first frame update
    void Start()
    {

        AddTeamsToList();
    }


    void AddTeamsToList()
    {
        ListOfTeams.Add(Team1);
        ListOfTeams.Add(Team2);
        ListOfTeams.Add(Team3);
        ListOfTeams.Add(Team4);
        ListOfTeams.Add(Team5);

        DisplayNamesR1.Add(R1T1);
        DisplayNamesR1.Add(R1T2);

        DisplayNamesR2.Add(R2T1);
        DisplayNamesR2.Add(R2T2);

        DisplayNamesR3.Add(R3T1);
        DisplayNamesR3.Add(R3T2);

        DisplayNames.Add(DisplayNamesR1);
        DisplayNames.Add(DisplayNamesR2);
        DisplayNames.Add(DisplayNamesR3);
    }

    public void GeneratePlayers(int n) {
        players_number = n;

        for (int i = 0; i < players_number; i++) {
            Player1.CreatePlayer(i, PlayerNames[i].text);
        }
    }


    public void RandomizePlayers()
    {
        List<__Player_Manager.TFTPlayer> InputList = new List<__Player_Manager.TFTPlayer>();
        InputList.AddRange(__Player_Manager.Players);


        for (int i = 0; i < players_number; i++)
        {
            __Player_Manager.TFTPlayer temp = InputList[i];
            int randomIndex = Random.Range(i, InputList.Count);
            __Player_Manager.TFTPlayer tmp = InputList[i];
            InputList[i] = InputList[randomIndex];
            InputList[randomIndex] = tmp;
        }

        int k = 0;

        for (int i = 0; i < players_number/8; i++)
        {            
            for(int j =0; j< teamsize; j++)
            {
                Debug.Log(InputList[k].League_Name);
                ListOfTeams[i].Add(InputList[k]);           
                k++;
            }

        }
        ListOfPlayersInRound.Add(ListOfTeams);
        WritePlayers();

        ListOfTeams.Clear();
        Team1.Clear();
        Team2.Clear();
        AddTeamsToList();

    }

    public void SetRound(int i)
    {
        round = i;
    }

    public void WritePlayers()
    {


        Debug.Log("WPISUJE");
        for (int i = 0; i < teamsize; i++)
        {
            // Debug.Log(i + Team1[i].League_Name);
            Debug.Log("runda:   " + round);
            DisplayNames[round][0][i].text = ListOfPlayersInRound[round][0][i].League_Name;
            DisplayNames[round][1][i].text = ListOfPlayersInRound[round][1][i].League_Name;
            // Team3Names[i].text = Team3[i].League_Name;
            //Team4Names[i].text = Team4[i].League_Name;

        }


}









    public void temporaryvoid()
    {

    }


    IEnumerator WaitThree()
    {
        print(Time.time);
        yield return new WaitForSeconds(3);
        print(Time.time);
    }


    // Update is called once per frame
    void Update()
    {
     
    }
}
