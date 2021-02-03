using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class Pnach : MonoBehaviour
{
    int STTCount = 0;
    int TTCount = 0;
    int HBCount = 0;
    int LoDCount = 0;
    int BCCount = 0;
    int OCCount = 0;
    int DCCount = 0;
    int PRCount = 0;
    int AGCount = 0;
    int HTCount = 0;
    int PLCount = 0;
    int AtlanticaCount = 0;
    int hundredacreCount = 0;
    int SPCount = 0;
    int TWTNWCount = 0;
    int FormsCount = 0;
    int LevelsCount = 0;
    List<string> keyItems = new List<string>();
    List<string> Free = new List<string>();
    List<string> STT = new List<string>();
    public List<string> STTItems = new List<string>();
    List<string> TT = new List<string>();
    public List<string> TTItems = new List<string>();
    List<string> HB = new List<string>();
    public List<string> HBItems = new List<string>();
    List<string> LoD = new List<string>();
    public List<string> LoDItems = new List<string>();
    List<string> BC = new List<string>();
    public List<string> BCItems = new List<string>();
    List<string> OC = new List<string>();
    public List<string> OCItems = new List<string>();
    List<string> DC = new List<string>();
    public List<string> DCItems = new List<string>();
    List<string> PR = new List<string>();
    public List<string> PRItems = new List<string>();
    List<string> AG = new List<string>();
    public List<string> AGItems = new List<string>();
    List<string> HT = new List<string>();
    public List<string> HTItems = new List<string>();
    List<string> PL = new List<string>();
    public List<string> PLItems = new List<string>();
    List<string> Atlantica = new List<string>();
    public List<string> ATItems = new List<string>();
    List<string> hundredacre = new List<string>();
    public List<string> HundredItems = new List<string>();
    List<string> SP = new List<string>();
    public List<string> SPItems = new List<string>();
    List<string> TWTNW = new List<string>();
    public List<string> TWTNWItems = new List<string>();
    List<string> Forms = new List<string>();
    public List<string> FormItems = new List<string>();
    List<string> Levels = new List<string>();
    public List<string> LevelItems = new List<string>();
    List<string> importantchecks = new List<string>();    
    string pnachpath;    
    string hintpath;
    public bool read = false;

    // Start is called before the first frame update
    void Start()
    {
        pnachpath = Application.persistentDataPath;
        hintpath = Application.persistentDataPath;
        Code();
        pnachpath += "/F266B00B.pnach";
        hintpath += "/Help.txt";
        read = false;     
    }

    // Update is called once per frame
    void Update()
    {
        if (!read)
        {
            Function();
            read = true;
        }
    }


    void Function()
    {
        StreamReader sr = new StreamReader(pnachpath);
        string line;
        do
        {
            line = sr.ReadLine();
            string[] parts = line.Split(new[] { ',' });
            if (parts.Length == 5)
            {
                for (int i = 0; i < keyItems.Count; i++)
                {
                    if (parts[4] == keyItems[i])
                    {
                        importantchecks.Add(line);
                    }
                }
            }


        } while (!sr.EndOfStream);
        sr.Close();


        for (int i = 0; i < importantchecks.Count; i++)
        {
            string[] parts = importantchecks[i].Split(new[] { ',' });
            for (int j = 0; j < STT.Count; j++)
            {
                if (parts[2] == STT[j])
                {
                    STTCount++;
                    if (parts[4] == "00000251")
                    {
                        STTItems.Add("CProof");
                    }
                    else if (parts[4] == "00000252")
                    {
                        STTItems.Add("NProof");
                    }
                    else if (parts[4] == "00000253")
                    {
                        STTItems.Add("TProof");
                    }
                    else if (parts[4] == "0000001A")
                    {
                        STTItems.Add("Valor");
                    }
                    else if (parts[4] == "0000001B")
                    {
                        STTItems.Add("Wisdom");
                    }
                    else if (parts[4] == "00000233")
                    {
                        STTItems.Add("Limit");
                    }
                    else if (parts[4] == "0000001F")
                    {
                        STTItems.Add("Master");
                    }
                    else if (parts[4] == "0000001D")
                    {
                        STTItems.Add("Final");
                    }
                    else if (parts[4] == "0000017F")
                    {
                        STTItems.Add("Chicken");
                    }
                    else if (parts[4] == "00000019")
                    {
                        STTItems.Add("Stitch");
                    }
                    else if (parts[4] == "0000009F")
                    {
                        STTItems.Add("Genie");
                    }
                    else if (parts[4] == "000000A0")
                    {
                        STTItems.Add("Peter");
                    }
                    else if (parts[4] == "00000015")
                    {
                        STTItems.Add("Fire");
                    }
                    else if (parts[4] == "00000016")
                    {
                        STTItems.Add("Blizzard");
                    }
                    else if (parts[4] == "00000017")
                    {
                        STTItems.Add("Thunder");
                    }
                    else if (parts[4] == "00000018")
                    {
                        STTItems.Add("Cure");
                    }
                    else if (parts[4] == "00000057")
                    {
                        STTItems.Add("Magnet");
                    }
                    else if (parts[4] == "00000058")
                    {
                        STTItems.Add("Reflect");
                    }
                    else if (parts[4] == "00000020")
                    {
                        STTItems.Add("Pages");
                    }
                    else if (parts[4] == "0000019F")
                    {
                        STTItems.Add("SChance");
                    }
                    else if (parts[4] == "000001A0")
                    {
                        STTItems.Add("OMore");
                    }
                    else if (parts[4] == "0000020C")
                    {
                        STTItems.Add("PCharm");
                    }
                    break;
                }
            }
            for (int j = 0; j < TT.Count; j++)
            {
                if (parts[2] == TT[j])
                {
                    TTCount++;
                    if (parts[4] == "00000251")
                    {
                        TTItems.Add("CProof");
                    }
                    else if (parts[4] == "00000252")
                    {
                        TTItems.Add("NProof");
                    }
                    else if (parts[4] == "00000253")
                    {
                        TTItems.Add("TProof");
                    }
                    else if (parts[4] == "0000001A")
                    {
                        TTItems.Add("Valor");
                    }
                    else if (parts[4] == "0000001B")
                    {
                        TTItems.Add("Wisdom");
                    }
                    else if (parts[4] == "00000233")
                    {
                        TTItems.Add("Limit");
                    }
                    else if (parts[4] == "0000001F")
                    {
                        TTItems.Add("Master");
                    }
                    else if (parts[4] == "0000001D")
                    {
                        TTItems.Add("Final");
                    }
                    else if (parts[4] == "0000017F")
                    {
                        TTItems.Add("Chicken");
                    }
                    else if (parts[4] == "00000019")
                    {
                        TTItems.Add("Stitch");
                    }
                    else if (parts[4] == "0000009F")
                    {
                        TTItems.Add("Genie");
                    }
                    else if (parts[4] == "000000A0")
                    {
                        TTItems.Add("Peter");
                    }
                    else if (parts[4] == "00000015")
                    {
                        TTItems.Add("Fire");
                    }
                    else if (parts[4] == "00000016")
                    {
                        TTItems.Add("Blizzard");
                    }
                    else if (parts[4] == "00000017")
                    {
                        TTItems.Add("Thunder");
                    }
                    else if (parts[4] == "00000018")
                    {
                        TTItems.Add("Cure");
                    }
                    else if (parts[4] == "00000057")
                    {
                        TTItems.Add("Magnet");
                    }
                    else if (parts[4] == "00000058")
                    {
                        TTItems.Add("Reflect");
                    }
                    else if (parts[4] == "00000020")
                    {
                        TTItems.Add("Pages");
                    }
                    else if (parts[4] == "0000019F")
                    {
                        TTItems.Add("SChance");
                    }
                    else if (parts[4] == "000001A0")
                    {
                        TTItems.Add("OMore");
                    }
                    else if (parts[4] == "0000020C")
                    {
                        TTItems.Add("PCharm");
                    }
                    break;
                }
            }
            for (int j = 0; j < HB.Count; j++)
            {
                if (parts[2] == HB[j])
                {
                    HBCount++;
                    if (parts[4] == "00000251")
                    {
                        HBItems.Add("CProof");
                    }
                    else if (parts[4] == "00000252")
                    {
                        HBItems.Add("NProof");
                    }
                    else if (parts[4] == "00000253")
                    {
                        HBItems.Add("TProof");
                    }
                    else if (parts[4] == "0000001A")
                    {
                        HBItems.Add("Valor");
                    }
                    else if (parts[4] == "0000001B")
                    {
                        HBItems.Add("Wisdom");
                    }
                    else if (parts[4] == "00000233")
                    {
                        HBItems.Add("Limit");
                    }
                    else if (parts[4] == "0000001F")
                    {
                        HBItems.Add("Master");
                    }
                    else if (parts[4] == "0000001D")
                    {
                        HBItems.Add("Final");
                    }
                    else if (parts[4] == "0000017F")
                    {
                        HBItems.Add("Chicken");
                    }
                    else if (parts[4] == "00000019")
                    {
                        HBItems.Add("Stitch");
                    }
                    else if (parts[4] == "0000009F")
                    {
                        HBItems.Add("Genie");
                    }
                    else if (parts[4] == "000000A0")
                    {
                        HBItems.Add("Peter");
                    }
                    else if (parts[4] == "00000015")
                    {
                        HBItems.Add("Fire");
                    }
                    else if (parts[4] == "00000016")
                    {
                        HBItems.Add("Blizzard");
                    }
                    else if (parts[4] == "00000017")
                    {
                        HBItems.Add("Thunder");
                    }
                    else if (parts[4] == "00000018")
                    {
                        HBItems.Add("Cure");
                    }
                    else if (parts[4] == "00000057")
                    {
                        HBItems.Add("Magnet");
                    }
                    else if (parts[4] == "00000058")
                    {
                        HBItems.Add("Reflect");
                    }
                    else if (parts[4] == "00000020")
                    {
                        HBItems.Add("Pages");
                    }
                    else if (parts[4] == "0000019F")
                    {
                        HBItems.Add("SChance");
                    }
                    else if (parts[4] == "000001A0")
                    {
                        HBItems.Add("OMore");
                    }
                    else if (parts[4] == "0000020C")
                    {
                        HBItems.Add("PCharm");
                    }
                    break;
                }
            }
            for (int j = 0; j < HT.Count; j++)
            {
                if (parts[2] == HT[j])
                {
                    HTCount++;
                    if (parts[4] == "00000251")
                    {
                        HTItems.Add("CProof");
                    }
                    else if (parts[4] == "00000252")
                    {
                        HTItems.Add("NProof");
                    }
                    else if (parts[4] == "00000253")
                    {
                        HTItems.Add("TProof");
                    }
                    else if (parts[4] == "0000001A")
                    {
                        HTItems.Add("Valor");
                    }
                    else if (parts[4] == "0000001B")
                    {
                        HTItems.Add("Wisdom");
                    }
                    else if (parts[4] == "00000233")
                    {
                        HTItems.Add("Limit");
                    }
                    else if (parts[4] == "0000001F")
                    {
                        HTItems.Add("Master");
                    }
                    else if (parts[4] == "0000001D")
                    {
                        HTItems.Add("Final");
                    }
                    else if (parts[4] == "0000017F")
                    {
                        HTItems.Add("Chicken");
                    }
                    else if (parts[4] == "00000019")
                    {
                        HTItems.Add("Stitch");
                    }
                    else if (parts[4] == "0000009F")
                    {
                        HTItems.Add("Genie");
                    }
                    else if (parts[4] == "000000A0")
                    {
                        HTItems.Add("Peter");
                    }
                    else if (parts[4] == "00000015")
                    {
                        HTItems.Add("Fire");
                    }
                    else if (parts[4] == "00000016")
                    {
                        HTItems.Add("Blizzard");
                    }
                    else if (parts[4] == "00000017")
                    {
                        HTItems.Add("Thunder");
                    }
                    else if (parts[4] == "00000018")
                    {
                        HTItems.Add("Cure");
                    }
                    else if (parts[4] == "00000057")
                    {
                        HTItems.Add("Magnet");
                    }
                    else if (parts[4] == "00000058")
                    {
                        HTItems.Add("Reflect");
                    }
                    else if (parts[4] == "00000020")
                    {
                        HTItems.Add("Pages");
                    }
                    else if (parts[4] == "0000019F")
                    {
                        HTItems.Add("SChance");
                    }
                    else if (parts[4] == "000001A0")
                    {
                        HTItems.Add("OMore");
                    }
                    else if (parts[4] == "0000020C")
                    {
                        HTItems.Add("PCharm");
                    }
                    break;
                }
            }
            for (int j = 0; j < SP.Count; j++)
            {
                if (parts[2] == SP[j])
                {
                    SPCount++;
                    if (parts[4] == "00000251")
                    {
                        SPItems.Add("CProof");
                    }
                    else if (parts[4] == "00000252")
                    {
                        SPItems.Add("NProof");
                    }
                    else if (parts[4] == "00000253")
                    {
                        SPItems.Add("TProof");
                    }
                    else if (parts[4] == "0000001A")
                    {
                        SPItems.Add("Valor");
                    }
                    else if (parts[4] == "0000001B")
                    {
                        SPItems.Add("Wisdom");
                    }
                    else if (parts[4] == "00000233")
                    {
                        SPItems.Add("Limit");
                    }
                    else if (parts[4] == "0000001F")
                    {
                        SPItems.Add("Master");
                    }
                    else if (parts[4] == "0000001D")
                    {
                        SPItems.Add("Final");
                    }
                    else if (parts[4] == "0000017F")
                    {
                        SPItems.Add("Chicken");
                    }
                    else if (parts[4] == "00000019")
                    {
                        SPItems.Add("Stitch");
                    }
                    else if (parts[4] == "0000009F")
                    {
                        SPItems.Add("Genie");
                    }
                    else if (parts[4] == "000000A0")
                    {
                        SPItems.Add("Peter");
                    }
                    else if (parts[4] == "00000015")
                    {
                        SPItems.Add("Fire");
                    }
                    else if (parts[4] == "00000016")
                    {
                        SPItems.Add("Blizzard");
                    }
                    else if (parts[4] == "00000017")
                    {
                        SPItems.Add("Thunder");
                    }
                    else if (parts[4] == "00000018")
                    {
                        SPItems.Add("Cure");
                    }
                    else if (parts[4] == "00000057")
                    {
                        SPItems.Add("Magnet");
                    }
                    else if (parts[4] == "00000058")
                    {
                        SPItems.Add("Reflect");
                    }
                    else if (parts[4] == "00000020")
                    {
                        SPItems.Add("Pages");
                    }
                    else if (parts[4] == "0000019F")
                    {
                        SPItems.Add("SChance");
                    }
                    else if (parts[4] == "000001A0")
                    {
                        SPItems.Add("OMore");
                    }
                    else if (parts[4] == "0000020C")
                    {
                        SPItems.Add("PCharm");
                    }
                    break;
                }
            }
            for (int j = 0; j < PR.Count; j++)
            {
                if (parts[2] == PR[j])
                {
                    PRCount++;
                    if (parts[4] == "00000251")
                    {
                        PRItems.Add("CProof");
                    }
                    else if (parts[4] == "00000252")
                    {
                        PRItems.Add("NProof");
                    }
                    else if (parts[4] == "00000253")
                    {
                        PRItems.Add("TProof");
                    }
                    else if (parts[4] == "0000001A")
                    {
                        PRItems.Add("Valor");
                    }
                    else if (parts[4] == "0000001B")
                    {
                        PRItems.Add("Wisdom");
                    }
                    else if (parts[4] == "00000233")
                    {
                        PRItems.Add("Limit");
                    }
                    else if (parts[4] == "0000001F")
                    {
                        PRItems.Add("Master");
                    }
                    else if (parts[4] == "0000001D")
                    {
                        PRItems.Add("Final");
                    }
                    else if (parts[4] == "0000017F")
                    {
                        PRItems.Add("Chicken");
                    }
                    else if (parts[4] == "00000019")
                    {
                        PRItems.Add("Stitch");
                    }
                    else if (parts[4] == "0000009F")
                    {
                        PRItems.Add("Genie");
                    }
                    else if (parts[4] == "000000A0")
                    {
                        PRItems.Add("Peter");
                    }
                    else if (parts[4] == "00000015")
                    {
                        PRItems.Add("Fire");
                    }
                    else if (parts[4] == "00000016")
                    {
                        PRItems.Add("Blizzard");
                    }
                    else if (parts[4] == "00000017")
                    {
                        PRItems.Add("Thunder");
                    }
                    else if (parts[4] == "00000018")
                    {
                        PRItems.Add("Cure");
                    }
                    else if (parts[4] == "00000057")
                    {
                        PRItems.Add("Magnet");
                    }
                    else if (parts[4] == "00000058")
                    {
                        PRItems.Add("Reflect");
                    }
                    else if (parts[4] == "00000020")
                    {
                        PRItems.Add("Pages");
                    }
                    else if (parts[4] == "0000019F")
                    {
                        PRItems.Add("SChance");
                    }
                    else if (parts[4] == "000001A0")
                    {
                        PRItems.Add("OMore");
                    }
                    else if (parts[4] == "0000020C")
                    {
                        PRItems.Add("PCharm");
                    }
                    break;
                }
            }
            for (int j = 0; j < OC.Count; j++)
            {
                if (parts[2] == OC[j])
                {
                    OCCount++;
                    if (parts[4] == "00000251")
                    {
                        OCItems.Add("CProof");
                    }
                    else if (parts[4] == "00000252")
                    {
                        OCItems.Add("NProof");
                    }
                    else if (parts[4] == "00000253")
                    {
                        OCItems.Add("TProof");
                    }
                    else if (parts[4] == "0000001A")
                    {
                        OCItems.Add("Valor");
                    }
                    else if (parts[4] == "0000001B")
                    {
                        OCItems.Add("Wisdom");
                    }
                    else if (parts[4] == "00000233")
                    {
                        OCItems.Add("Limit");
                    }
                    else if (parts[4] == "0000001F")
                    {
                        OCItems.Add("Master");
                    }
                    else if (parts[4] == "0000001D")
                    {
                        OCItems.Add("Final");
                    }
                    else if (parts[4] == "0000017F")
                    {
                        OCItems.Add("Chicken");
                    }
                    else if (parts[4] == "00000019")
                    {
                        OCItems.Add("Stitch");
                    }
                    else if (parts[4] == "0000009F")
                    {
                        OCItems.Add("Genie");
                    }
                    else if (parts[4] == "000000A0")
                    {
                        OCItems.Add("Peter");
                    }
                    else if (parts[4] == "00000015")
                    {
                        OCItems.Add("Fire");
                    }
                    else if (parts[4] == "00000016")
                    {
                        OCItems.Add("Blizzard");
                    }
                    else if (parts[4] == "00000017")
                    {
                        OCItems.Add("Thunder");
                    }
                    else if (parts[4] == "00000018")
                    {
                        OCItems.Add("Cure");
                    }
                    else if (parts[4] == "00000057")
                    {
                        OCItems.Add("Magnet");
                    }
                    else if (parts[4] == "00000058")
                    {
                        OCItems.Add("Reflect");
                    }
                    else if (parts[4] == "00000020")
                    {
                        OCItems.Add("Pages");
                    }
                    else if (parts[4] == "0000019F")
                    {
                        OCItems.Add("SChance");
                    }
                    else if (parts[4] == "000001A0")
                    {
                        OCItems.Add("OMore");
                    }
                    else if (parts[4] == "0000020C")
                    {
                        OCItems.Add("PCharm");
                    }
                    break;
                }
            }
            for (int j = 0; j < LoD.Count; j++)
            {
                if (parts[2] == LoD[j])
                {
                    LoDCount++;
                    if (parts[4] == "00000251")
                    {
                        LoDItems.Add("CProof");
                    }
                    else if (parts[4] == "00000252")
                    {
                        LoDItems.Add("NProof");
                    }
                    else if (parts[4] == "00000253")
                    {
                        LoDItems.Add("TProof");
                    }
                    else if (parts[4] == "0000001A")
                    {
                        LoDItems.Add("Valor");
                    }
                    else if (parts[4] == "0000001B")
                    {
                        LoDItems.Add("Wisdom");
                    }
                    else if (parts[4] == "00000233")
                    {
                        LoDItems.Add("Limit");
                    }
                    else if (parts[4] == "0000001F")
                    {
                        LoDItems.Add("Master");
                    }
                    else if (parts[4] == "0000001D")
                    {
                        LoDItems.Add("Final");
                    }
                    else if (parts[4] == "0000017F")
                    {
                        LoDItems.Add("Chicken");
                    }
                    else if (parts[4] == "00000019")
                    {
                        LoDItems.Add("Stitch");
                    }
                    else if (parts[4] == "0000009F")
                    {
                        LoDItems.Add("Genie");
                    }
                    else if (parts[4] == "000000A0")
                    {
                        LoDItems.Add("Peter");
                    }
                    else if (parts[4] == "00000015")
                    {
                        LoDItems.Add("Fire");
                    }
                    else if (parts[4] == "00000016")
                    {
                        LoDItems.Add("Blizzard");
                    }
                    else if (parts[4] == "00000017")
                    {
                        LoDItems.Add("Thunder");
                    }
                    else if (parts[4] == "00000018")
                    {
                        LoDItems.Add("Cure");
                    }
                    else if (parts[4] == "00000057")
                    {
                        LoDItems.Add("Magnet");
                    }
                    else if (parts[4] == "00000058")
                    {
                        LoDItems.Add("Reflect");
                    }
                    else if (parts[4] == "00000020")
                    {
                        LoDItems.Add("Pages");
                    }
                    else if (parts[4] == "0000019F")
                    {
                        LoDItems.Add("SChance");
                    }
                    else if (parts[4] == "000001A0")
                    {
                        LoDItems.Add("OMore");
                    }
                    else if (parts[4] == "0000020C")
                    {
                        LoDItems.Add("PCharm");
                    }
                    break;
                }
            }
            for (int j = 0; j < TWTNW.Count; j++)
            {
                if (parts[2] == TWTNW[j])
                {
                    TWTNWCount++;
                    if (parts[4] == "00000251")
                    {
                        TWTNWItems.Add("CProof");
                    }
                    else if (parts[4] == "00000252")
                    {
                        TWTNWItems.Add("NProof");
                    }
                    else if (parts[4] == "00000253")
                    {
                        TWTNWItems.Add("TProof");
                    }
                    else if (parts[4] == "0000001A")
                    {
                        TWTNWItems.Add("Valor");
                    }
                    else if (parts[4] == "0000001B")
                    {
                        TWTNWItems.Add("Wisdom");
                    }
                    else if (parts[4] == "00000233")
                    {
                        TWTNWItems.Add("Limit");
                    }
                    else if (parts[4] == "0000001F")
                    {
                        TWTNWItems.Add("Master");
                    }
                    else if (parts[4] == "0000001D")
                    {
                        TWTNWItems.Add("Final");
                    }
                    else if (parts[4] == "0000017F")
                    {
                        TWTNWItems.Add("Chicken");
                    }
                    else if (parts[4] == "00000019")
                    {
                        TWTNWItems.Add("Stitch");
                    }
                    else if (parts[4] == "0000009F")
                    {
                        TWTNWItems.Add("Genie");
                    }
                    else if (parts[4] == "000000A0")
                    {
                        TWTNWItems.Add("Peter");
                    }
                    else if (parts[4] == "00000015")
                    {
                        TWTNWItems.Add("Fire");
                    }
                    else if (parts[4] == "00000016")
                    {
                        TWTNWItems.Add("Blizzard");
                    }
                    else if (parts[4] == "00000017")
                    {
                        TWTNWItems.Add("Thunder");
                    }
                    else if (parts[4] == "00000018")
                    {
                        TWTNWItems.Add("Cure");
                    }
                    else if (parts[4] == "00000057")
                    {
                        TWTNWItems.Add("Magnet");
                    }
                    else if (parts[4] == "00000058")
                    {
                        TWTNWItems.Add("Reflect");
                    }
                    else if (parts[4] == "00000020")
                    {
                        TWTNWItems.Add("Pages");
                    }
                    else if (parts[4] == "0000019F")
                    {
                        TWTNWItems.Add("SChance");
                    }
                    else if (parts[4] == "000001A0")
                    {
                        TWTNWItems.Add("OMore");
                    }
                    else if (parts[4] == "0000020C")
                    {
                        TWTNWItems.Add("PCharm");
                    }
                    break;
                }
            }
            for (int j = 0; j < BC.Count; j++)
            {
                if (parts[2] == BC[j])
                {
                    BCCount++;
                    if (parts[4] == "00000251")
                    {
                        BCItems.Add("CProof");
                    }
                    else if (parts[4] == "00000252")
                    {
                        BCItems.Add("NProof");
                    }
                    else if (parts[4] == "00000253")
                    {
                        BCItems.Add("TProof");
                    }
                    else if (parts[4] == "0000001A")
                    {
                        BCItems.Add("Valor");
                    }
                    else if (parts[4] == "0000001B")
                    {
                        BCItems.Add("Wisdom");
                    }
                    else if (parts[4] == "00000233")
                    {
                        BCItems.Add("Limit");
                    }
                    else if (parts[4] == "0000001F")
                    {
                        BCItems.Add("Master");
                    }
                    else if (parts[4] == "0000001D")
                    {
                        BCItems.Add("Final");
                    }
                    else if (parts[4] == "0000017F")
                    {
                        BCItems.Add("Chicken");
                    }
                    else if (parts[4] == "00000019")
                    {
                        BCItems.Add("Stitch");
                    }
                    else if (parts[4] == "0000009F")
                    {
                        BCItems.Add("Genie");
                    }
                    else if (parts[4] == "000000A0")
                    {
                        BCItems.Add("Peter");
                    }
                    else if (parts[4] == "00000015")
                    {
                        BCItems.Add("Fire");
                    }
                    else if (parts[4] == "00000016")
                    {
                        BCItems.Add("Blizzard");
                    }
                    else if (parts[4] == "00000017")
                    {
                        BCItems.Add("Thunder");
                    }
                    else if (parts[4] == "00000018")
                    {
                        BCItems.Add("Cure");
                    }
                    else if (parts[4] == "00000057")
                    {
                        BCItems.Add("Magnet");
                    }
                    else if (parts[4] == "00000058")
                    {
                        BCItems.Add("Reflect");
                    }
                    else if (parts[4] == "00000020")
                    {
                        BCItems.Add("Pages");
                    }
                    else if (parts[4] == "0000019F")
                    {
                        BCItems.Add("SChance");
                    }
                    else if (parts[4] == "000001A0")
                    {
                        BCItems.Add("OMore");
                    }
                    else if (parts[4] == "0000020C")
                    {
                        BCItems.Add("PCharm");
                    }
                    break;
                }
            }
            for (int j = 0; j < AG.Count; j++)
            {
                if (parts[2] == AG[j])
                {
                    AGCount++;
                    if (parts[4] == "00000251")
                    {
                        AGItems.Add("CProof");
                    }
                    else if (parts[4] == "00000252")
                    {
                        AGItems.Add("NProof");
                    }
                    else if (parts[4] == "00000253")
                    {
                        AGItems.Add("TProof");
                    }
                    else if (parts[4] == "0000001A")
                    {
                        AGItems.Add("Valor");
                    }
                    else if (parts[4] == "0000001B")
                    {
                        AGItems.Add("Wisdom");
                    }
                    else if (parts[4] == "00000233")
                    {
                        AGItems.Add("Limit");
                    }
                    else if (parts[4] == "0000001F")
                    {
                        AGItems.Add("Master");
                    }
                    else if (parts[4] == "0000001D")
                    {
                        AGItems.Add("Final");
                    }
                    else if (parts[4] == "0000017F")
                    {
                        AGItems.Add("Chicken");
                    }
                    else if (parts[4] == "00000019")
                    {
                        AGItems.Add("Stitch");
                    }
                    else if (parts[4] == "0000009F")
                    {
                        AGItems.Add("Genie");
                    }
                    else if (parts[4] == "000000A0")
                    {
                        AGItems.Add("Peter");
                    }
                    else if (parts[4] == "00000015")
                    {
                        AGItems.Add("Fire");
                    }
                    else if (parts[4] == "00000016")
                    {
                        AGItems.Add("Blizzard");
                    }
                    else if (parts[4] == "00000017")
                    {
                        AGItems.Add("Thunder");
                    }
                    else if (parts[4] == "00000018")
                    {
                        AGItems.Add("Cure");
                    }
                    else if (parts[4] == "00000057")
                    {
                        AGItems.Add("Magnet");
                    }
                    else if (parts[4] == "00000058")
                    {
                        AGItems.Add("Reflect");
                    }
                    else if (parts[4] == "00000020")
                    {
                        AGItems.Add("Pages");
                    }
                    else if (parts[4] == "0000019F")
                    {
                        AGItems.Add("SChance");
                    }
                    else if (parts[4] == "000001A0")
                    {
                        AGItems.Add("OMore");
                    }
                    else if (parts[4] == "0000020C")
                    {
                        AGItems.Add("PCharm");
                    }
                    break;
                }
            }
            for (int j = 0; j < PL.Count; j++)
            {
                if (parts[2] == PL[j])
                {
                    PLCount++;
                    if (parts[4] == "00000251")
                    {
                        PLItems.Add("CProof");
                    }
                    else if (parts[4] == "00000252")
                    {
                        PLItems.Add("NProof");
                    }
                    else if (parts[4] == "00000253")
                    {
                        PLItems.Add("TProof");
                    }
                    else if (parts[4] == "0000001A")
                    {
                        PLItems.Add("Valor");
                    }
                    else if (parts[4] == "0000001B")
                    {
                        PLItems.Add("Wisdom");
                    }
                    else if (parts[4] == "00000233")
                    {
                        PLItems.Add("Limit");
                    }
                    else if (parts[4] == "0000001F")
                    {
                        PLItems.Add("Master");
                    }
                    else if (parts[4] == "0000001D")
                    {
                        PLItems.Add("Final");
                    }
                    else if (parts[4] == "0000017F")
                    {
                        PLItems.Add("Chicken");
                    }
                    else if (parts[4] == "00000019")
                    {
                        PLItems.Add("Stitch");
                    }
                    else if (parts[4] == "0000009F")
                    {
                        PLItems.Add("Genie");
                    }
                    else if (parts[4] == "000000A0")
                    {
                        PLItems.Add("Peter");
                    }
                    else if (parts[4] == "00000015")
                    {
                        PLItems.Add("Fire");
                    }
                    else if (parts[4] == "00000016")
                    {
                        PLItems.Add("Blizzard");
                    }
                    else if (parts[4] == "00000017")
                    {
                        PLItems.Add("Thunder");
                    }
                    else if (parts[4] == "00000018")
                    {
                        PLItems.Add("Cure");
                    }
                    else if (parts[4] == "00000057")
                    {
                        PLItems.Add("Magnet");
                    }
                    else if (parts[4] == "00000058")
                    {
                        PLItems.Add("Reflect");
                    }
                    else if (parts[4] == "00000020")
                    {
                        PLItems.Add("Pages");
                    }
                    else if (parts[4] == "0000019F")
                    {
                        PLItems.Add("SChance");
                    }
                    else if (parts[4] == "000001A0")
                    {
                        PLItems.Add("OMore");
                    }
                    else if (parts[4] == "0000020C")
                    {
                        PLItems.Add("PCharm");
                    }
                    break;
                }
            }
            for (int j = 0; j < DC.Count; j++)
            {
                if (parts[2] == DC[j])
                {
                    DCCount++;
                    if (parts[4] == "00000251")
                    {
                        DCItems.Add("CProof");
                    }
                    else if (parts[4] == "00000252")
                    {
                        DCItems.Add("NProof");
                    }
                    else if (parts[4] == "00000253")
                    {
                        DCItems.Add("TProof");
                    }
                    else if (parts[4] == "0000001A")
                    {
                        DCItems.Add("Valor");
                    }
                    else if (parts[4] == "0000001B")
                    {
                        DCItems.Add("Wisdom");
                    }
                    else if (parts[4] == "00000233")
                    {
                        DCItems.Add("Limit");
                    }
                    else if (parts[4] == "0000001F")
                    {
                        DCItems.Add("Master");
                    }
                    else if (parts[4] == "0000001D")
                    {
                        DCItems.Add("Final");
                    }
                    else if (parts[4] == "0000017F")
                    {
                        DCItems.Add("Chicken");
                    }
                    else if (parts[4] == "00000019")
                    {
                        DCItems.Add("Stitch");
                    }
                    else if (parts[4] == "0000009F")
                    {
                        DCItems.Add("Genie");
                    }
                    else if (parts[4] == "000000A0")
                    {
                        DCItems.Add("Peter");
                    }
                    else if (parts[4] == "00000015")
                    {
                        DCItems.Add("Fire");
                    }
                    else if (parts[4] == "00000016")
                    {
                        DCItems.Add("Blizzard");
                    }
                    else if (parts[4] == "00000017")
                    {
                        DCItems.Add("Thunder");
                    }
                    else if (parts[4] == "00000018")
                    {
                        DCItems.Add("Cure");
                    }
                    else if (parts[4] == "00000057")
                    {
                        DCItems.Add("Magnet");
                    }
                    else if (parts[4] == "00000058")
                    {
                        DCItems.Add("Reflect");
                    }
                    else if (parts[4] == "00000020")
                    {
                        DCItems.Add("Pages");
                    }
                    else if (parts[4] == "0000019F")
                    {
                        DCItems.Add("SChance");
                    }
                    else if (parts[4] == "000001A0")
                    {
                        DCItems.Add("OMore");
                    }
                    else if (parts[4] == "0000020C")
                    {
                        DCItems.Add("PCharm");
                    }
                    break;
                }
            }
            for (int j = 0; j < hundredacre.Count; j++)
            {
                if (parts[2] == hundredacre[j])
                {
                    hundredacreCount++;
                    if (parts[4] == "00000251")
                    {
                        HundredItems.Add("CProof");
                    }
                    else if (parts[4] == "00000252")
                    {
                        HundredItems.Add("NProof");
                    }
                    else if (parts[4] == "00000253")
                    {
                        HundredItems.Add("TProof");
                    }
                    else if (parts[4] == "0000001A")
                    {
                        HundredItems.Add("Valor");
                    }
                    else if (parts[4] == "0000001B")
                    {
                        HundredItems.Add("Wisdom");
                    }
                    else if (parts[4] == "00000233")
                    {
                        HundredItems.Add("Limit");
                    }
                    else if (parts[4] == "0000001F")
                    {
                        HundredItems.Add("Master");
                    }
                    else if (parts[4] == "0000001D")
                    {
                        HundredItems.Add("Final");
                    }
                    else if (parts[4] == "0000017F")
                    {
                        HundredItems.Add("Chicken");
                    }
                    else if (parts[4] == "00000019")
                    {
                        HundredItems.Add("Stitch");
                    }
                    else if (parts[4] == "0000009F")
                    {
                        HundredItems.Add("Genie");
                    }
                    else if (parts[4] == "000000A0")
                    {
                        HundredItems.Add("Peter");
                    }
                    else if (parts[4] == "00000015")
                    {
                        HundredItems.Add("Fire");
                    }
                    else if (parts[4] == "00000016")
                    {
                        HundredItems.Add("Blizzard");
                    }
                    else if (parts[4] == "00000017")
                    {
                        HundredItems.Add("Thunder");
                    }
                    else if (parts[4] == "00000018")
                    {
                        HundredItems.Add("Cure");
                    }
                    else if (parts[4] == "00000057")
                    {
                        HundredItems.Add("Magnet");
                    }
                    else if (parts[4] == "00000058")
                    {
                        HundredItems.Add("Reflect");
                    }
                    else if (parts[4] == "00000020")
                    {
                        HundredItems.Add("Pages");
                    }
                    else if (parts[4] == "0000019F")
                    {
                        HundredItems.Add("SChance");
                    }
                    else if (parts[4] == "000001A0")
                    {
                        HundredItems.Add("OMore");
                    }
                    else if (parts[4] == "0000020C")
                    {
                        HundredItems.Add("PCharm");
                    }
                    break;
                }
            }
            for (int j = 0; j < Atlantica.Count; j++)
            {
                if (parts[2] == Atlantica[j])
                {
                    AtlanticaCount++;
                    if (parts[4] == "00000251")
                    {
                        ATItems.Add("CProof");
                    }
                    else if (parts[4] == "00000252")
                    {
                        ATItems.Add("NProof");
                    }
                    else if (parts[4] == "00000253")
                    {
                        ATItems.Add("TProof");
                    }
                    else if (parts[4] == "0000001A")
                    {
                        ATItems.Add("Valor");
                    }
                    else if (parts[4] == "0000001B")
                    {
                        ATItems.Add("Wisdom");
                    }
                    else if (parts[4] == "00000233")
                    {
                        ATItems.Add("Limit");
                    }
                    else if (parts[4] == "0000001F")
                    {
                        ATItems.Add("Master");
                    }
                    else if (parts[4] == "0000001D")
                    {
                        ATItems.Add("Final");
                    }
                    else if (parts[4] == "0000017F")
                    {
                        ATItems.Add("Chicken");
                    }
                    else if (parts[4] == "00000019")
                    {
                        ATItems.Add("Stitch");
                    }
                    else if (parts[4] == "0000009F")
                    {
                        ATItems.Add("Genie");
                    }
                    else if (parts[4] == "000000A0")
                    {
                        ATItems.Add("Peter");
                    }
                    else if (parts[4] == "00000015")
                    {
                        ATItems.Add("Fire");
                    }
                    else if (parts[4] == "00000016")
                    {
                        ATItems.Add("Blizzard");
                    }
                    else if (parts[4] == "00000017")
                    {
                        ATItems.Add("Thunder");
                    }
                    else if (parts[4] == "00000018")
                    {
                        ATItems.Add("Cure");
                    }
                    else if (parts[4] == "00000057")
                    {
                        ATItems.Add("Magnet");
                    }
                    else if (parts[4] == "00000058")
                    {
                        ATItems.Add("Reflect");
                    }
                    else if (parts[4] == "00000020")
                    {
                        ATItems.Add("Pages");
                    }
                    else if (parts[4] == "0000019F")
                    {
                        ATItems.Add("SChance");
                    }
                    else if (parts[4] == "000001A0")
                    {
                        ATItems.Add("OMore");
                    }
                    else if (parts[4] == "0000020C")
                    {
                        ATItems.Add("PCharm");
                    }
                    break;
                }
            }
            for (int j = 0; j < Levels.Count; j++)
            {
                if (parts[2] == Levels[j])
                {
                    LevelsCount++;
                    if (parts[4] == "00000251")
                    {
                        LevelItems.Add("CProof");
                    }
                    else if (parts[4] == "00000252")
                    {
                        LevelItems.Add("NProof");
                    }
                    else if (parts[4] == "00000253")
                    {
                        LevelItems.Add("TProof");
                    }
                    else if (parts[4] == "0000001A")
                    {
                        LevelItems.Add("Valor");
                    }
                    else if (parts[4] == "0000001B")
                    {
                        LevelItems.Add("Wisdom");
                    }
                    else if (parts[4] == "00000233")
                    {
                        LevelItems.Add("Limit");
                    }
                    else if (parts[4] == "0000001F")
                    {
                        LevelItems.Add("Master");
                    }
                    else if (parts[4] == "0000001D")
                    {
                        LevelItems.Add("Final");
                    }
                    else if (parts[4] == "0000017F")
                    {
                        LevelItems.Add("Chicken");
                    }
                    else if (parts[4] == "00000019")
                    {
                        LevelItems.Add("Stitch");
                    }
                    else if (parts[4] == "0000009F")
                    {
                        LevelItems.Add("Genie");
                    }
                    else if (parts[4] == "000000A0")
                    {
                        LevelItems.Add("Peter");
                    }
                    else if (parts[4] == "00000015")
                    {
                        LevelItems.Add("Fire");
                    }
                    else if (parts[4] == "00000016")
                    {
                        LevelItems.Add("Blizzard");
                    }
                    else if (parts[4] == "00000017")
                    {
                        LevelItems.Add("Thunder");
                    }
                    else if (parts[4] == "00000018")
                    {
                        LevelItems.Add("Cure");
                    }
                    else if (parts[4] == "00000057")
                    {
                        LevelItems.Add("Magnet");
                    }
                    else if (parts[4] == "00000058")
                    {
                        LevelItems.Add("Reflect");
                    }
                    else if (parts[4] == "00000020")
                    {
                        LevelItems.Add("Pages");
                    }
                    else if (parts[4] == "0000019F")
                    {
                        LevelItems.Add("SChance");
                    }
                    else if (parts[4] == "000001A0")
                    {
                        LevelItems.Add("OMore");
                    }
                    else if (parts[4] == "0000020C")
                    {
                        LevelItems.Add("PCharm");
                    }
                    break;
                }
            }
            for (int j = 0; j < Forms.Count; j++)
            {
                if (parts[2] == Forms[j])
                {
                    FormsCount++;
                    if (parts[4] == "00000251")
                    {
                        FormItems.Add("CProof");
                    }
                    else if (parts[4] == "00000252")
                    {
                        FormItems.Add("NProof");
                    }
                    else if (parts[4] == "00000253")
                    {
                        FormItems.Add("TProof");
                    }
                    else if (parts[4] == "0000001A")
                    {
                        FormItems.Add("Valor");
                    }
                    else if (parts[4] == "0000001B")
                    {
                        FormItems.Add("Wisdom");
                    }
                    else if (parts[4] == "00000233")
                    {
                        FormItems.Add("Limit");
                    }
                    else if (parts[4] == "0000001F")
                    {
                        FormItems.Add("Master");
                    }
                    else if (parts[4] == "0000001D")
                    {
                        FormItems.Add("Final");
                    }
                    else if (parts[4] == "0000017F")
                    {
                        FormItems.Add("Chicken");
                    }
                    else if (parts[4] == "00000019")
                    {
                        FormItems.Add("Stitch");
                    }
                    else if (parts[4] == "0000009F")
                    {
                        FormItems.Add("Genie");
                    }
                    else if (parts[4] == "000000A0")
                    {
                        FormItems.Add("Peter");
                    }
                    else if (parts[4] == "00000015")
                    {
                        FormItems.Add("Fire");
                    }
                    else if (parts[4] == "00000016")
                    {
                        FormItems.Add("Blizzard");
                    }
                    else if (parts[4] == "00000017")
                    {
                        FormItems.Add("Thunder");
                    }
                    else if (parts[4] == "00000018")
                    {
                        FormItems.Add("Cure");
                    }
                    else if (parts[4] == "00000057")
                    {
                        FormItems.Add("Magnet");
                    }
                    else if (parts[4] == "00000058")
                    {
                        FormItems.Add("Reflect");
                    }
                    else if (parts[4] == "00000020")
                    {
                        FormItems.Add("Pages");
                    }
                    else if (parts[4] == "0000019F")
                    {
                        FormItems.Add("SChance");
                    }
                    else if (parts[4] == "000001A0")
                    {
                        FormItems.Add("OMore");
                    }
                    else if (parts[4] == "0000020C")
                    {
                        FormItems.Add("PCharm");
                    }
                    break;
                }
            }

        }

        StreamWriter sw = new StreamWriter(hintpath);
        sw.WriteLine(STTCount); //STT
        sw.WriteLine(DCCount); //DC
        sw.WriteLine(HBCount); //HB
        sw.WriteLine(PLCount); //PL
        sw.WriteLine(AGCount); //AG
        sw.WriteLine(BCCount); //BC
        sw.WriteLine(TWTNWCount);  //TWTNW
        sw.WriteLine(LoDCount); //LoD
        sw.WriteLine(HTCount); //HT
        sw.WriteLine(OCCount); //OC
        sw.WriteLine(TTCount); //TT
        sw.WriteLine(PRCount); //PR
        sw.WriteLine(SPCount); //SP
        sw.WriteLine(AtlanticaCount); //Atlantica
        sw.WriteLine(hundredacreCount); //100acre
        sw.WriteLine(LevelsCount); //level
        sw.WriteLine(FormsCount); //forms
        sw.WriteLine("Total Count " + (STTCount + DCCount + HBCount + PLCount + AGCount + BCCount + TWTNWCount + LoDCount + HTCount + OCCount + TTCount + PRCount + SPCount + AtlanticaCount + hundredacreCount + LevelsCount + FormsCount));
        sw.Close();
        //for (int i = 0; i < OCItems.Count; i++)
        //{
        //    Debug.Log(OCItems[i]);
        //}
        
    }

    void Code()
    {
       

        //Key Items

        //proofs
        keyItems.Add("00000251");
        keyItems.Add("00000252");
        keyItems.Add("00000253");
        //drive forms
        keyItems.Add("0000001A");
        keyItems.Add("0000001B");
        keyItems.Add("00000233");
        keyItems.Add("0000001F");
        keyItems.Add("0000001D");
        //summons
        keyItems.Add("0000017F");
        keyItems.Add("00000019");
        keyItems.Add("0000009F");
        keyItems.Add("000000A0");
        //magic
        keyItems.Add("00000015");
        keyItems.Add("00000016");
        keyItems.Add("00000017");
        keyItems.Add("00000018");
        keyItems.Add("00000057");
        keyItems.Add("00000058");
        //torn pages
        keyItems.Add("00000020");       
        //second change and once more
        keyItems.Add("0000019F");
        keyItems.Add("000001A0");
        //promise charm
        keyItems.Add("0000020C");


        //Free

        Free.Add("11CE05E2");
        Free.Add("11CE05EE");
        Free.Add("11CE05FA");
        Free.Add("11D18DDE");
        Free.Add("11D18DDC");
        Free.Add("11D18DE8");
        Free.Add("11D18DE4");
        Free.Add("11D18DE6");
        Free.Add("11D18DE0");
        Free.Add("11D18DE2");


        //STT

        STT.Add("11CE016E");
        STT.Add("11CE017A");
        STT.Add("11CE0186");
        STT.Add("11CE0192");
        STT.Add("11CE019E");
        STT.Add("11CE01AA");
        STT.Add("11CE01B6");
        STT.Add("11CE01C2");
        STT.Add("11CE01CE");
        STT.Add("11CE01DA");
        STT.Add("11CE01E6");
        STT.Add("11CE01F2");
        STT.Add("11CE01FE");
        STT.Add("11CE020A");
        STT.Add("11CE0216");
        STT.Add("11CE0222");
        STT.Add("21D10FA8");
        STT.Add("21D10CB8");
        STT.Add("21D11278");
        STT.Add("11CE0636");
        STT.Add("11CE0606");
        STT.Add("11CE0612"); //champion belt
        STT.Add("11CE061E"); //medal
        STT.Add("11CE062A");
        STT.Add("11CE0642");
        STT.Add("11CE064E");
        STT.Add("11CE0B0A");//data roxas


        //TT

        TT.Add("11CE022E");
        TT.Add("11CE023A");
        TT.Add("11CE0246");
        TT.Add("11CE0252");
        TT.Add("11CE025E");
        TT.Add("11CE026A");
        TT.Add("11CE0276");
        TT.Add("11CE0282");
        TT.Add("11CE028E");
        TT.Add("11CE029A");
        TT.Add("11CE02A6");
        TT.Add("11CE02B2");
        TT.Add("11CE02BE");
        TT.Add("11CE02CA");
        TT.Add("11CE02D6");
        TT.Add("11CE02E2");
        TT.Add("11CE02EE");
        TT.Add("11CE02FA");
        TT.Add("11CE0306");
        TT.Add("11CE0312");
        TT.Add("11CE031E");
        TT.Add("11CE032A");
        TT.Add("11CE0336");
        TT.Add("11CE0342");
        TT.Add("11CE034E");
        TT.Add("11CE035A");
        TT.Add("11CE0366");
        TT.Add("11CE0372");
        TT.Add("11CE037E");
        TT.Add("11CE038A");
        TT.Add("11CE0396");
        TT.Add("11CE03A2");
        TT.Add("11CE03AE");
        TT.Add("11CE03BA");
        TT.Add("11CE03C6");
        TT.Add("11CE03D2");
        TT.Add("11CE03DE");
        TT.Add("11CE03EA");
        TT.Add("11CE03F6");
        TT.Add("21D110E8");
        TT.Add("11CE065A");
        TT.Add("11CE0666");
        TT.Add("11CE0672");
        TT.Add("11CE067E");
        TT.Add("11CE07E6");
        TT.Add("11CE07F2");
        TT.Add("11CE07FE");
        TT.Add("11CE0966");
        TT.Add("11CE09AE");
        TT.Add("11CE0A0E");

        TT.Add("11CE0ACE"); //data axel


        //HB

        HB.Add("11CDFF3A");
        HB.Add("11CDFF46");
        HB.Add("11CDFF52");
        HB.Add("11CDFF5E");
        HB.Add("11CDFF6A");
        HB.Add("11CDFF76");
        HB.Add("11CDFF82");
        HB.Add("11CDFF8E");
        HB.Add("11CDFF9A");
        HB.Add("11CDFFA6");
        HB.Add("11CDFFB2");
        HB.Add("11CDFFBE");
        HB.Add("11CDFFCA");
        HB.Add("11CDFFD6");
        HB.Add("11CDFFE2");
        HB.Add("11CDFFEE");
        HB.Add("11CDFFFA");
        HB.Add("11CE0006");
        HB.Add("11CE0012");
        HB.Add("11CE001E");
        HB.Add("11CE002A");
        HB.Add("11CE0036");
        HB.Add("21D10E98");
        HB.Add("21D10BA8");
        HB.Add("21D11068");
        HB.Add("11CE068A");
        HB.Add("11CE0696");
        HB.Add("11CE06A2");
        HB.Add("11CE0702");
        HB.Add("11CE080A");
        HB.Add("11CE0822");
        HB.Add("11CE082E");
        HB.Add("11CE083A");
        HB.Add("11CE0936");
        HB.Add("11CE0942");
        HB.Add("11CE09A2");
        HB.Add("11CE09EA");
        HB.Add("11CE0B3A"); //shroom
        HB.Add("11CE0B2E"); //shroom

        HB.Add("11CE04E6"); //cor
        HB.Add("11CE04F2");
        HB.Add("11CE04FE");
        HB.Add("11CE050A");
        HB.Add("11CE0516");
        HB.Add("11CE0522");
        HB.Add("11CE052E");
        HB.Add("11CE053A");
        HB.Add("11CE0546");
        HB.Add("11CE0552");
        HB.Add("11CE055E");
        HB.Add("11CE056A");
        HB.Add("11CE0576");
        HB.Add("11CE0582");
        HB.Add("11CE058E");
        HB.Add("11CE059A");
        HB.Add("11CE05A6");
        HB.Add("11CE05B2");
        HB.Add("11CE05BE");
        HB.Add("11CE05CA");
        HB.Add("11CE05D6");

        HB.Add("11CE0AB6"); //data demyx


        //LoD

        LoD.Add("11CDF72A");
        LoD.Add("11CDF736");
        LoD.Add("11CDF742");
        LoD.Add("11CDF74E");
        LoD.Add("11CDF75A");
        LoD.Add("11CDF766");
        LoD.Add("11CDF772");
        LoD.Add("11CDF77E");
        LoD.Add("11CDF78A");
        LoD.Add("11CDF796");
        LoD.Add("11CDF7A2");
        LoD.Add("11CDF7AE");
        LoD.Add("11CDF7BA");
        LoD.Add("11CDF7C6");
        LoD.Add("11CDF7D2");
        LoD.Add("11CDF7DE");
        LoD.Add("11CDF7EA");
        LoD.Add("11CDF7F6");
        LoD.Add("11CDF802");
        LoD.Add("11CDF80E");
        LoD.Add("11CDF81A");
        LoD.Add("21D10DF8");
        LoD.Add("21D108C8");
        LoD.Add("21D10908");
        LoD.Add("11CE06D2");
        LoD.Add("11CE06C6");
        LoD.Add("11CE06DE");
        LoD.Add("11CE06EA");

        LoD.Add("11CE0AE6"); //data xigbar


        //BC

        BC.Add("11CDFBF2");
        BC.Add("11CDFBFE");
        BC.Add("11CDFC0A");
        BC.Add("11CDFC16");
        BC.Add("11CDFC22");
        BC.Add("11CDFC2E");
        BC.Add("11CDFC3A");
        BC.Add("11CDFC46");
        BC.Add("11CDFC52");
        BC.Add("11CDFC5E");
        BC.Add("11CDFC6A");
        BC.Add("11CDFC76");
        BC.Add("11CDFC82");
        BC.Add("11CDFC8E");
        BC.Add("11CDFC9A");
        BC.Add("11CDFCA6");
        BC.Add("11CDFCB2");
        BC.Add("11CDFCBE");
        BC.Add("11CDFCCA");
        BC.Add("11CDFCD6");
        BC.Add("11CDFCE2");
        BC.Add("21D10758");
        BC.Add("21D10788");
        BC.Add("21D107C8");
        BC.Add("11CE06F6");
        BC.Add("11CE0852");
        BC.Add("11CE085E");
        BC.Add("11CE09C6");

        BC.Add("11CE0AC2"); //data xaldin


        //OC

        OC.Add("11CDFB02");
        OC.Add("11CDFB0E");
        OC.Add("11CDFB1A");
        OC.Add("11CDFB26");
        OC.Add("11CDFB32");
        OC.Add("11CDFB3E");
        OC.Add("11CDFB4A");
        OC.Add("11CDFB56");
        OC.Add("11CDFB62");
        OC.Add("11CDFB6E");
        OC.Add("11CDFB7A");
        OC.Add("11CDFB86");
        OC.Add("11CDFB92");
        OC.Add("11CDFB9E");
        OC.Add("11CDFBAA");
        OC.Add("11CDFBB6");
        OC.Add("11CDFBC2");
        OC.Add("11CDFBCE");
        OC.Add("11CDFBDA");
        OC.Add("11CDFBE6");
        OC.Add("21D10808");
        OC.Add("21D10FE8");
        OC.Add("21D10828");
        OC.Add("21D10858");
        OC.Add("21D10888");
        OC.Add("11CE070E");
        OC.Add("11CE071A");
        OC.Add("11CE09D2");
        OC.Add("11CE0726");
        OC.Add("11CE0882");
        OC.Add("11CE088E");

        OC.Add("11CE073E"); //cups
        OC.Add("11CE074A");
        OC.Add("11CE07CE");
        OC.Add("11CE07DA");
        OC.Add("11CE089A");
        OC.Add("11CE08A6");
        OC.Add("11CE094E");
        OC.Add("11CE095A");
        OC.Add("11CE0996"); //hades cup

        OC.Add("11CE0A56"); //AS zexion
        OC.Add("11CE0A92"); //data zexion


        //DC

        DC.Add("11CDF9B2");
        DC.Add("11CDF9BE");
        DC.Add("11CDF9CA");
        DC.Add("11CDF9D6");
        DC.Add("11CDF9E2");
        DC.Add("11CDF9EE");
        DC.Add("11CDF9FA");
        DC.Add("11CDFA06");
        DC.Add("21D10D28");
        DC.Add("11CE0756");
        DC.Add("11CE0B16"); //terra
        DC.Add("11CE0B22"); //terra

        DC.Add("11CDF95E"); //timeless river
        DC.Add("11CDF96A");
        DC.Add("11CDF976");
        DC.Add("11CDF982");
        DC.Add("11CDF98E");
        DC.Add("11CDF99A");
        DC.Add("11CDF9A6");
        DC.Add("21D10988");
        DC.Add("21D109B8");
        DC.Add("11CE076E");
        DC.Add("11CE0732");
        DC.Add("11CE0762");

        DC.Add("11CE0A6E"); //AS marluxia
        DC.Add("11CE0AAA"); //data marluxia


        //PR

        PR.Add("11CDFE3E");
        PR.Add("11CDFE4A");
        PR.Add("11CDFE56");
        PR.Add("11CDFE62");
        PR.Add("11CDFE6E");
        PR.Add("11CDFE7A");
        PR.Add("11CDFE86");
        PR.Add("11CDFE92");
        PR.Add("11CDFE9E");
        PR.Add("11CDFEAA");
        PR.Add("11CDFEB6");
        PR.Add("11CDFEC2");
        PR.Add("11CDFECE");
        PR.Add("11CDFEDA");
        PR.Add("11CDFEE6");
        PR.Add("11CDFEF2");
        PR.Add("11CDFEFE");
        PR.Add("11CDFF0A");
        PR.Add("11CDFF16");
        PR.Add("11CDFF22");
        PR.Add("11CDFF2E");
        PR.Add("21D110B8");
        PR.Add("21D10AA8");
        PR.Add("21D11028");
        PR.Add("21D10AE8");
        PR.Add("11CE077A");
        PR.Add("11CE0786");
        PR.Add("11CE086A");
        PR.Add("11CE0876");
        PR.Add("11CE09DE");

        PR.Add("11CE0AFE"); //data luxord


        //Agrabah

        AG.Add("11CDF826");
        AG.Add("11CDF832");
        AG.Add("11CDF83E");
        AG.Add("11CDF84A");
        AG.Add("11CDF856");
        AG.Add("11CDF862");
        AG.Add("11CDF86E");
        AG.Add("11CDF87A");
        AG.Add("11CDF886");
        AG.Add("11CDF892");
        AG.Add("11CDF89E");
        AG.Add("11CDF8AA");
        AG.Add("11CDF8B6");
        AG.Add("11CDF8C2");
        AG.Add("11CDF8CE");
        AG.Add("11CDF8DA");
        AG.Add("11CDF8E6");
        AG.Add("11CDF8F2");
        AG.Add("11CDF8FE");
        AG.Add("11CDF90A");
        AG.Add("11CDF916");
        AG.Add("11CDF922");
        AG.Add("11CDF92E");
        AG.Add("11CDF93A");
        AG.Add("11CDF946");
        AG.Add("11CDF952");
        AG.Add("21D10DB8");
        AG.Add("21D10CE8");
        AG.Add("21D10978");
        AG.Add("11CE0792");
        AG.Add("11CE079E");
        AG.Add("11CE08B2");

        AG.Add("11CE0A4A"); //AS lexaeus
        AG.Add("11CE0A86"); //data lexaeus


        //HT

        HT.Add("11CDFD96");
        HT.Add("11CDFDA2");
        HT.Add("11CDFDAE");
        HT.Add("11CDFDBA");
        HT.Add("11CDFDC6");
        HT.Add("11CDFDD2");
        HT.Add("11CDFDDE");
        HT.Add("11CDFDEA");
        HT.Add("11CDFDF6");
        HT.Add("11CDFE02");
        HT.Add("11CDFE0E");
        HT.Add("11CDFE1A");
        HT.Add("11CDFE26");
        HT.Add("11CDFE32");
        HT.Add("21D109E8");
        HT.Add("11CE07AA");
        HT.Add("11CE08BE");
        HT.Add("11CE08CA");
        HT.Add("11CE08D6");

        HT.Add("11CE0A3E"); //AS vexen
        HT.Add("11CE0A7A"); //data vexen



        //PL

        PL.Add("11CE0042");
        PL.Add("11CE004E");
        PL.Add("11CE005A");
        PL.Add("11CE0066");
        PL.Add("11CE0072");
        PL.Add("11CE007E");
        PL.Add("11CE008A");
        PL.Add("11CE0096");
        PL.Add("11CE00A2");
        PL.Add("11CE00AE");
        PL.Add("11CE00BA");
        PL.Add("11CE00C6");
        PL.Add("11CE00D2");
        PL.Add("11CE00DE");
        PL.Add("11CE00EA");
        PL.Add("11CE00F6");
        PL.Add("11CE0102");
        PL.Add("11CE010E");
        PL.Add("11CE011A");
        PL.Add("11CE0126");
        PL.Add("11CE0132");
        PL.Add("11CE013E");
        PL.Add("11CE014A");
        PL.Add("11CE0156");
        PL.Add("11CE0162");
        PL.Add("21D10C18");
        PL.Add("11CE07B6");
        PL.Add("11CE07C2");

        PL.Add("11CE0AF2"); //data saix


        //Atlantica

        Atlantica.Add("11CE0846");
        Atlantica.Add("11CE08E2");
        Atlantica.Add("11CE08EE");
        Atlantica.Add("11CE08FA");


        //100acrewoods

        hundredacre.Add("11CDFA12");
        hundredacre.Add("11CDFA1E");
        hundredacre.Add("11CDFA2A");
        hundredacre.Add("11CDFA36");
        hundredacre.Add("11CDFA42");
        hundredacre.Add("11CDFA4E");
        hundredacre.Add("11CDFA5A");
        hundredacre.Add("11CDFA66");
        hundredacre.Add("11CDFA72");
        hundredacre.Add("11CDFA7E");
        hundredacre.Add("11CDFA8A");
        hundredacre.Add("11CDFA96");
        hundredacre.Add("11CDFAA2");
        hundredacre.Add("11CDFAAE");
        hundredacre.Add("11CDFABA");
        hundredacre.Add("11CDFAC6");
        hundredacre.Add("11CDFAD2");
        hundredacre.Add("11CDFADE");
        hundredacre.Add("11CDFAEA");
        hundredacre.Add("11CDFAF6");
        hundredacre.Add("11CE0906");
        hundredacre.Add("11CE0912");
        hundredacre.Add("11CE091E");
        hundredacre.Add("11CE092A");


        //SP

        SP.Add("11CDFCEE");
        SP.Add("11CDFCFA");
        SP.Add("11CDFD06");
        SP.Add("11CDFD12");
        SP.Add("11CDFD1E");
        SP.Add("11CDFD2A");
        SP.Add("11CDFD36");
        SP.Add("11CDFD42");
        SP.Add("11CDFD4E");
        SP.Add("11CDFD5A");
        SP.Add("11CDFD66");
        SP.Add("11CDFD72");
        SP.Add("11CDFD7E");
        SP.Add("11CDFD8A");
        SP.Add("21D10C38");
        SP.Add("21D11078");
        SP.Add("21D10C78");
        SP.Add("11CE0816");
        SP.Add("11CE0A62"); //AS larxene
        SP.Add("11CE0A9E"); //data larxene


        //TWNTW

        TWTNW.Add("11CE0402");
        TWTNW.Add("11CE040E");
        TWTNW.Add("11CE041A");
        TWTNW.Add("11CE0426");
        TWTNW.Add("11CE0432");
        TWTNW.Add("11CE043E");
        TWTNW.Add("11CE044A");
        TWTNW.Add("11CE0456");
        TWTNW.Add("11CE0462");
        TWTNW.Add("11CE046E");
        TWTNW.Add("11CE047A");
        TWTNW.Add("11CE0486");
        TWTNW.Add("11CE0492");
        TWTNW.Add("11CE049E");
        TWTNW.Add("11CE04AA");
        TWTNW.Add("11CE04B6");
        TWTNW.Add("11CE04C2");
        TWTNW.Add("11CE04CE");
        TWTNW.Add("11CE04DA");
        TWTNW.Add("21D111E8");
        TWTNW.Add("21D10B58");
        TWTNW.Add("11CE0972");
        TWTNW.Add("11CE097E");
        TWTNW.Add("11CE098A");
        TWTNW.Add("11CE09BA");
        TWTNW.Add("11CE09F6");
        TWTNW.Add("11CE0A02");
        TWTNW.Add("11CE0A1A");
        TWTNW.Add("11CE0A26");
        TWTNW.Add("11CE0A32");

        TWTNW.Add("11CE0ADA"); //data xemnas


        //Forms

        Forms.Add("11D1A22E"); //valor
        Forms.Add("11D1A236");
        Forms.Add("11D1A23E");
        Forms.Add("11D1A246");
        Forms.Add("11D1A24E");
        Forms.Add("11D1A256");
        Forms.Add("11D1A266"); //wisdom
        Forms.Add("11D1A26E");
        Forms.Add("11D1A276");
        Forms.Add("11D1A27E");
        Forms.Add("11D1A286");
        Forms.Add("11D1A28E");
        Forms.Add("11D1A29E"); //limit
        Forms.Add("11D1A2A6");
        Forms.Add("11D1A2AE");
        Forms.Add("11D1A2B6");
        Forms.Add("11D1A2BE");
        Forms.Add("11D1A2C6");
        Forms.Add("11D1A2D6"); //master
        Forms.Add("11D1A2DE");
        Forms.Add("11D1A2E6");
        Forms.Add("11D1A2EE");
        Forms.Add("11D1A2F6");
        Forms.Add("11D1A2FE");
        Forms.Add("11D1A30E"); //Final
        Forms.Add("11D1A316");
        Forms.Add("11D1A31E");
        Forms.Add("11D1A326");
        Forms.Add("11D1A32E");
        Forms.Add("11D1A336");


        //Levels

        Levels.Add("11D0B6C0"); //Lvl 2
        Levels.Add("11D0B6E0"); //Lvl 4
        Levels.Add("11D0B710"); //Lvl 7
        Levels.Add("11D0B730"); //Lvl 9
        Levels.Add("11D0B740"); //Lvl 10
        Levels.Add("11D0B760"); //Lvl 12
        Levels.Add("11D0B780"); //Lvl 14
        Levels.Add("11D0B790"); //Lvl 15
        Levels.Add("11D0B7B0"); //Lvl 17
        Levels.Add("11D0B7E0"); //Lvl 20
        Levels.Add("11D0B810"); //Lvl 23
        Levels.Add("11D0B830"); //Lvl 25
        Levels.Add("11D0B860"); //Lvl 28
        Levels.Add("11D0B880"); //Lvl 30
        Levels.Add("11D0B8A0"); //Lvl 32
        Levels.Add("11D0B8C0"); //Lvl 34
        Levels.Add("11D0B8E0"); //Lvl 36
        Levels.Add("11D0B910"); //Lvl 39
        Levels.Add("11D0B930"); //Lvl 41
        Levels.Add("11D0B960"); //Lvl 44
        Levels.Add("11D0B980"); //Lvl 46
        Levels.Add("11D0B9A0"); //Lvl 48
        Levels.Add("11D0B9C0"); //Lvl 50

        Levels.Add("11D0B6D0"); //Lvl 3
        Levels.Add("11D0B6F0"); //Lvl 5
        Levels.Add("11D0B700"); //Lvl 6
        Levels.Add("11D0B720"); //Lvl 8
        Levels.Add("11D0B750"); //Lvl 11
        Levels.Add("11D0B770"); //Lvl 13
        Levels.Add("11D0B7A0"); //Lvl 16
        Levels.Add("11D0B7C0"); //Lvl 18
        Levels.Add("11D0B7D0"); //Lvl 19
        Levels.Add("11D0B7F0"); //Lvl 21
        Levels.Add("11D0B800"); //Lvl 22
        Levels.Add("11D0B820"); //Lvl 24
        Levels.Add("11D0B840"); //Lvl 26
        Levels.Add("11D0B850"); //Lvl 27
        Levels.Add("11D0B870"); //Lvl 29
        Levels.Add("11D0B890"); //Lvl 31
        Levels.Add("11D0B8B0"); //Lvl 33
        Levels.Add("11D0B8D0"); //Lvl 35
        Levels.Add("11D0B8F0"); //Lvl 37
        Levels.Add("11D0B920"); //Lvl 40
        Levels.Add("11D0B940"); //Lvl 42
        Levels.Add("11D0B950"); //Lvl 43
        Levels.Add("11D0B970"); //Lvl 45
        Levels.Add("11D0B990"); //Lvl 47
        Levels.Add("11D0B9B0"); //Lvl 49

        Levels.Add("11D0B9D0"); //Lvl 51-99
        Levels.Add("11D0B9E0");
        Levels.Add("11D0B9F0");
        Levels.Add("11D0BA00");
        Levels.Add("11D0BA10");
        Levels.Add("11D0BA20");
        Levels.Add("11D0BA30");
        Levels.Add("11D0BA40");
        Levels.Add("11D0BA50");
        Levels.Add("11D0BA60");
        Levels.Add("11D0BA70");
        Levels.Add("11D0BA80");
        Levels.Add("11D0BA90");
        Levels.Add("11D0BAA0");
        Levels.Add("11D0BAB0");
        Levels.Add("11D0BAC0");
        Levels.Add("11D0BAD0");
        Levels.Add("11D0BAE0");
        Levels.Add("11D0BAF0");
        Levels.Add("11D0BB00");
        Levels.Add("11D0BB10");
        Levels.Add("11D0BB20");
        Levels.Add("11D0BB30");
        Levels.Add("11D0BB40");
        Levels.Add("11D0BB50");
        Levels.Add("11D0BB60");
        Levels.Add("11D0BB70");
        Levels.Add("11D0BB80");
        Levels.Add("11D0BB90");
        Levels.Add("11D0BBA0");
        Levels.Add("11D0BBB0");
        Levels.Add("11D0BBC0");
        Levels.Add("11D0BBD0");
        Levels.Add("11D0BBE0");
        Levels.Add("11D0BBF0");
        Levels.Add("11D0BC00");
        Levels.Add("11D0BC10");
        Levels.Add("11D0BC20");
        Levels.Add("11D0BC30");
        Levels.Add("11D0BC40");
        Levels.Add("11D0BC50");
        Levels.Add("11D0BC60");
        Levels.Add("11D0BC70");
        Levels.Add("11D0BC80");
        Levels.Add("11D0BC90");
        Levels.Add("11D0BCA0");
        Levels.Add("11D0BCB0");
        Levels.Add("11D0BCC0");
        Levels.Add("11D0BCD0");



       
    }
}
