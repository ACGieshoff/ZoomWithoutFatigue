using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaterialChanger : MonoBehaviour
{
    public Material[] startMaterial;

    public Material[] materialsTraining;
    public float[] changeDurationsTraining;
    public int maxNumberSlidesTraining;

    public Material[] materialsA;
    public float[] changeDurationsA;
    public int maxNumberSlidesA;

    public Material[] materialsB;
    public float[] changeDurationsB;
    public int maxNumberSlidesB;

    public Material[] materialsIntroA;
    public float[] changeDurationsIntroA;
    public int maxNumberSlidesIntroA;

    public Material[] materialsIntroB;
    public float[] changeDurationsIntroB;
    public int maxNumberSlidesIntroB;

    private Material[] currentMaterials;
    private float[] currentChangeDurations;
    private int currentMaterialIndex = 0;
    private int maxNumberSlides;
    private float timeLeft = 0f;
    private bool isChanging = false;

    private void Start()
    {
        currentMaterials = startMaterial;
        //currentChangeDurations = changeDurationsA;
        //GetComponent<Renderer>().material = currentMaterials[0];
        //timeLeft = currentChangeDurations[0];
    }

    private void Update()
    {
        if (!isChanging)
        {
            return;
        }

        timeLeft -= Time.deltaTime;

        if (timeLeft <= 0f)
        {
            currentMaterialIndex++;
            if (currentMaterialIndex >= currentMaterials.Length)
            {
                // currentMaterialIndex = 0;
                currentMaterialIndex = maxNumberSlides-1;
                Debug.Log("Material index: " + currentMaterialIndex);
            }
            GetComponent<Renderer>().material = currentMaterials[currentMaterialIndex];
            timeLeft = currentChangeDurations[currentMaterialIndex];
            // Debug.Log("time left: " + timeLeft);
        }
    }

    public void StartChanging()
    {
        isChanging = true;
    }

    public void StopChanging()
    {
        isChanging = false;
        currentMaterialIndex = 0;
        GetComponent<Renderer>().material = currentMaterials[currentMaterialIndex];
        timeLeft = currentChangeDurations[currentMaterialIndex];
    }

    public void PickSlidesTraining()
    {
        maxNumberSlides = maxNumberSlidesTraining;
        currentMaterials = materialsTraining;
        currentChangeDurations = changeDurationsTraining;
        currentMaterialIndex = 0;
        GetComponent<Renderer>().material = currentMaterials[0];
        timeLeft = currentChangeDurations[0];
    }


    public void PickSlidesA()
    {
        maxNumberSlides = maxNumberSlidesA;
        currentMaterials = materialsA;
        currentChangeDurations = changeDurationsA;
        currentMaterialIndex = 0;
        GetComponent<Renderer>().material = currentMaterials[0];
        timeLeft = currentChangeDurations[0];
    }

    public void PickSlidesB()
    {
        maxNumberSlides = maxNumberSlidesB;
        currentMaterials = materialsB;
        currentChangeDurations = changeDurationsB;
        currentMaterialIndex = 0;
        GetComponent<Renderer>().material = currentMaterials[0];
        timeLeft = currentChangeDurations[0];
    }

    public void PickSlidesIntroA()
    {
        maxNumberSlides = maxNumberSlidesIntroA;
        currentMaterials = materialsIntroA;
        currentChangeDurations = changeDurationsIntroA;
        currentMaterialIndex = 0;
        GetComponent<Renderer>().material = currentMaterials[0];
        timeLeft = currentChangeDurations[0];
    }

    public void PickSlidesIntroB()
    {
        maxNumberSlides = maxNumberSlidesIntroB;
        currentMaterials = materialsIntroB;
        currentChangeDurations = changeDurationsIntroB;
        currentMaterialIndex = 0;
        GetComponent<Renderer>().material = currentMaterials[0];
        timeLeft = currentChangeDurations[0];
    }
}

