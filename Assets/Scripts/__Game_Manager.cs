using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class __Game_Manager : MonoBehaviour
{

    __Player_Manager Player1 = new __Player_Manager();
    public List<Text> PlayerNames = new List<Text>();
    public  List<string> OutputTexts = new List<string>();
    public List<Text> OutputNames = new List<Text>();
    public Text text1;
    public Text test;
    // Start is called before the first frame update
    void Start()
    {
       
        /* __Player_Manager Player2 = new __Player_Manager();
         __Player_Manager Player3 = new __Player_Manager();
         __Player_Manager Player4 = new __Player_Manager();
         __Player_Manager Player5 = new __Player_Manager();
         __Player_Manager Player6 = new __Player_Manager();
         __Player_Manager Player7 = new __Player_Manager();
         __Player_Manager Player8 = new __Player_Manager();
         __Player_Manager Player9 = new __Player_Manager();
         __Player_Manager Player10 = new __Player_Manager();
         __Player_Manager Player11 = new __Player_Manager();
         __Player_Manager Player12 = new __Player_Manager();
         __Player_Manager Player13 = new __Player_Manager();
         __Player_Manager Player14 = new __Player_Manager();
         __Player_Manager Player15 = new __Player_Manager();
         __Player_Manager Player16 = new __Player_Manager();
         */

      
        /*
        Player1.CreatePlayer(1, PlayerNames[1]);
        Player1.CreatePlayer(2, Player2Name);
        Player1.CreatePlayer(3, Player2Name);
        Player1.CreatePlayer(4, Player2Name);
        */
        
    }

public void RandomizePlayers()
    {

        for (int i = 0; i < 16; i++)
        {
            Player1.CreatePlayer(i, PlayerNames[i].text);
        }
        StartCoroutine(WaitThree());

    }



    IEnumerator WaitThree()
    {
        print(Time.time);



        List<__Player_Manager.TFTPlayer> InputList = new List<__Player_Manager.TFTPlayer>();
        //List<Text> OutputList = new List<Text>();

        InputList.AddRange(__Player_Manager.Players);

        for (int i = 0; i < 16; i++)
        {
            __Player_Manager.TFTPlayer temp = InputList[i];
            int randomIndex = Random.Range(i, InputList.Count);
            __Player_Manager.TFTPlayer tmp = InputList[i];
            InputList[i] = InputList[randomIndex];
            InputList[randomIndex] = tmp;
            OutputTexts[i] = InputList[i].League_Name;
            OutputNames[i].text = InputList[i].League_Name;
            yield return new WaitForSeconds(2);
            //OutputList[i].text = InputList[i].League_Name;

              Debug.Log("Element  " + i + "  " + InputList[i].League_Name);
        }

        yield return new WaitForSeconds(3);
        print(Time.time);
    }


    // Update is called once per frame
    void Update()
    {
     
    }
}
