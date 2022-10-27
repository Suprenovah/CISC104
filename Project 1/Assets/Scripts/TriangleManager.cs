using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TriangleManager : MonoBehaviour
{
    private Triangle myTriangle;

    public Slider baseSlider;
    public Slider heightSlider;
    public Slider side1Slider;
    public Slider side2Slider;

    public GameObject baseTextObject;
    public GameObject heightTextObject;
    public GameObject side1TextObject;
    public GameObject side2TextObject;
    public GameObject perimeterTextObject;
    public GameObject areaTextObject;

    private TextMeshProUGUI baseText { get; set; }
    private TextMeshProUGUI heightText { get; set; }
    private TextMeshProUGUI side1Text { get; set; }
    private TextMeshProUGUI side2Text { get; set; }
    private TextMeshProUGUI perimeterText { get; set; }
    private TextMeshProUGUI areaText { get; set; }

    // Start is called before the first frame update
    void Start()
    {
        baseText = baseTextObject.GetComponent<TextMeshProUGUI>();
        heightText = heightTextObject.GetComponent<TextMeshProUGUI>();
        side1Text = side1TextObject.GetComponent<TextMeshProUGUI>();
        side2Text = side2TextObject.GetComponent<TextMeshProUGUI>();
        perimeterText = perimeterTextObject.GetComponent<TextMeshProUGUI>();
        areaText = areaTextObject.GetComponent<TextMeshProUGUI>();

        myTriangle = new Triangle();

        GetValuesFromSliders();
    }

    // Update is called once per frame
    void Update()
    {
        baseText.text = "Triangle Base: " + myTriangle.GetBase().ToString();
        heightText.text = "Triangle Height: " + myTriangle.GetHeight().ToString();
        side1Text.text = "Triangle Side 1: " + myTriangle.GetSide1().ToString();
        side2Text.text = "Triangle Side 2: " + myTriangle.GetSide2().ToString();
        perimeterText.text = "Triangle Perimeter: " + myTriangle.GetPerimeter().ToString();
        areaText.text = "Triangle Area: " + myTriangle.GetArea().ToString();
    }

    public void SliderChanged(float newValue)
    {
        GetValuesFromSliders();
    }

    private void GetValuesFromSliders()
    {
        myTriangle.SetBase(baseSlider.value);
        myTriangle.SetHeight(heightSlider.value);
        myTriangle.SetSide1(side1Slider.value);
        myTriangle.SetSide2(side2Slider.value);
    }
}