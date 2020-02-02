using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using InteractML;

/// <summary>
/// Pipes data and logic between InteractML and the Unity UI system
/// </summary>
public class IMLPipeUI : MonoBehaviour
{

    // Text to update the UI
    [Header("UI Setup")]
    public Text ExamplesText;
    public Text TrainingStatusText;

    [Header("InteractML Setup")]
    public IMLComponent MLComponent; 

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (MLComponent)
        {
            // Update UI
            // Go through each model node (IML Config)
            foreach (var modelNode in MLComponent.IMLConfigurationNodesList)
            {
                if (modelNode != null)
                {
                    // Collected Examples
                    if (ExamplesText)
                    {
                        ExamplesText.text = modelNode.TotalNumTrainingData.ToString();
                    }
                    // Training Status
                    if (TrainingStatusText)
                    {
                        TrainingStatusText.text = modelNode.ModelStatus.ToString();
                    }
                }
            }
        }
    }

}
