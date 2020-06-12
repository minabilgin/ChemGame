using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CheckAnswer : MonoBehaviour
{
   // public List<GameObject> listBox;
    //public GameObject solidBox, liquidBox, gasBox;
    public GameObject TrueAnswer, FalseAnswer;
    //public string levelName = "";
    private bool isSolid, isLiquid, isGas;

    private void Start()
    {
        isSolid = false;
        isLiquid = false;
        isGas = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("OTS");
        Debug.Log("Other = " + other.name);
        Debug.Log("This = " + this.name);
        //This = Azot, Tahta Kutu, Çay
        //Other = DropSolid, DropLiquid, DropGas, başka scriptten çekiyor. 
        //Bir şekilde tamamını true döndürüyor ama buton doğru da konsa hepsini yanlış görüyor. 
        //Image'leri active etmiyor. 
        //UPDATE: Yerdeki itemlerin colliderlarını kaldırdığımda OnTriggerStay'e girmiyor. 
        //Dolayısıyla şu an hangisi this hangisi other belli değil.
        //This Çarpıştırdığım, other çarpıştırılan ise, area'ları duruyor kabul ediyor, 
        //Objelerimi hareket ediyor kabul ediyor. 

        if (other.CompareTag("Solid") && this.CompareTag("Solid"))
        {
            isSolid = true;
            Debug.Log("Solid true" + isSolid);
        }
        if (other.CompareTag("Liquid") && this.CompareTag("Liquid"))
        {
            isLiquid = true;
            Debug.Log("Liquid true" + isLiquid);
        }
        if (other.CompareTag("Gas") && this.CompareTag("Gas"))
        {
            isGas = true;
            Debug.Log("Gas true" + isGas);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Solid") && this.CompareTag("Solid"))
        {
            isSolid = false;
            Debug.Log("Solid False");
        }
        if (other.CompareTag("Liquid") && this.CompareTag("Liquid"))
        {
            isLiquid = false;
            Debug.Log("Liquid False");
        }
        if (other.CompareTag("Gas") && this.CompareTag("Gas"))
        {
            isGas = false;
            Debug.Log("GasFalse");
        }

    }


    public void CheckButton()
    {
        /*CheckGas();
        CheckLiquid();
        CheckSolid();
        */

        //UPDATE: OnTrigger Event'lar true false değerlerini doğru döndürüyor ama:
        //CheckButton bu değerleri absolute false görüyor, değerlerin true larını alamıyorum. 

        if (isSolid == true && isLiquid == true && isGas == true)
        {
            TrueAnswer.SetActive(true);
        }
        else if (isSolid == false && isLiquid == true && isGas == true)
        {
            Debug.Log("SOLID false.");
        }
        else if (isSolid == true && isLiquid == false && isGas == true)
        {
            Debug.Log("LIQUID false.");
        }
        else if (isSolid == true && isLiquid == true && isGas == false)
        {
            Debug.Log("GAS false."); 
        }
        else
        {
            Debug.Log("none is true");
            FalseAnswer.SetActive(true);
        }
    }










































    /*
public void CheckSolid ()
{
    Debug.Log("Check Solid");
   // Debug.Log(solidBox.tag.ToString());

    isSolid = false;
    for (int i = 0; i < listBox.Count; i++)
    {
        if (listBox[i].tag == solidBox.tag)
        {
            isSolid = true;
            Debug.Log("solid dogru");

        }
        else isSolid = false;
    }
   /* if (other.CompareTag("Solid") && this.CompareTag("Solid"))
    {
        isSolid = true;
    }
}*/

    /*public void CheckLiquid()
    {
        Debug.Log("Check Liquid");
       // Debug.Log(liquidBox.tag.ToString());

        isLiquid = false;
        for (int i = 0; i < listBox.Count; i++)
        {
            if (listBox[i].tag == liquidBox.tag)
            {
                isLiquid = true;
                Debug.Log("sivi dogru");

            }
            else isLiquid = false;
        }
        /* if (other.CompareTag("Liquid") && this.CompareTag("Liquid"))
         {
             isLiquid = true;
         }
    }
    */
    /*public void CheckGas()
    {
        Debug.Log("Check Gas");
        //Debug.Log(gasBox.tag.ToString());

        isGas = false;
        for (int i = 0; i < listBox.Count; i++)
        {
            if (listBox[i].tag == gasBox.tag)
            {
                isGas = true;
                Debug.Log("gas dogru");

            }
            else isGas = false;
        }
        /* if (other.CompareTag("Liquid") && this.CompareTag("Liquid"))
         {
             isGas = true;
         }
    }*/




    // public void CheckButton(Collider other)
    //{
    /* if (other.CompareTag("Solid") && this.CompareTag("Solid"))
     {
         if (other.CompareTag("Liquid") && this.CompareTag("Liquid"))
         {
             if (other.CompareTag("Gas") && this.CompareTag("Gas"))
             {
                 SceneManager.LoadScene(levelName);
             }
             else
             {
                 TrueOrFalse.SetActive(false);
             }
         }
         else
         {
             TrueOrFalse.SetActive(false);
         }
     }
     else
     {
         TrueOrFalse.SetActive(false);
        // listGas[0].CompareTag
     }*/

    // }


    /* public List<Sprite> spriteLists = new List<Sprite>();
    public SpriteRenderer monıtorSprite;*/

    //[Header("OBJECTS")]
    /* public GameObject iceBox, waterBox, waterVapour,
         ironBox, oilBox, heliumBox,
         saltBox, juiceBox, hydrogenBox;
     public GameObject solidBox, liquidBox, gasBox;

     [Header("OBJECTS' VECTORS")]*/
    /*private Vector3 iceBoxPos, waterBoxPos, waterVapourPos,
        ironBoxPos, oilBoxPox, heliumBoxPos,
        saltBoxPos, juiceBoxPos, hydrogenBoxPos;
    private Vector3 solidBoxPos, liquidBoxPos, gasBoxPos;*/
    /* private Vector3 iceBoxInitial, waterBoxInitial, waterVapourInitial,
         ironBoxInitial, oilBoxInitial, heliumBoxInitial,
         saltBoxInitial, juiceBoxInitial, hydrogenBoxInitial;
     private Vector3 iniScale_iceBox, iniScale_waterBox, iniScale_waterVapour,
             iniScale_ironBox, iniScale_oilBox, iniScale_heliumBox,
             iniScale_saltBox, iniScale_juiceBox, iniScale_hydrogenBox;

     bool solidCorrect, liquidCorrect, gasCorrect = false;

     private string str = "";
     //public string word;

     public GameObject trueAnswer, wrongAnswer;

     void Start()
     {
         iceBoxInitial = iceBox.transform.position;
         waterBoxInitial = waterBox.transform.position;
         waterVapourInitial = waterVapour.transform.position;
         ironBoxInitial = ironBox.transform.position;
         oilBoxInitial = oilBox.transform.position;
         heliumBoxInitial = heliumBox.transform.position;
         saltBoxInitial = saltBox.transform.position;
         juiceBoxInitial = juiceBox.transform.position;
         hydrogenBoxInitial = hydrogenBox.transform.position;

         iniScale_iceBox = iceBox.transform.localScale;
         iniScale_waterBox = waterBox.transform.localScale;
         iniScale_waterVapour = waterVapour.transform.localScale;
         iniScale_ironBox = ironBox.transform.localScale;
         iniScale_oilBox = oilBox.transform.localScale;
         iniScale_heliumBox = heliumBox.transform.localScale;
         iniScale_saltBox = saltBox.transform.localScale;
         iniScale_juiceBox = juiceBox.transform.localScale;
         iniScale_hydrogenBox = hydrogenBox.transform.localScale;

         // blockPanel.SetActive(false);
     }
     */

    /*   public void DragIceBox()
       {
           iceBox.transform.position = Input.mousePosition;
       }
       public void DragWaterBox()
       {
           waterBox.transform.position = Input.mousePosition;
       }
       public void DragWaterVapour()
       {
           waterVapour.transform.position = Input.mousePosition;
       }
       public void DragIronBox()
       {
           ironBox.transform.position = Input.mousePosition;
       }
       public void DragOilBox()
       {
           oilBox.transform.position = Input.mousePosition;
       }
       public void DragHeliumBox()
       {
           heliumBox.transform.position = Input.mousePosition;
       }
       public void DragSaltBox()
       {
           saltBox.transform.position = Input.mousePosition;
       }
       public void DragJuiceBox()
       {
           juiceBox.transform.position = Input.mousePosition;
       }
       public void DragHydrogenBox()
       {
           hydrogenBox.transform.position = Input.mousePosition;
       }
       */
    /*
    public void DropSolid()
    {
        float Distance = Vector3.Distance(iceBox.transform.position, solidBox.transform.position);
        float Distance4 = Vector3.Distance(ironBox.transform.position, solidBox.transform.position);
        float Distance7 = Vector3.Distance(saltBox.transform.position, solidBox.transform.position);

        if (Distance < 50 && solidCorrect == false)
        {
            iceBox.transform.localScale = solidBox.transform.localScale;
            iceBox.transform.position = solidBox.transform.position;
            solidCorrect = true;
            solidBox.name = iceBox.name;
        }

        else if (Distance4 < 50 && solidCorrect == false)
        {
            ironBox.transform.localScale = solidBox.transform.localScale;
            ironBox.transform.position = solidBox.transform.position;
            solidCorrect = true;
            solidBox.name = ironBox.name;
        }

        else if (Distance7 < 50 && solidCorrect == false)
        {
            saltBox.transform.localScale = solidBox.transform.localScale;
            saltBox.transform.position = solidBox.transform.position;
            solidCorrect = true;
            solidBox.name = saltBox.name;
        }
    }


    public void DropLiquid()
    {
        float Distance2 = Vector3.Distance(waterBox.transform.position, liquidBox.transform.position);
        float Distance5 = Vector3.Distance(oilBox.transform.position, liquidBox.transform.position);
        float Distance8 = Vector3.Distance(juiceBox.transform.position, liquidBox.transform.position);


        if (Distance2 < 50 && liquidCorrect == false)
        {
            waterBox.transform.localScale = liquidBox.transform.localScale;
            waterBox.transform.position = liquidBox.transform.position;
            liquidCorrect = true;
            liquidBox.name = waterBox.name;
        }

        else if (Distance5 < 50 && liquidCorrect == false)
        {
            oilBox.transform.localScale = liquidBox.transform.localScale;
            oilBox.transform.position = liquidBox.transform.position;
            liquidCorrect = true;
            liquidBox.name = oilBox.name;
        }

        else if (Distance8 < 50 && liquidCorrect == false)
        {
            juiceBox.transform.localScale = liquidBox.transform.localScale;
            juiceBox.transform.position = liquidBox.transform.position;
            liquidCorrect = true;
            liquidBox.name = juiceBox.name;
        }
    }


    public void DropGas()
    {
        float Distance3 = Vector3.Distance(waterVapour.transform.position, gasBox.transform.position);
        float Distance6 = Vector3.Distance(heliumBox.transform.position, gasBox.transform.position);
        float Distance9 = Vector3.Distance(hydrogenBox.transform.position, gasBox.transform.position);

        if (Distance3 < 50 && gasCorrect == false)
        {
            waterVapour.transform.localScale = gasBox.transform.localScale;
            waterVapour.transform.position = gasBox.transform.position;
            gasCorrect = true;
            gasBox.name = waterVapour.name;
        }

        else if (Distance6 < 50 && gasCorrect == false)
        {
            heliumBox.transform.localScale = gasBox.transform.localScale;
            heliumBox.transform.position = gasBox.transform.position;
            gasCorrect = true;
            gasBox.name = heliumBox.name;
        }

        else if (Distance9 < 50 && gasCorrect == false)
        {
            hydrogenBox.transform.localScale = gasBox.transform.localScale;
            hydrogenBox.transform.position = gasBox.transform.position;
            gasCorrect = true;
            gasBox.name = hydrogenBox.name;
        }
    }
    */
    //Button
    /*
    public void Check()
    {

        if (solidCorrect == true && liquidCorrect == true && gasCorrect == true)
        {
            trueAnswer.SetActive(true);
        }
        else wrongAnswer.SetActive(true); //hepsinin aynı olmadığı her versiyon için yanlış olanı feedback?

    }*/

    /*public void Reload()
    {
        str = "";

        solidCorrect = false;
        liquidCorrect = false;
        gasCorrect = false;

        solidBox.name = "1";
        liquidBox.name = "2";
        gasBox.name = "3";

        iceBox.transform.position = iceBoxInitial;
        waterBox.transform.position = waterBoxInitial;
        waterVapour.transform.position = waterVapourInitial;
        ironBox.transform.position = ironBoxInitial;
        oilBox.transform.position = oilBoxInitial;
        heliumBox.transform.position = heliumBoxInitial;
        saltBox.transform.position = saltBoxInitial;
        juiceBox.transform.position = juiceBoxInitial;
        hydrogenBox.transform.position = hydrogenBoxInitial;

        iceBox.transform.localScale = iniScale_iceBox;
        waterBox.transform.localScale = iniScale_waterBox;
        waterVapour.transform.localScale = iniScale_waterVapour;
        ironBox.transform.localScale = iniScale_ironBox;
        oilBox.transform.localScale = iniScale_oilBox;
        heliumBox.transform.localScale = iniScale_heliumBox;
        saltBox.transform.localScale = iniScale_saltBox;
        juiceBox.transform.localScale = iniScale_juiceBox;
        hydrogenBox.transform.localScale = iniScale_hydrogenBox;

    }
    *//*
    IEnumerator LoadNextPanel()
    {
        yield return new WaitForSeconds(3f);
        trueAnswer.SetActive(false);
        wrongAnswer.SetActive(true);
    }*/
}

