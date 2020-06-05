﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckAnswer : MonoBehaviour
{
    /* public List<Sprite> spriteLists = new List<Sprite>();
    public SpriteRenderer monıtorSprite;*/

    //[Header("OBJECTS")]
    public GameObject iceBox, waterBox, waterVapour,
        ironBox, oilBox, heliumBox,
        saltBox, juiceBox, hydrogenBox;
    public GameObject solidBox, liquidBox, gasBox;

    [Header("OBJECTS' VECTORS")]
    /*private Vector3 iceBoxPos, waterBoxPos, waterVapourPos,
        ironBoxPos, oilBoxPox, heliumBoxPos,
        saltBoxPos, juiceBoxPos, hydrogenBoxPos;
    private Vector3 solidBoxPos, liquidBoxPos, gasBoxPos;*/
    private Vector3 iceBoxInitial, waterBoxInitial, waterVapourInitial,
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


    public void DragIceBox()
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

    //Button

    public void Check()
    {

        if (solidCorrect == true && liquidCorrect == true && gasCorrect == true)
        {
            trueAnswer.SetActive(true);
        }
        else wrongAnswer.SetActive(true); //hepsinin aynı olmadığı her versiyon için yanlış olanı feedback?

    }

    public void Reload()
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

    IEnumerator LoadNextPanel()
    {
        yield return new WaitForSeconds(3f);
        trueAnswer.SetActive(false);
        wrongAnswer.SetActive(true);
    }
}

